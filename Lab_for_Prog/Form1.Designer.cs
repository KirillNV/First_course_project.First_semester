
namespace Lab_for_Prog
{
    partial class FormMain
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarForBreathing = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarForObject = new System.Windows.Forms.TrackBar();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelColorOfTrajectory = new System.Windows.Forms.Label();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonTB3 = new System.Windows.Forms.RadioButton();
            this.radioButtonTB2 = new System.Windows.Forms.RadioButton();
            this.radioButtonTB1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButtonObj3 = new System.Windows.Forms.RadioButton();
            this.radioButtonObj2 = new System.Windows.Forms.RadioButton();
            this.radioButtonObj1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonBackSave = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxForObjectSize1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxForObjectSize4 = new System.Windows.Forms.TextBox();
            this.textBoxForObjectSize2 = new System.Windows.Forms.TextBox();
            this.textBoxForObjectSize3 = new System.Windows.Forms.TextBox();
            this.buttonFor1 = new System.Windows.Forms.Button();
            this.buttonFor4 = new System.Windows.Forms.Button();
            this.buttonFor3 = new System.Windows.Forms.Button();
            this.buttonFor2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForBreathing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForObject)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(23, 26);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(312, 480);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.Resize += new System.EventHandler(this.pictureBox_Resize);
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.trackBar.Location = new System.Drawing.Point(18, 56);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(117, 45);
            this.trackBar.TabIndex = 1;
            this.trackBar.Value = 10;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.trackBarForBreathing);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trackBar);
            this.panel1.Controls.Add(this.trackBarForObject);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Location = new System.Drawing.Point(470, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 175);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Скорость дыхания";
            // 
            // trackBarForBreathing
            // 
            this.trackBarForBreathing.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBarForBreathing.Location = new System.Drawing.Point(166, 107);
            this.trackBarForBreathing.Name = "trackBarForBreathing";
            this.trackBarForBreathing.Size = new System.Drawing.Size(90, 45);
            this.trackBarForBreathing.TabIndex = 7;
            this.trackBarForBreathing.Value = 1;
            this.trackBarForBreathing.ValueChanged += new System.EventHandler(this.trackBarForBreathing_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Скорость фигуры";
            // 
            // trackBarForObject
            // 
            this.trackBarForObject.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBarForObject.Location = new System.Drawing.Point(163, 25);
            this.trackBarForObject.Name = "trackBarForObject";
            this.trackBarForObject.Size = new System.Drawing.Size(90, 45);
            this.trackBarForObject.TabIndex = 5;
            this.trackBarForObject.Value = 5;
            this.trackBarForObject.ValueChanged += new System.EventHandler(this.trackBarForObject_ValueChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(3, 107);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(76, 23);
            this.start.TabIndex = 3;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(85, 107);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(76, 22);
            this.stop.TabIndex = 4;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(13, 43);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(70, 17);
            this.radioButtonRed.TabIndex = 3;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Красный";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.Click += new System.EventHandler(this.radioButtonRed_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.labelColorOfTrajectory);
            this.panel2.Controls.Add(this.radioButtonBlue);
            this.panel2.Controls.Add(this.radioButtonGreen);
            this.panel2.Controls.Add(this.radioButtonRed);
            this.panel2.Location = new System.Drawing.Point(467, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 127);
            this.panel2.TabIndex = 4;
            // 
            // labelColorOfTrajectory
            // 
            this.labelColorOfTrajectory.AutoSize = true;
            this.labelColorOfTrajectory.Location = new System.Drawing.Point(10, 27);
            this.labelColorOfTrajectory.Name = "labelColorOfTrajectory";
            this.labelColorOfTrajectory.Size = new System.Drawing.Size(96, 13);
            this.labelColorOfTrajectory.TabIndex = 6;
            this.labelColorOfTrajectory.Text = "Цвет траектории:";
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(13, 89);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(56, 17);
            this.radioButtonBlue.TabIndex = 5;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Синий";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.Click += new System.EventHandler(this.radioButtonBlue_Click);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(13, 66);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(70, 17);
            this.radioButtonGreen.TabIndex = 4;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Зеленый";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.Click += new System.EventHandler(this.radioButtonGreen_Click);
            // 
            // radioButtonTB3
            // 
            this.radioButtonTB3.AutoSize = true;
            this.radioButtonTB3.Location = new System.Drawing.Point(11, 89);
            this.radioButtonTB3.Name = "radioButtonTB3";
            this.radioButtonTB3.Size = new System.Drawing.Size(58, 17);
            this.radioButtonTB3.TabIndex = 9;
            this.radioButtonTB3.TabStop = true;
            this.radioButtonTB3.Text = "Серый";
            this.radioButtonTB3.UseVisualStyleBackColor = true;
            this.radioButtonTB3.Click += new System.EventHandler(this.radioButtonTB3_Click);
            // 
            // radioButtonTB2
            // 
            this.radioButtonTB2.AutoSize = true;
            this.radioButtonTB2.Location = new System.Drawing.Point(11, 66);
            this.radioButtonTB2.Name = "radioButtonTB2";
            this.radioButtonTB2.Size = new System.Drawing.Size(66, 17);
            this.radioButtonTB2.TabIndex = 8;
            this.radioButtonTB2.TabStop = true;
            this.radioButtonTB2.Text = "Голубой";
            this.radioButtonTB2.UseVisualStyleBackColor = true;
            this.radioButtonTB2.Click += new System.EventHandler(this.radioButtonTB2_Click);
            // 
            // radioButtonTB1
            // 
            this.radioButtonTB1.AutoSize = true;
            this.radioButtonTB1.Location = new System.Drawing.Point(11, 42);
            this.radioButtonTB1.Name = "radioButtonTB1";
            this.radioButtonTB1.Size = new System.Drawing.Size(60, 17);
            this.radioButtonTB1.TabIndex = 7;
            this.radioButtonTB1.TabStop = true;
            this.radioButtonTB1.Text = "Рыжий";
            this.radioButtonTB1.UseVisualStyleBackColor = true;
            this.radioButtonTB1.Click += new System.EventHandler(this.radioButtonTB1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Цвет заливки:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.radioButtonTB2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.radioButtonTB1);
            this.panel3.Controls.Add(this.radioButtonTB3);
            this.panel3.Location = new System.Drawing.Point(583, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 126);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.radioButtonObj3);
            this.panel4.Controls.Add(this.radioButtonObj2);
            this.panel4.Controls.Add(this.radioButtonObj1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(704, 219);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(109, 126);
            this.panel4.TabIndex = 12;
            // 
            // radioButtonObj3
            // 
            this.radioButtonObj3.AutoSize = true;
            this.radioButtonObj3.Location = new System.Drawing.Point(6, 89);
            this.radioButtonObj3.Name = "radioButtonObj3";
            this.radioButtonObj3.Size = new System.Drawing.Size(56, 17);
            this.radioButtonObj3.TabIndex = 3;
            this.radioButtonObj3.TabStop = true;
            this.radioButtonObj3.Text = "Синий";
            this.radioButtonObj3.UseVisualStyleBackColor = true;
            this.radioButtonObj3.Click += new System.EventHandler(this.radioButtonObj3_Click);
            // 
            // radioButtonObj2
            // 
            this.radioButtonObj2.AutoSize = true;
            this.radioButtonObj2.Location = new System.Drawing.Point(6, 65);
            this.radioButtonObj2.Name = "radioButtonObj2";
            this.radioButtonObj2.Size = new System.Drawing.Size(70, 17);
            this.radioButtonObj2.TabIndex = 2;
            this.radioButtonObj2.TabStop = true;
            this.radioButtonObj2.Text = "Зеленый";
            this.radioButtonObj2.UseVisualStyleBackColor = true;
            this.radioButtonObj2.Click += new System.EventHandler(this.radioButtonObj2_Click);
            // 
            // radioButtonObj1
            // 
            this.radioButtonObj1.AutoSize = true;
            this.radioButtonObj1.Location = new System.Drawing.Point(6, 42);
            this.radioButtonObj1.Name = "radioButtonObj1";
            this.radioButtonObj1.Size = new System.Drawing.Size(70, 17);
            this.radioButtonObj1.TabIndex = 1;
            this.radioButtonObj1.TabStop = true;
            this.radioButtonObj1.Text = "Красный";
            this.radioButtonObj1.UseVisualStyleBackColor = true;
            this.radioButtonObj1.Click += new System.EventHandler(this.radioButtonObj1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Цвет фигуры: ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonBackSave);
            this.panel5.Controls.Add(this.buttonSave);
            this.panel5.Controls.Add(this.textBoxForObjectSize1);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.textBoxForObjectSize4);
            this.panel5.Controls.Add(this.textBoxForObjectSize2);
            this.panel5.Controls.Add(this.textBoxForObjectSize3);
            this.panel5.Location = new System.Drawing.Point(467, 376);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 132);
            this.panel5.TabIndex = 13;
            // 
            // buttonBackSave
            // 
            this.buttonBackSave.Location = new System.Drawing.Point(116, 97);
            this.buttonBackSave.Name = "buttonBackSave";
            this.buttonBackSave.Size = new System.Drawing.Size(88, 29);
            this.buttonBackSave.TabIndex = 8;
            this.buttonBackSave.Text = "Восстановить";
            this.buttonBackSave.UseVisualStyleBackColor = true;
            this.buttonBackSave.Click += new System.EventHandler(this.buttonBackSave_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(116, 62);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 29);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxForObjectSize1
            // 
            this.textBoxForObjectSize1.Location = new System.Drawing.Point(23, 28);
            this.textBoxForObjectSize1.Name = "textBoxForObjectSize1";
            this.textBoxForObjectSize1.Size = new System.Drawing.Size(76, 20);
            this.textBoxForObjectSize1.TabIndex = 6;
            this.textBoxForObjectSize1.TextChanged += new System.EventHandler(this.textBoxForObjectSize1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Параметры размера объекта";
            // 
            // textBoxForObjectSize4
            // 
            this.textBoxForObjectSize4.Location = new System.Drawing.Point(23, 106);
            this.textBoxForObjectSize4.Name = "textBoxForObjectSize4";
            this.textBoxForObjectSize4.Size = new System.Drawing.Size(76, 20);
            this.textBoxForObjectSize4.TabIndex = 3;
            this.textBoxForObjectSize4.TextChanged += new System.EventHandler(this.textBoxForObjectSize4_TextChanged);
            // 
            // textBoxForObjectSize2
            // 
            this.textBoxForObjectSize2.Location = new System.Drawing.Point(23, 54);
            this.textBoxForObjectSize2.Name = "textBoxForObjectSize2";
            this.textBoxForObjectSize2.Size = new System.Drawing.Size(76, 20);
            this.textBoxForObjectSize2.TabIndex = 2;
            this.textBoxForObjectSize2.TextChanged += new System.EventHandler(this.textBoxForObjectSize2_TextChanged);
            // 
            // textBoxForObjectSize3
            // 
            this.textBoxForObjectSize3.Location = new System.Drawing.Point(23, 80);
            this.textBoxForObjectSize3.Name = "textBoxForObjectSize3";
            this.textBoxForObjectSize3.Size = new System.Drawing.Size(76, 20);
            this.textBoxForObjectSize3.TabIndex = 1;
            this.textBoxForObjectSize3.TextChanged += new System.EventHandler(this.textBoxForObjectSize3_TextChanged);
            // 
            // buttonFor1
            // 
            this.buttonFor1.Location = new System.Drawing.Point(714, 388);
            this.buttonFor1.Name = "buttonFor1";
            this.buttonFor1.Size = new System.Drawing.Size(99, 28);
            this.buttonFor1.TabIndex = 14;
            this.buttonFor1.Text = "Для 1-ой";
            this.buttonFor1.UseVisualStyleBackColor = true;
            this.buttonFor1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFor4
            // 
            this.buttonFor4.Location = new System.Drawing.Point(714, 490);
            this.buttonFor4.Name = "buttonFor4";
            this.buttonFor4.Size = new System.Drawing.Size(99, 28);
            this.buttonFor4.TabIndex = 15;
            this.buttonFor4.Text = "Для 4-ой";
            this.buttonFor4.UseVisualStyleBackColor = true;
            this.buttonFor4.Click += new System.EventHandler(this.buttonFor4_Click);
            // 
            // buttonFor3
            // 
            this.buttonFor3.Location = new System.Drawing.Point(714, 456);
            this.buttonFor3.Name = "buttonFor3";
            this.buttonFor3.Size = new System.Drawing.Size(99, 28);
            this.buttonFor3.TabIndex = 16;
            this.buttonFor3.Text = "Для 3-ей";
            this.buttonFor3.UseVisualStyleBackColor = true;
            this.buttonFor3.Click += new System.EventHandler(this.buttonFor3_Click);
            // 
            // buttonFor2
            // 
            this.buttonFor2.Location = new System.Drawing.Point(714, 422);
            this.buttonFor2.Name = "buttonFor2";
            this.buttonFor2.Size = new System.Drawing.Size(99, 28);
            this.buttonFor2.TabIndex = 17;
            this.buttonFor2.Text = "Для 2-ой";
            this.buttonFor2.UseVisualStyleBackColor = true;
            this.buttonFor2.Click += new System.EventHandler(this.buttonFor2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(711, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "Запись из буфера\r\n         обмена";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Кнопка цвета";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonFor2);
            this.Controls.Add(this.buttonFor3);
            this.Controls.Add(this.buttonFor4);
            this.Controls.Add(this.buttonFor1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForBreathing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForObject)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TrackBar trackBarForObject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarForBreathing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.Label labelColorOfTrajectory;
        private System.Windows.Forms.RadioButton radioButtonTB3;
        private System.Windows.Forms.RadioButton radioButtonTB2;
        private System.Windows.Forms.RadioButton radioButtonTB1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButtonObj3;
        private System.Windows.Forms.RadioButton radioButtonObj2;
        private System.Windows.Forms.RadioButton radioButtonObj1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxForObjectSize4;
        private System.Windows.Forms.TextBox textBoxForObjectSize2;
        private System.Windows.Forms.TextBox textBoxForObjectSize3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxForObjectSize1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBackSave;
        private System.Windows.Forms.Button buttonFor1;
        private System.Windows.Forms.Button buttonFor4;
        private System.Windows.Forms.Button buttonFor3;
        private System.Windows.Forms.Button buttonFor2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

