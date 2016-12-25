namespace NewKursach
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.STARTBTN = new System.Windows.Forms.Button();
            this.STOPBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CLEARBTN = new System.Windows.Forms.Button();
            this.EXITBTN = new System.Windows.Forms.Button();
            this.current_tick = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InensivityBTN = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Очередь к Центральному Процессору";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Очередь к Видео Карте";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 436);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Очередь к Жесткому Диску";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 580);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Очередь к Звуковой Карте";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(12, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 99);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Location = new System.Drawing.Point(12, 319);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(240, 99);
            this.listBox2.TabIndex = 12;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 19;
            this.listBox3.Location = new System.Drawing.Point(12, 465);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(240, 99);
            this.listBox3.TabIndex = 13;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 19;
            this.listBox4.Location = new System.Drawing.Point(12, 607);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(240, 99);
            this.listBox4.TabIndex = 14;
            // 
            // STARTBTN
            // 
            this.STARTBTN.Location = new System.Drawing.Point(737, 662);
            this.STARTBTN.Name = "STARTBTN";
            this.STARTBTN.Size = new System.Drawing.Size(115, 57);
            this.STARTBTN.TabIndex = 21;
            this.STARTBTN.Text = "СТАРТ";
            this.STARTBTN.UseVisualStyleBackColor = true;
            this.STARTBTN.Click += new System.EventHandler(this.STARTBTN_Click);
            // 
            // STOPBTN
            // 
            this.STOPBTN.Location = new System.Drawing.Point(858, 662);
            this.STOPBTN.Name = "STOPBTN";
            this.STOPBTN.Size = new System.Drawing.Size(98, 57);
            this.STOPBTN.TabIndex = 22;
            this.STOPBTN.Text = "СТОП";
            this.STOPBTN.UseVisualStyleBackColor = true;
            this.STOPBTN.Click += new System.EventHandler(this.STOPBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(351, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Видео Карта";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(351, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Центральный процессор";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(351, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Жесткий диск";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(351, 499);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Звуковая Карта";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(654, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(286, 297);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Статистика";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(654, 408);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Память";
            // 
            // CLEARBTN
            // 
            this.CLEARBTN.Location = new System.Drawing.Point(620, 662);
            this.CLEARBTN.Name = "CLEARBTN";
            this.CLEARBTN.Size = new System.Drawing.Size(109, 57);
            this.CLEARBTN.TabIndex = 34;
            this.CLEARBTN.Text = "ОЧИСТИТЬ";
            this.CLEARBTN.UseVisualStyleBackColor = true;
            this.CLEARBTN.Click += new System.EventHandler(this.onClearPressed);
            // 
            // EXITBTN
            // 
            this.EXITBTN.Location = new System.Drawing.Point(880, 2);
            this.EXITBTN.Name = "EXITBTN";
            this.EXITBTN.Size = new System.Drawing.Size(118, 55);
            this.EXITBTN.TabIndex = 35;
            this.EXITBTN.Text = "ВЫХОД";
            this.EXITBTN.UseVisualStyleBackColor = true;
            this.EXITBTN.Click += new System.EventHandler(this.EXITBTN_Click);
            // 
            // current_tick
            // 
            this.current_tick.AutoSize = true;
            this.current_tick.Location = new System.Drawing.Point(351, 13);
            this.current_tick.Name = "current_tick";
            this.current_tick.Size = new System.Drawing.Size(108, 19);
            this.current_tick.TabIndex = 36;
            this.current_tick.Text = "Текущий тик";
            this.current_tick.Click += new System.EventHandler(this.current_tick_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 37;
            // 
            // InensivityBTN
            // 
            this.InensivityBTN.AutoSize = true;
            this.InensivityBTN.Location = new System.Drawing.Point(616, 20);
            this.InensivityBTN.Name = "InensivityBTN";
            this.InensivityBTN.Size = new System.Drawing.Size(134, 19);
            this.InensivityBTN.TabIndex = 38;
            this.InensivityBTN.Text = "Интенсивность";
            this.InensivityBTN.Click += new System.EventHandler(this.InensivityBTN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(783, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 731);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InensivityBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.current_tick);
            this.Controls.Add(this.EXITBTN);
            this.Controls.Add(this.CLEARBTN);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.STOPBTN);
            this.Controls.Add(this.STARTBTN);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button STARTBTN;
        private System.Windows.Forms.Button STOPBTN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button CLEARBTN;
        private System.Windows.Forms.Button EXITBTN;
        private System.Windows.Forms.Label current_tick;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label InensivityBTN;
        private System.Windows.Forms.Label label8;
    }
}

