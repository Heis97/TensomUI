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
            this.SuspendLayout();
            // 
            // but_find_ports
            // 
            this.but_find_ports.Location = new System.Drawing.Point(12, 12);
            this.but_find_ports.Name = "but_find_ports";
            this.but_find_ports.Size = new System.Drawing.Size(138, 37);
            this.but_find_ports.TabIndex = 0;
            this.but_find_ports.Text = "Найти порты";
            this.but_find_ports.UseVisualStyleBackColor = true;
            this.but_find_ports.Click += new System.EventHandler(this.but_find_ports_Click);
            // 
            // combo_ard_port
            // 
            this.combo_ard_port.FormattingEnabled = true;
            this.combo_ard_port.Location = new System.Drawing.Point(185, 19);
            this.combo_ard_port.Name = "combo_ard_port";
            this.combo_ard_port.Size = new System.Drawing.Size(136, 24);
            this.combo_ard_port.TabIndex = 1;
            this.combo_ard_port.SelectedIndexChanged += new System.EventHandler(this.combo_ard_port_SelectedIndexChanged);
            // 
            // but_connect
            // 
            this.but_connect.Location = new System.Drawing.Point(183, 55);
            this.but_connect.Name = "but_connect";
            this.but_connect.Size = new System.Drawing.Size(138, 37);
            this.but_connect.TabIndex = 2;
            this.but_connect.Text = "Подключиться";
            this.but_connect.UseVisualStyleBackColor = true;
            this.but_connect.Click += new System.EventHandler(this.but_connect_Click);
            // 
            // but_disconnect
            // 
            this.but_disconnect.Location = new System.Drawing.Point(183, 98);
            this.but_disconnect.Name = "but_disconnect";
            this.but_disconnect.Size = new System.Drawing.Size(138, 37);
            this.but_disconnect.TabIndex = 3;
            this.but_disconnect.Text = "Отключиться";
            this.but_disconnect.UseVisualStyleBackColor = true;
            this.but_disconnect.Click += new System.EventHandler(this.but_disconnect_Click);
            // 
            // but_enable_force
            // 
            this.but_enable_force.Location = new System.Drawing.Point(12, 165);
            this.but_enable_force.Name = "but_enable_force";
            this.but_enable_force.Size = new System.Drawing.Size(138, 37);
            this.but_enable_force.TabIndex = 4;
            this.but_enable_force.Text = "Включить силу";
            this.but_enable_force.UseVisualStyleBackColor = true;
            this.but_enable_force.Click += new System.EventHandler(this.but_enable_force_Click);
            // 
            // but_disable_force
            // 
            this.but_disable_force.Location = new System.Drawing.Point(12, 208);
            this.but_disable_force.Name = "but_disable_force";
            this.but_disable_force.Size = new System.Drawing.Size(138, 37);
            this.but_disable_force.TabIndex = 5;
            this.but_disable_force.Text = "Выключить силу";
            this.but_disable_force.UseVisualStyleBackColor = true;
            this.but_disable_force.Click += new System.EventHandler(this.but_disable_force_Click);
            // 
            // but_set_force
            // 
            this.but_set_force.Location = new System.Drawing.Point(12, 251);
            this.but_set_force.Name = "but_set_force";
            this.but_set_force.Size = new System.Drawing.Size(138, 49);
            this.but_set_force.TabIndex = 6;
            this.but_set_force.Text = "Установить значение силы";
            this.but_set_force.UseVisualStyleBackColor = true;
            this.but_set_force.Click += new System.EventHandler(this.but_set_force_Click);
            // 
            // text_b_force_dest
            // 
            this.text_b_force_dest.Location = new System.Drawing.Point(183, 264);
            this.text_b_force_dest.Name = "text_b_force_dest";
            this.text_b_force_dest.Size = new System.Drawing.Size(100, 22);
            this.text_b_force_dest.TabIndex = 7;
            this.text_b_force_dest.Text = "0";
            // 
            // but_cycle_settings
            // 
            this.but_cycle_settings.Location = new System.Drawing.Point(12, 326);
            this.but_cycle_settings.Name = "but_cycle_settings";
            this.but_cycle_settings.Size = new System.Drawing.Size(138, 49);
            this.but_cycle_settings.TabIndex = 8;
            this.but_cycle_settings.Text = "Установить настройки цикла";
            this.but_cycle_settings.UseVisualStyleBackColor = true;
            this.but_cycle_settings.Click += new System.EventHandler(this.but_cycle_settings_Click);
            // 
            // text_b_time_force
            // 
            this.text_b_time_force.Location = new System.Drawing.Point(221, 381);
            this.text_b_time_force.Name = "text_b_time_force";
            this.text_b_time_force.Size = new System.Drawing.Size(100, 22);
            this.text_b_time_force.TabIndex = 9;
            this.text_b_time_force.Text = "20000";
            // 
            // text_b_time_relax
            // 
            this.text_b_time_relax.Location = new System.Drawing.Point(221, 409);
            this.text_b_time_relax.Name = "text_b_time_relax";
            this.text_b_time_relax.Size = new System.Drawing.Size(100, 22);
            this.text_b_time_relax.TabIndex = 10;
            this.text_b_time_relax.Text = "4000";
            // 
            // text_b_force_max
            // 
            this.text_b_force_max.Location = new System.Drawing.Point(221, 440);
            this.text_b_force_max.Name = "text_b_force_max";
            this.text_b_force_max.Size = new System.Drawing.Size(100, 22);
            this.text_b_force_max.TabIndex = 11;
            this.text_b_force_max.Text = "6000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Время усилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Время релаксации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Максимальная амплитуда";
            // 
            // but_tens_up
            // 
            this.but_tens_up.Location = new System.Drawing.Point(183, 165);
            this.but_tens_up.Name = "but_tens_up";
            this.but_tens_up.Size = new System.Drawing.Size(138, 37);
            this.but_tens_up.TabIndex = 15;
            this.but_tens_up.Text = "Поднять";
            this.but_tens_up.UseVisualStyleBackColor = true;
            this.but_tens_up.Click += new System.EventHandler(this.but_tens_up_Click);
            // 
            // but_tens_down
            // 
            this.but_tens_down.Location = new System.Drawing.Point(183, 208);
            this.but_tens_down.Name = "but_tens_down";
            this.but_tens_down.Size = new System.Drawing.Size(138, 37);
            this.but_tens_down.TabIndex = 16;
            this.but_tens_down.Text = "Опустить";
            this.but_tens_down.UseVisualStyleBackColor = true;
            this.but_tens_down.Click += new System.EventHandler(this.but_tens_down_Click);
            // 
            // combo_cycle_type
            // 
            this.combo_cycle_type.FormattingEnabled = true;
            this.combo_cycle_type.Location = new System.Drawing.Point(185, 339);
            this.combo_cycle_type.Name = "combo_cycle_type";
            this.combo_cycle_type.Size = new System.Drawing.Size(136, 24);
            this.combo_cycle_type.TabIndex = 17;
            this.combo_cycle_type.SelectedIndexChanged += new System.EventHandler(this.combo_cycle_type_SelectedIndexChanged);
            // 
            // but_cycle_start
            // 
            this.but_cycle_start.Location = new System.Drawing.Point(16, 488);
            this.but_cycle_start.Name = "but_cycle_start";
            this.but_cycle_start.Size = new System.Drawing.Size(138, 49);
            this.but_cycle_start.TabIndex = 18;
            this.but_cycle_start.Text = "Запустить цикл";
            this.but_cycle_start.UseVisualStyleBackColor = true;
            this.but_cycle_start.Click += new System.EventHandler(this.but_cycle_start_Click);
            // 
            // but_cycle_stop
            // 
            this.but_cycle_stop.Location = new System.Drawing.Point(183, 488);
            this.but_cycle_stop.Name = "but_cycle_stop";
            this.but_cycle_stop.Size = new System.Drawing.Size(138, 49);
            this.but_cycle_stop.TabIndex = 19;
            this.but_cycle_stop.Text = "Остановить цикл";
            this.but_cycle_stop.UseVisualStyleBackColor = true;
            this.but_cycle_stop.Click += new System.EventHandler(this.but_cycle_stop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 719);
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
            this.Name = "MainForm";
            this.Text = "Form1";
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
    }
}

