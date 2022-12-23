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
            this.imB_graphics = new Emgu.CV.UI.ImageBox();
            this.timer_feedback = new System.Windows.Forms.Timer(this.components);
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.tb_pos_x = new System.Windows.Forms.TextBox();
            this.tb_pos_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_move_pos = new System.Windows.Forms.Button();
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
            // imB_graphics
            // 
            this.imB_graphics.Location = new System.Drawing.Point(298, 16);
            this.imB_graphics.Name = "imB_graphics";
            this.imB_graphics.Size = new System.Drawing.Size(704, 509);
            this.imB_graphics.TabIndex = 2;
            this.imB_graphics.TabStop = false;
            // 
            // timer_feedback
            // 
            this.timer_feedback.Interval = 20;
            this.timer_feedback.Tick += new System.EventHandler(this.timer_feedback_Tick);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(1008, 228);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(281, 262);
            this.imageBox1.TabIndex = 27;
            this.imageBox1.TabStop = false;
            // 
            // tb_pos_x
            // 
            this.tb_pos_x.Location = new System.Drawing.Point(28, 121);
            this.tb_pos_x.Name = "tb_pos_x";
            this.tb_pos_x.Size = new System.Drawing.Size(100, 20);
            this.tb_pos_x.TabIndex = 28;
            // 
            // tb_pos_y
            // 
            this.tb_pos_y.Location = new System.Drawing.Point(28, 147);
            this.tb_pos_y.Name = "tb_pos_y";
            this.tb_pos_y.Size = new System.Drawing.Size(100, 20);
            this.tb_pos_y.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Y";
            // 
            // but_move_pos
            // 
            this.but_move_pos.Location = new System.Drawing.Point(154, 141);
            this.but_move_pos.Margin = new System.Windows.Forms.Padding(2);
            this.but_move_pos.Name = "but_move_pos";
            this.but_move_pos.Size = new System.Drawing.Size(104, 30);
            this.but_move_pos.TabIndex = 32;
            this.but_move_pos.Text = "Переместиться";
            this.but_move_pos.UseVisualStyleBackColor = true;
            this.but_move_pos.Click += new System.EventHandler(this.but_move_pos_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 584);
            this.Controls.Add(this.but_move_pos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pos_y);
            this.Controls.Add(this.tb_pos_x);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.imB_graphics);
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
        private Emgu.CV.UI.ImageBox imB_graphics;
        private System.Windows.Forms.Timer timer_feedback;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.TextBox tb_pos_x;
        private System.Windows.Forms.TextBox tb_pos_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_move_pos;
    }
}

