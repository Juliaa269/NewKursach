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
            this.cpuQueueListBox = new System.Windows.Forms.ListBox();
            this.videoCardQueueListBox = new System.Windows.Forms.ListBox();
            this.hardDriveDiskQueueListBox = new System.Windows.Forms.ListBox();
            this.soundCardListBox = new System.Windows.Forms.ListBox();
            this.STARTBTN = new System.Windows.Forms.Button();
            this.STOPBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CLEARBTN = new System.Windows.Forms.Button();
            this.EXITBTN = new System.Windows.Forms.Button();
            this.current_tick = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InensivityBTN = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
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
            // cpuQueueListBox
            // 
            this.cpuQueueListBox.FormattingEnabled = true;
            this.cpuQueueListBox.ItemHeight = 19;
            this.cpuQueueListBox.Location = new System.Drawing.Point(12, 175);
            this.cpuQueueListBox.Name = "cpuQueueListBox";
            this.cpuQueueListBox.Size = new System.Drawing.Size(240, 99);
            this.cpuQueueListBox.TabIndex = 11;
            // 
            // videoCardQueueListBox
            // 
            this.videoCardQueueListBox.FormattingEnabled = true;
            this.videoCardQueueListBox.ItemHeight = 19;
            this.videoCardQueueListBox.Location = new System.Drawing.Point(12, 319);
            this.videoCardQueueListBox.Name = "videoCardQueueListBox";
            this.videoCardQueueListBox.Size = new System.Drawing.Size(240, 99);
            this.videoCardQueueListBox.TabIndex = 12;
            // 
            // hardDriveDiskQueueListBox
            // 
            this.hardDriveDiskQueueListBox.FormattingEnabled = true;
            this.hardDriveDiskQueueListBox.ItemHeight = 19;
            this.hardDriveDiskQueueListBox.Location = new System.Drawing.Point(12, 465);
            this.hardDriveDiskQueueListBox.Name = "hardDriveDiskQueueListBox";
            this.hardDriveDiskQueueListBox.Size = new System.Drawing.Size(240, 99);
            this.hardDriveDiskQueueListBox.TabIndex = 13;
            // 
            // soundCardListBox
            // 
            this.soundCardListBox.FormattingEnabled = true;
            this.soundCardListBox.ItemHeight = 19;
            this.soundCardListBox.Location = new System.Drawing.Point(12, 607);
            this.soundCardListBox.Name = "soundCardListBox";
            this.soundCardListBox.Size = new System.Drawing.Size(240, 99);
            this.soundCardListBox.TabIndex = 14;
            // 
            // STARTBTN
            // 
            this.STARTBTN.Location = new System.Drawing.Point(816, 662);
            this.STARTBTN.Name = "STARTBTN";
            this.STARTBTN.Size = new System.Drawing.Size(115, 57);
            this.STARTBTN.TabIndex = 21;
            this.STARTBTN.Text = "СТАРТ";
            this.STARTBTN.UseVisualStyleBackColor = true;
            this.STARTBTN.Click += new System.EventHandler(this.STARTBTN_Click);
            // 
            // STOPBTN
            // 
            this.STOPBTN.Location = new System.Drawing.Point(937, 662);
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
            // CLEARBTN
            // 
            this.CLEARBTN.Location = new System.Drawing.Point(701, 662);
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
            this.current_tick.Location = new System.Drawing.Point(616, 86);
            this.current_tick.Name = "current_tick";
            this.current_tick.Size = new System.Drawing.Size(108, 19);
            this.current_tick.TabIndex = 36;
            this.current_tick.Text = "Текущий тик";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(783, 86);
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
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(783, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(475, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Алгоритм планирования процессов - SJF без вытеснений";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(423, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "Способ организации очереди - Бинарная пирамида";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(335, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 99);
            this.listBox1.TabIndex = 42;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Location = new System.Drawing.Point(335, 321);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(179, 99);
            this.listBox2.TabIndex = 43;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 19;
            this.listBox3.Location = new System.Drawing.Point(335, 465);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(179, 99);
            this.listBox3.TabIndex = 44;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 19;
            this.listBox4.Location = new System.Drawing.Point(335, 607);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(179, 99);
            this.listBox4.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "ЦП";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 19);
            this.label10.TabIndex = 47;
            this.label10.Text = "Видео Карта";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 19);
            this.label11.TabIndex = 48;
            this.label11.Text = "Жесткий Диск";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 580);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 19);
            this.label12.TabIndex = 49;
            this.label12.Text = "Звуковая Карта";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 19;
            this.listBox5.Location = new System.Drawing.Point(629, 175);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(272, 308);
            this.listBox5.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(710, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 19);
            this.label13.TabIndex = 51;
            this.label13.Text = "Статистика";
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 19;
            this.listBox6.Location = new System.Drawing.Point(629, 537);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(204, 99);
            this.listBox6.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(682, 515);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 19);
            this.label14.TabIndex = 53;
            this.label14.Text = "Память";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 731);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InensivityBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.current_tick);
            this.Controls.Add(this.EXITBTN);
            this.Controls.Add(this.CLEARBTN);
            this.Controls.Add(this.STOPBTN);
            this.Controls.Add(this.STARTBTN);
            this.Controls.Add(this.soundCardListBox);
            this.Controls.Add(this.hardDriveDiskQueueListBox);
            this.Controls.Add(this.videoCardQueueListBox);
            this.Controls.Add(this.cpuQueueListBox);
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
        private System.Windows.Forms.ListBox cpuQueueListBox;
        private System.Windows.Forms.ListBox videoCardQueueListBox;
        private System.Windows.Forms.ListBox hardDriveDiskQueueListBox;
        private System.Windows.Forms.ListBox soundCardListBox;
        private System.Windows.Forms.Button STARTBTN;
        private System.Windows.Forms.Button STOPBTN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CLEARBTN;
        private System.Windows.Forms.Button EXITBTN;
        private System.Windows.Forms.Label current_tick;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label InensivityBTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label14;
    }
}

