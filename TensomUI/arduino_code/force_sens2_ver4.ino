
#include "HX711.h"  
#include <StepDirDriverPoz.h>
#include "timer-api.h" 
#define THERMISTORPIN A0
#define THERMISTORNOMINAL 10000
#define TEMPERATURENOMINAL 25
#define NUMSAMPLES 5
#define BCOEFFICIENT 3950
#define SERIESRESISTOR 10000
int samples[NUMSAMPLES];

const int ST1 = 8, DIR1 = 9, EN1 = 10;
StepDirDriverPoz Mot1(ST1,DIR1, EN1);
#define DOUT  7
#define CLK  6
const int light =4, heater = 5;

volatile int dir_move = 1;
volatile int vel_move = 10;
volatile int force_dest = 0;
volatile int force_en =1;

volatile int light_en =1;
//settings up/down
volatile int count_time=0;
volatile int force_prev = 0;
volatile int sensor_upping = 0;
volatile int sensor_downing = 0;

//settings for comp_vel
const float nT = 5000;
const float P = 2;
const float rev = 200*16;

//setings cycle
volatile unsigned long int prog_start = 0;
volatile int force_max = 6000;
volatile unsigned long int time_force = 20000;
volatile unsigned long int time_relax = 4000;
volatile int cycle_type =0; //0 - off, 1 - meandr; 2 - triangle; 3 - sinus
float steinhart = 0;


HX711 scale;

void move_mot(float vel,int steps = 2500)
{
  int dir = 0 ;
  if(vel<0) dir = 1;
  if(vel>0) dir = 2;
  if(vel==0) dir = 0;
  switch(dir)
  {
    case 0: Mot1.step(0); break;
    case 1: Mot1.step(steps); break;
    case 2: Mot1.step(-steps); break;
    default: break;
  }
  int vel_div = comp_vel(vel); 
  Mot1.setDivider(vel_div);
}

void setup() {
  
  Mot1.setMode(0, true);
  Mot1.setDivider(0);
  pinMode(light, OUTPUT);
  pinMode(heater, OUTPUT);
  digitalWrite(light,1);
  digitalWrite(heater,1);
  
  init_tens_tens();
  Serial.begin(250000);
  timer_init_ISR_5KHz(TIMER_DEFAULT);//nT must be same
}

void print_temperature()
{
  uint8_t i;
  float average;
  for (i=0; i< NUMSAMPLES; i++) { 
    samples[i] = analogRead(THERMISTORPIN);  
  }
    average = 0;  
  for (i=0; i< NUMSAMPLES; i++) { 
    average += samples[i];
  }
  average /= NUMSAMPLES;   
  average = 1023 / average - 1;  
  average = SERIESRESISTOR / average;  
   
  steinhart = average / THERMISTORNOMINAL; // (R/Ro)
  steinhart = log(steinhart); // ln(R/Ro)  
  steinhart /= BCOEFFICIENT; // 1/B * ln(R/Ro) 
  steinhart += 1.0 / (TEMPERATURENOMINAL + 273.15); // + (1/To) 
  steinhart = 1.0 / steinhart; // инвертируем
  steinhart -= 273.15; // конвертируем в градусы по Цельсию
  //Serial.print("Temperature "); 
 // Serial.print(steinhart);  
  //Serial.println(" *C");
}

void loop() 
{
  int force = var_out();
  decod_main();
  print_temperature();
  if(cycle_type==0)
  {
    if (force_en==1)  
    {
      set_force_step(force);
    }    
    else
    {
      move_mot((dir_move-1)*vel_move);
    }
  }
  else
  {
    comp_cycle(force);     
  }   
  up_sensor(force);    
  down_sensor(force); 
}



void up_sensor(float cur_force)
{
  if(sensor_upping==1)
  {
    force_dest = -15000;
    set_force_step(cur_force);
    if(count_time==0){
      force_prev = cur_force;      
    }
    if(count_time==10)
    {
      float force_delt = cur_force - force_prev;
      if (force_delt<2)
      {
        sensor_upping = 0;
        scale.tare();
        force_dest = 0;
        set_force_step(cur_force);
      }
      count_time =0;
    }
    force_prev = cur_force;
    count_time++;    
  }  
}

