namespace TensomUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.but_find_ports = new System.Windows.Forms.Button();
            this.combo_ard_port = new System.Windows.Forms.ComboBox();
            this.but_connect = new System.Windows.Forms.Button();
            this.but_disconnect = new System.Windows.Forms.Button();
            this.but_enable_force = new System.Windows.Forms.Button();
            this.but_disable_force = new System.Windows.Forms.Button();
            this.but_set_force = new System.Windows.Forms.Button();
            this.text_b_force_dest = new System.Windows.Forms.TextBox();
            this.but_cycle_settings = new System.Windows.Forms.Button();
            this.text_b_time_force = new System.Windows.Forms.TextBox();
            this.text_b_time_relax = new System.Windows.Forms.TextBox();
            this.text_b_force_max = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_tens_up = new System.Windows.Forms.Button();
            this.but_tens_down = new System.Windows.Forms.Button();
            this.combo_cycle_type = new System.Windows.Forms.ComboBox();
            this.but_cycle_start = new System.Windows.Forms.Button();
            this.but_cycle_stop = new System.Windows.Forms.Button();
            this.but_disable_light = new System.Windows.Forms.Button();
            this.but_enable_light = new System.Windows.Forms.Button();
            this.imB_graphics = new Emgu.CV.UI.ImageBox();
            this.but_test = new System.Windows.Forms.Button();
            this.timer_feedback = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label_feedback = new System.Windows.Forms.Label();
            this.but_clear_data = new System.Windows.Forms.Button();
            this.but_save_data = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.but_down_vel = new System.Windows.Forms.Button();
            this.tb_down_vel = new System.Windows.Forms.TextBox();
            this.but_up_vel = new System.Windows.Forms.Button();
            this.tb_up_vel = new System.Windows.Forms.TextBox();
            this.but_set_k_p = new System.Windows.Forms.Button();
            this.tb_k_p = new System.Windows.Forms.TextBox();
            this.tb_k_v = new System.Windows.Forms.TextBox();
            this.but_set_k_v = new System.Windows.Forms.Button();
            this.but_move_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imB_graphics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_find_ports
            // 
            this.but_find_ports.Location = new System.Drawing.Point(9, 10);
            this.but_find_ports.Margin = new System.Windows.Forms.Padding(2);
            this.but_find_ports.Name = "but_find_ports";
            this.but_find_ports.Size = new System.Drawing.Size(104, 30);
            this.but_find_ports.TabIndex = 0;
            this.but_find_ports.Text = "Найти порты";
            this.but_find_ports.UseVisualStyleBackColor = true;
            this.but_find_ports.Click += new System.EventHandler(this.but_find_ports_Click);
            // 
            // combo_ard_port
            // 
            this.combo_ard_port.FormattingEnabled = true;
            this.combo_ard_port.Location = new System.Drawing.Point(139, 15);
            this.combo_ard_port.Margin = new System.Windows.Forms.Padding(2);
            this.combo_ard_port.Name = "combo_ard_port";
            this.combo_ard_port.Size = new System.Drawing.Size(103, 21);
            this.combo_ard_port.TabIndex = 1;
            this.combo_ard_port.SelectedIndexChanged += new System.EventHandler(this.combo_ard_port_SelectedIndexChanged);
            // 
            // but_connect
            // 
            this.but_connect.Location = new System.Drawing.Point(137, 45);
            this.but_connect.Margin = new System.Windows.Forms.Padding(2);
            this.but_connect.Name = "but_connect";
            this.but_connect.Size = new System.Drawing.Size(104, 30);
            this.but_connect.TabIndex = 2;
            this.but_connect.Text = "Подключиться";
            this.but_connect.UseVisualStyleBackColor = true;
            this.but_connect.Click += new System.EventHandler(this.but_connect_Click);
            // 
            // but_disconnect
            // 
            this.but_disconnect.Location = new System.Drawing.Point(137, 80);
            this.but_disconnect.Margin = new System.Windows.Forms.Padding(2);
            this.but_disconnect.Name = "but_disconnect";
            this.but_disconnect.Size = new System.Drawing.Size(104, 30);
            this.but_disconnect.TabIndex = 3;
            this.but_disconnect.Text = "Отключиться";
            this.but_disconnect.UseVisualStyleBackColor = true;
            this.but_disconnect.Click += new System.EventHandler(this.but_disconnect_Click);
            // 
            // but_enable_force
            // 
            this.but_enable_force.Location = new System.Drawing.Point(9, 134);
            this.but_enable_force.Margin = new System.Windows.Forms.Padding(2);
            this.but_enable_force.Name = "but_enable_force";
            this.but_enable_force.Size = new System.Drawing.Size(104, 30);
            this.but_enable_force.TabIndex = 4;
            this.but_enable_force.Text = "Включить силу";
            this.but_enable_force.UseVisualStyleBackColor = true;
            this.but_enable_force.Click += new System.EventHandler(this.but_enable_force_Click);
            // 
            // but_disable_force
            // 
            this.but_disable_force.Location = new System.Drawing.Point(9, 169);
            this.but_disable_force.Margin = new System.Windows.Forms.Padding(2);
            this.but_disable_force.Name = "but_disable_force";
            this.but_disable_force.Size = new System.Drawing.Size(104, 30);
            this.but_disable_force.TabIndex = 5;
            this.but_disable_force.Text = "Выключить силу";
            this.but_disable_force.UseVisualStyleBackColor = true;
            this.but_disable_force.Click += new System.EventHandler(this.but_disable_force_Click);
            // 
            // but_set_force
            // 
            this.but_set_force.Location = new System.Drawing.Point(9, 204);
            this.but_set_force.Margin = new System.Windows.Forms.Padding(2);
            this.but_set_force.Name = "but_set_force";
            this.but_set_force.Size = new System.Drawing.Size(104, 40);
            this.but_set_force.TabIndex = 6;
            this.but_set_force.Text = "Установить значение силы, г";
            this.but_set_force.UseVisualStyleBackColor = true;
            this.but_set_force.Click += new System.EventHandler(this.but_set_force_Click);
            // 
            // text_b_force_dest
            // 
            this.text_b_force_dest.Location = new System.Drawing.Point(137, 214);
            this.text_b_force_dest.Margin = new System.Windows.Forms.Padding(2);
            this.text_b_force_dest.Name = "text_b_force_dest";
            this.text_b_force_dest.Size = new System.Drawing.Size(76, 20);
            this.text_b_force_dest.TabIndex = 7;
            this.text_b_force_dest.Text = "0";
            // 
            // but_cycle_settings
            // 
            this.but_cycle_settings.Location = new System.Drawing.Point(9, 265);
            this.but_cycle_settings.Margin = new System.Windows.Forms.Padding(2);
            this.but_cycle_settings.Name = "but_cycle_settings";
            this.but_cycle_settings.Size = new System.Drawing.Size(104, 40);
            this.but_cycle_settings.TabIndex = 8;
            this.but_cycle_settings.Text = "Установить настройки цикла";
            this.but_cycle_settings.UseVisualStyleBackColor = true;
            this.but_cycle_settings.Click += new System.EventHandler(this.but_cycle_settings_Click);
            // 
            // text_b_time_force
            // 
            this.text_b_time_force.Location = new System.Drawing.Point(166, 310);
            this.text_b_time_force.Margin = new System.Windows.Forms.Padding(2);
            this.text_b_time_force.Name = "text_b_time_force";
            this.text_b_time_force.Size = new System.Drawing.Size(76, 20);
            this.text_b_time_force.TabIndex = 9;
            this.text_b_time_force.Text = "500";
            // 
            // text_b_time_relax
            // 
            this.text_b_time_relax.Location = new System.Drawing.Point(166, 332);
            this.text_b_time_relax.Margin = new System.Windows.Forms.Padding(2);
            this.text_b_time_relax.Name = "text_b_time_relax";
            this.text_b_time_relax.Size = new System.Drawing.Size(76, 20);
            this.text_b_time_relax.TabIndex = 10;
            this.text_b_time_relax.Text = "4000";
            // 
            // text_b_force_max
            // 
            this.text_b_force_max.Location = new System.Drawing.Point(166, 358);
            this.text_b_force_max.Margin = new System.Windows.Forms.Padding(2);
            this.text_b_force_max.Name = "text_b_force_max";
            this.text_b_force_max.Size = new System.Drawing.Size(76, 20);
            this.text_b_force_max.TabIndex = 11;
            this.text_b_force_max.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Время усилия, мс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Время релаксации, мс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Максимальная амплитуда, мс";
            // 
            // but_tens_up
            // 
            this.but_tens_up.Location = new System.Drawing.Point(137, 134);
            this.but_tens_up.Margin = new System.Windows.Forms.Padding(2);
            this.but_tens_up.Name = "but_tens_up";
            this.but_tens_up.Size = new System.Drawing.Size(104, 30);
            this.but_tens_up.TabIndex = 15;
            this.but_tens_up.Text = "Поднять";
            this.but_tens_up.UseVisualStyleBackColor = true;
            this.but_tens_up.Click += new System.EventHandler(this.but_tens_up_Click);
            // 
            // but_tens_down
            // 
            this.but_tens_down.Location = new System.Drawing.Point(137, 169);
            this.but_tens_down.Margin = new System.Windows.Forms.Padding(2);
            this.but_tens_down.Name = "but_tens_down";
            this.but_tens_down.Size = new System.Drawing.Size(104, 30);
            this.but_tens_down.TabIndex = 16;
            this.but_tens_down.Text = "Опустить";
            this.but_tens_down.UseVisualStyleBackColor = true;
            this.but_tens_down.Click += new System.EventHandler(this.but_tens_down_Click);
            // 
            // combo_cycle_type
            // 
            this.combo_cycle_type.FormattingEnabled = true;
            this.combo_cycle_type.Location = new System.Drawing.Point(139, 275);
            this.combo_cycle_type.Margin = new System.Windows.Forms.Padding(2);
            this.combo_cycle_type.Name = "combo_cycle_type";
            this.combo_cycle_type.Size = new System.Drawing.Size(103, 21);
            this.combo_cycle_type.TabIndex = 17;
            this.combo_cycle_type.SelectedIndexChanged += new System.EventHandler(this.combo_cycle_type_SelectedIndexChanged);
            // 
            // but_cycle_start
            // 
            this.but_cycle_start.Location = new System.Drawing.Point(12, 396);
            this.but_cycle_start.Margin = new System.Windows.Forms.Padding(2);
            this.but_cycle_start.Name = "but_cycle_start";
            this.but_cycle_start.Size = new System.Drawing.Size(104, 40);
            this.but_cycle_start.TabIndex = 18;
            this.but_cycle_start.Text = "Запустить цикл";
            this.but_cycle_start.UseVisualStyleBackColor = true;
            this.but_cycle_start.Click += new System.EventHandler(this.but_cycle_start_Click);
            // 
            // but_cycle_stop
            // 
            this.but_cycle_stop.Location = new System.Drawing.Point(137, 396);
            this.but_cycle_stop.Margin = new System.Windows.Forms.Padding(2);
            this.but_cycle_stop.Name = "but_cycle_stop";
            this.but_cycle_stop.Size = new System.Drawing.Size(104, 40);
            this.but_cycle_stop.TabIndex = 19;
            this.but_cycle_stop.Text = "Остановить цикл";
            this.but_cycle_stop.UseVisualStyleBackColor = true;
            this.but_cycle_stop.Click += new System.EventHandler(this.but_cycle_stop_Click);
            // 
            // but_disable_light
            // 
            this.but_disable_light.Location = new System.Drawing.Point(13, 530);
            this.but_disable_light.Margin = new System.Windows.Forms.Padding(2);
            this.but_disable_light.Name = "but_disable_light";
            this.but_disable_light.Size = new System.Drawing.Size(104, 30);
            this.but_disable_light.TabIndex = 21;
            this.but_disable_light.Text = "Выключить свет";
            this.but_disable_light.UseVisualStyleBackColor = true;
            this.but_disable_light.Click += new System.EventHandler(this.but_disable_light_Click);
            // 
            // but_enable_light
            // 
            this.but_enable_light.Location = new System.Drawing.Point(13, 495);
            this.but_enable_light.Margin = new System.Windows.Forms.Padding(2);
            this.but_enable_light.Name = "but_enable_light";
            this.but_enable_light.Size = new System.Drawing.Size(104, 30);
            this.but_enable_light.TabIndex = 20;
            this.but_enable_light.Text = "Включить свет";
            this.but_enable_light.UseVisualStyleBackColor = true;
            this.but_enable_light.Click += new System.EventHandler(this.but_enable_light_Click);
            // 
            // imB_graphics
            // 
            this.imB_graphics.Location = new System.Drawing.Point(298, 16);
            this.imB_graphics.Name = "imB_graphics";
            this.imB_graphics.Size = new System.Drawing.Size(704, 509);
            this.imB_graphics.TabIndex = 2;
            this.imB_graphics.TabStop = false;
            // 
            // but_test
            // 
            this.but_test.Location = new System.Drawing.Point(156, 495);
            this.but_test.Margin = new System.Windows.Forms.Padding(2);
            this.but_test.Name = "but_test";
            this.but_test.Size = new System.Drawing.Size(104, 30);
            this.but_test.TabIndex = 22;
            this.but_test.Text = "test";
            this.but_test.UseVisualStyleBackColor = true;
            this.but_test.Click += new System.EventHandler(this.but_test_Click);
            // 
            // timer_feedback
            // 
            this.timer_feedback.Interval = 20;
            this.timer_feedback.Tick += new System.EventHandler(this.timer_feedback_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 52);
            this.label4.TabIndex = 23;
            this.label4.Text = "Текущ Сила\r\nТреб Сила \r\nПоложение\r\nТемпература   ";
            // 
            // label_feedback
            // 
            this.label_feedback.AutoSize = true;
            this.label_feedback.Location = new System.Drawing.Point(134, 438);
            this.label_feedback.Name = "label_feedback";
            this.label_feedback.Size = new System.Drawing.Size(200, 13);
            this.label_feedback.TabIndex = 24;
            this.label_feedback.Text = "Текущ Сила, Треб Сила, Положение   ";
            // 
            // but_clear_data
            // 
            this.but_clear_data.Location = new System.Drawing.Point(499, 530);
            this.but_clear_data.Margin = new System.Windows.Forms.Padding(2);
            this.but_clear_data.Name = "but_clear_data";
            this.but_clear_data.Size = new System.Drawing.Size(104, 30);
            this.but_clear_data.TabIndex = 25;
            this.but_clear_data.Text = "Очистить график";
            this.but_clear_data.UseVisualStyleBackColor = true;
            this.but_clear_data.Click += new System.EventHandler(this.but_clear_data_Click);
            // 
            // but_save_data
            // 
            this.but_save_data.Location = new System.Drawing.Point(607, 530);
            this.but_save_data.Margin = new System.Windows.Forms.Padding(2);
            this.but_save_data.Name = "but_save_data";
            this.but_save_data.Size = new System.Drawing.Size(104, 45);
            this.but_save_data.TabIndex = 26;
            this.but_save_data.Text = "Сохранить график";
            this.but_save_data.UseVisualStyleBackColor = true;
            this.but_save_data.Click += new System.EventHandler(this.but_save_data_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(1008, 228);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(281, 262);
            this.imageBox1.TabIndex = 27;
            this.imageBox1.TabStop = false;
            // 
            // but_down_vel
            // 
            this.but_down_vel.Location = new System.Drawing.Point(1008, 16);
            this.but_down_vel.Margin = new System.Windows.Forms.Padding(2);
            this.but_down_vel.Name = "but_down_vel";
            this.but_down_vel.Size = new System.Drawing.Size(104, 42);
            this.but_down_vel.TabIndex = 28;
            this.but_down_vel.Text = "Опустить со скоростью, мм/с";
            this.but_down_vel.UseVisualStyleBackColor = true;
            this.but_down_vel.Click += new System.EventHandler(this.but_down_vel_Click);
            // 
            // tb_down_vel
            // 
            this.tb_down_vel.Location = new System.Drawing.Point(1116, 28);
            this.tb_down_vel.Margin = new System.Windows.Forms.Padding(2);
            this.tb_down_vel.Name = "tb_down_vel";
            this.tb_down_vel.Size = new System.Drawing.Size(76, 20);
            this.tb_down_vel.TabIndex = 29;
            this.tb_down_vel.Text = "0";
            // 
            // but_up_vel
            // 
            this.but_up_vel.Location = new System.Drawing.Point(1008, 62);
            this.but_up_vel.Margin = new System.Windows.Forms.Padding(2);
            this.but_up_vel.Name = "but_up_vel";
            this.but_up_vel.Size = new System.Drawing.Size(104, 42);
            this.but_up_vel.TabIndex = 30;
            this.but_up_vel.Text = "Поднять со скоростью, мм/с";
            this.but_up_vel.UseVisualStyleBackColor = true;
            this.but_up_vel.Click += new System.EventHandler(this.but_up_vel_Click);
            // 
            // tb_up_vel
            // 
            this.tb_up_vel.Location = new System.Drawing.Point(1116, 74);
            this.tb_up_vel.Margin = new System.Windows.Forms.Padding(2);
            this.tb_up_vel.Name = "tb_up_vel";
            this.tb_up_vel.Size = new System.Drawing.Size(76, 20);
            this.tb_up_vel.TabIndex = 31;
            this.tb_up_vel.Text = "0";
            // 
            // but_set_k_p
            // 
            this.but_set_k_p.Location = new System.Drawing.Point(1007, 169);
            this.but_set_k_p.Margin = new System.Windows.Forms.Padding(2);
            this.but_set_k_p.Name = "but_set_k_p";
            this.but_set_k_p.Size = new System.Drawing.Size(104, 24);
            this.but_set_k_p.TabIndex = 32;
            this.but_set_k_p.Text = "k_p, мм/с";
            this.but_set_k_p.UseVisualStyleBackColor = true;
            this.but_set_k_p.Click += new System.EventHandler(this.but_set_k_p_Click);
            // 
            // tb_k_p
            // 
            this.tb_k_p.Location = new System.Drawing.Point(1115, 172);
            this.tb_k_p.Margin = new System.Windows.Forms.Padding(2);
            this.tb_k_p.Name = "tb_k_p";
            this.tb_k_p.Size = new System.Drawing.Size(76, 20);
            this.tb_k_p.TabIndex = 33;
            this.tb_k_p.Text = "5";
            // 
            // tb_k_v
            // 
            this.tb_k_v.Location = new System.Drawing.Point(1115, 200);
            this.tb_k_v.Margin = new System.Windows.Forms.Padding(2);
            this.tb_k_v.Name = "tb_k_v";
            this.tb_k_v.Size = new System.Drawing.Size(76, 20);
            this.tb_k_v.TabIndex = 35;
            this.tb_k_v.Text = "0.2";
            // 
            // but_set_k_v
            // 
            this.but_set_k_v.Location = new System.Drawing.Point(1007, 197);
            this.but_set_k_v.Margin = new System.Windows.Forms.Padding(2);
            this.but_set_k_v.Name = "but_set_k_v";
            this.but_set_k_v.Size = new System.Drawing.Size(104, 24);
            this.but_set_k_v.TabIndex = 34;
            this.but_set_k_v.Text = "k_v, мм/с";
            this.but_set_k_v.UseVisualStyleBackColor = true;
            this.but_set_k_v.Click += new System.EventHandler(this.but_set_k_v_Click);
            // 
            // but_move_stop
            // 
            this.but_move_stop.Location = new System.Drawing.Point(1008, 108);
            this.but_move_stop.Margin = new System.Windows.Forms.Padding(2);
            this.but_move_stop.Name = "but_move_stop";
            this.but_move_stop.Size = new System.Drawing.Size(104, 42);
            this.but_move_stop.TabIndex = 36;
            this.but_move_stop.Text = "Остановить";
            this.but_move_stop.UseVisualStyleBackColor = true;
            this.but_move_stop.Click += new System.EventHandler(this.but_move_stop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 584);
            this.Controls.Add(this.but_move_stop);
            this.Controls.Add(this.tb_k_v);
            this.Controls.Add(this.but_set_k_v);
            this.Controls.Add(this.tb_k_p);
            this.Controls.Add(this.but_set_k_p);
            this.Controls.Add(this.tb_up_vel);
            this.Controls.Add(this.but_up_vel);
            this.Controls.Add(this.tb_down_vel);
            this.Controls.Add(this.but_down_vel);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.but_save_data);
            this.Controls.Add(this.but_clear_data);
            this.Controls.Add(this.label_feedback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.but_test);
            this.Controls.Add(this.imB_graphics);
            this.Controls.Add(this.but_disable_light);
            this.Controls.Add(this.but_enable_light);
            this.Controls.Add(this.but_cycle_stop);
            this.Controls.Add(this.but_cycle_start);
            this.Controls.Add(this.combo_cycle_type);
            this.Controls.Add(this.but_tens_down);
            this.Controls.Add(this.but_tens_up);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_b_force_max);
            this.Controls.Add(this.text_b_time_relax);
            this.Controls.Add(this.text_b_time_force);
            this.Controls.Add(this.but_cycle_settings);
            this.Controls.Add(this.text_b_force_dest);
            this.Controls.Add(this.but_set_force);
            this.Controls.Add(this.but_disable_force);
            this.Controls.Add(this.but_enable_force);
            this.Controls.Add(this.but_disconnect);
            this.Controls.Add(this.but_connect);
            this.Controls.Add(this.combo_ard_port);
            this.Controls.Add(this.but_find_ports);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imB_graphics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_find_ports;
        private System.Windows.Forms.ComboBox combo_ard_port;
        private System.Windows.Forms.Button but_connect;
        private System.Windows.Forms.Button but_disconnect;
        private System.Windows.Forms.Button but_enable_force;
        private System.Windows.Forms.Button but_disable_force;
        private System.Windows.Forms.Button but_set_force;
        private System.Windows.Forms.TextBox text_b_force_dest;
        private System.Windows.Forms.Button but_cycle_settings;
        private System.Windows.Forms.TextBox text_b_time_force;
        private System.Windows.Forms.TextBox text_b_time_relax;
        private System.Windows.Forms.TextBox text_b_force_max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_tens_up;
        private System.Windows.Forms.Button but_tens_down;
        private System.Windows.Forms.ComboBox combo_cycle_type;
        private System.Windows.Forms.Button but_cycle_start;
        private System.Windows.Forms.Button but_cycle_stop;
        private System.Windows.Forms.Button but_disable_light;
        private System.Windows.Forms.Button but_enable_light;
        private Emgu.CV.UI.ImageBox imB_graphics;
        private System.Windows.Forms.Button but_test;
        private System.Windows.Forms.Timer timer_feedback;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_feedback;
        private System.Windows.Forms.Button but_clear_data;
        private System.Windows.Forms.Button but_save_data;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button but_down_vel;
        private System.Windows.Forms.TextBox tb_down_vel;
        private System.Windows.Forms.Button but_up_vel;
        private System.Windows.Forms.TextBox tb_up_vel;
        private System.Windows.Forms.Button but_set_k_p;
        private System.Windows.Forms.TextBox tb_k_p;
        private System.Windows.Forms.TextBox tb_k_v;
        private System.Windows.Forms.Button but_set_k_v;
        private System.Windows.Forms.Button but_move_stop;
    }
}