void down_sensor(float cur_force)
{
  if(sensor_downing==1)
  {
    force_dest = 5000;
    set_force_step(cur_force);
    if(cur_force>50){ 
      
       force_dest = 50;
       set_force_step(cur_force);
       if(cur_force<100)
       {
          sensor_downing = 0;
          count_time  = 0;
       }
    } 
    count_time++;    
  }  
}

float comp_force(float fi, int type)
{
  switch(type)
  {
    case 1: return 1;break;
    case 2: if(fi<0.5) return 2*fi; else return 1 - 2*(fi-0.5);break;
    case 3: return sin(PI*fi);break;
    default: return 0;break;
  }
}

void comp_cycle(int cur_force)
{
  if(cycle_type==0)
  {
    return;
  }
  long int dt = get_current_time();
  float fi = (float)dt/(float)time_force;
  float force_ampl = force_max*comp_force(fi,cycle_type);
  if (dt>time_force) force_ampl = force_max*0.1; 
  if (dt>time_force+time_relax) start_time();
  force_dest = force_ampl;
  set_force_step(cur_force);
}

unsigned long int get_current_time()
{
  return millis()-prog_start;
}

void start_time()
{
  prog_start = millis();
}

void set_force(int cur_force)
{
  int sign = 0;
  if(cur_force - force_dest>0) sign = 1;
  if(cur_force - force_dest<0) sign = -1;
  int delt_f_abs = abs(cur_force - force_dest);
  vel_move = sqrt(delt_f_abs) ;
  float k_p = 10;
  if(force_dest*0.03<delt_f_abs)
  {
    move_mot(k_p*sign*vel_move);
  }
  else
  {
    move_mot(0);
  }    
}

void set_force_step(int cur_force)
{
  int sign = 0;
  if(cur_force - force_dest>0) sign = 1;
  if(cur_force - force_dest<0) sign = -1;
  int delt_f_abs = abs(cur_force - force_dest);
  vel_move = sqrt(delt_f_abs) ;
  float k_v_p = 10;
  float k_p_p = 0.1;
  if(force_dest*0.003<delt_f_abs)
  {
    move_mot(k_v_p*sign*vel_move,(int)(k_p_p*delt_f_abs));
  }
  else
  {
    move_mot(0);
  }    
}



void init_tens_tens()
{
  float calibration_factor = 209.300; 
  scale.begin(DOUT, CLK);
  scale.set_scale(calibration_factor);
  delay(500);
  scale.tare();
}

int comp_vel(float vel)
{  
   int vel_div = abs((int)((1000*nT*P)/(vel*rev))); 
   return vel_div;
}


int var_out()
{
  int var_pr = (int)scale.get_units();
  Serial.print(var_pr );
  Serial.print(" ");
  Serial.print(force_dest);
  Serial.print(" ");
  Serial.print(Mot1.readPoz());
  Serial.print(" ");
  Serial.print(steinhart);
  Serial.print(" ");
  Serial.println("");
  return var_pr;
}

void timer_handle_interrupts(int timer)
{
    Mot1.control();    
}


void decod_main()
{
  if(Serial.available()>7) //если входящее сообщение больше 14 байт
  {
      bool err = false;
      int inserial[10];
      if (Serial.read() == 98)
      {
        for (int i = 0; i < 7; i++)
        {
          inserial[i] = Serial.read() - 48;//переводим числа из кодировки ASCII
          if(inserial[i]<0)
          {
             err  = true;
          }
          //Serial.println(inserial[i]);
        }
        if(err==false){          
          int val = inserial[0] * 1000 + inserial[1] * 100 + inserial[2]* 10 + inserial[3];
          int var = inserial[4] * 100 + inserial[5] * 10 + inserial[6];          
          
          switch(var)
          {
            case 0: dir_move = val; break;
            case 1: vel_move = val; break;
            case 2: force_dest = val; break;
            case 3: force_en = val; break;
            case 4: cycle_type = val; break;
            case 5: sensor_upping = val; break;
            case 6: sensor_downing = val; break;
            case 7: force_max = val;break;
            case 8: time_force = val;break;
            case 9: time_relax = val;break;
            case 10: light_en = val;digitalWrite(light,light_en);break;
            default: break;
            
          }
          //Serial.println(dir_move);
          //Serial.println(vel_move);
        }
        else
        {
          Serial.println("err");
        }
    
    }
  }
}
