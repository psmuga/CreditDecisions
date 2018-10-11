namespace DecyzjaKredytowa
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlAnswersQuestion0 = new System.Windows.Forms.Panel();
            this.boxIfTooYoung = new System.Windows.Forms.CheckBox();
            this.boxIfOldEnough = new System.Windows.Forms.CheckBox();
            this.pnlAnswersQuestion1 = new System.Windows.Forms.Panel();
            this.boxSalaryBelow = new System.Windows.Forms.CheckBox();
            this.boxSalaryAbove = new System.Windows.Forms.CheckBox();
            this.boxHaveHistoriaNo = new System.Windows.Forms.CheckBox();
            this.boxHaveHistoriaYes = new System.Windows.Forms.CheckBox();
            this.pnlAnswersQuestion2 = new System.Windows.Forms.Panel();
            this.boxIfHasEtatNo = new System.Windows.Forms.CheckBox();
            this.boxIfHasEtatYes = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlAnswersQuestion3 = new System.Windows.Forms.Panel();
            this.boxIfHasUmowaNo = new System.Windows.Forms.CheckBox();
            this.boxIfHasUmowaYes = new System.Windows.Forms.CheckBox();
            this.pnlAnswersQuestion4 = new System.Windows.Forms.Panel();
            this.boxIfHasOkresNo = new System.Windows.Forms.CheckBox();
            this.boxIfHasOkresYes = new System.Windows.Forms.CheckBox();
            this.pnlAnswersQuestion5 = new System.Windows.Forms.Panel();
            this.boxIfHasDzialalnoscNo = new System.Windows.Forms.CheckBox();
            this.boxIfHasDzialalnoscYes = new System.Windows.Forms.CheckBox();
            this.pnlAnswersQuestion6 = new System.Windows.Forms.Panel();
            this.boxIfDzialalnoscPolskaNo = new System.Windows.Forms.CheckBox();
            this.boxIfDzialalnoscPolskaYes = new System.Windows.Forms.CheckBox();
            this.pnlAnswersQuestion7 = new System.Windows.Forms.Panel();
            this.boxIfOkresDluzszyNo = new System.Windows.Forms.CheckBox();
            this.boxIfOkresDluzszyYes = new System.Windows.Forms.CheckBox();
            this.pnlAnswersQuestion8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlAnswersQuestion9 = new System.Windows.Forms.Panel();
            this.boxHistoriaPozytywnaNo = new System.Windows.Forms.CheckBox();
            this.boxHistoriaPozytywnaYes = new System.Windows.Forms.CheckBox();
            this.pnlAnswersQuestion0.SuspendLayout();
            this.pnlAnswersQuestion1.SuspendLayout();
            this.pnlAnswersQuestion2.SuspendLayout();
            this.pnlAnswersQuestion3.SuspendLayout();
            this.pnlAnswersQuestion4.SuspendLayout();
            this.pnlAnswersQuestion5.SuspendLayout();
            this.pnlAnswersQuestion6.SuspendLayout();
            this.pnlAnswersQuestion7.SuspendLayout();
            this.pnlAnswersQuestion8.SuspendLayout();
            this.pnlAnswersQuestion9.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dalej";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(838, 20);
            this.textBox1.TabIndex = 1;
            // 
            // pnlAnswersQuestion0
            // 
            this.pnlAnswersQuestion0.Controls.Add(this.boxIfTooYoung);
            this.pnlAnswersQuestion0.Controls.Add(this.boxIfOldEnough);
            this.pnlAnswersQuestion0.Location = new System.Drawing.Point(58, 242);
            this.pnlAnswersQuestion0.Name = "pnlAnswersQuestion0";
            this.pnlAnswersQuestion0.Size = new System.Drawing.Size(744, 49);
            this.pnlAnswersQuestion0.TabIndex = 2;
            // 
            // boxIfTooYoung
            // 
            this.boxIfTooYoung.AutoSize = true;
            this.boxIfTooYoung.Location = new System.Drawing.Point(485, 17);
            this.boxIfTooYoung.Name = "boxIfTooYoung";
            this.boxIfTooYoung.Size = new System.Drawing.Size(42, 17);
            this.boxIfTooYoung.TabIndex = 1;
            this.boxIfTooYoung.Text = "Nie";
            this.boxIfTooYoung.UseVisualStyleBackColor = true;
            this.boxIfTooYoung.CheckedChanged += new System.EventHandler(this.boxIfTakenNo_CheckedChanged);
            // 
            // boxIfOldEnough
            // 
            this.boxIfOldEnough.AutoSize = true;
            this.boxIfOldEnough.Location = new System.Drawing.Point(186, 17);
            this.boxIfOldEnough.Name = "boxIfOldEnough";
            this.boxIfOldEnough.Size = new System.Drawing.Size(45, 17);
            this.boxIfOldEnough.TabIndex = 0;
            this.boxIfOldEnough.Text = "Tak";
            this.boxIfOldEnough.UseVisualStyleBackColor = true;
            this.boxIfOldEnough.CheckedChanged += new System.EventHandler(this.boxIfTakenYes_CheckedChanged);
            // 
            // pnlAnswersQuestion1
            // 
            this.pnlAnswersQuestion1.Controls.Add(this.boxSalaryBelow);
            this.pnlAnswersQuestion1.Controls.Add(this.boxSalaryAbove);
            this.pnlAnswersQuestion1.Location = new System.Drawing.Point(58, 242);
            this.pnlAnswersQuestion1.Name = "pnlAnswersQuestion1";
            this.pnlAnswersQuestion1.Size = new System.Drawing.Size(744, 49);
            this.pnlAnswersQuestion1.TabIndex = 3;
            // 
            // boxSalaryBelow
            // 
            this.boxSalaryBelow.AutoSize = true;
            this.boxSalaryBelow.Location = new System.Drawing.Point(485, 17);
            this.boxSalaryBelow.Name = "boxSalaryBelow";
            this.boxSalaryBelow.Size = new System.Drawing.Size(42, 17);
            this.boxSalaryBelow.TabIndex = 1;
            this.boxSalaryBelow.Text = "Nie";
            this.boxSalaryBelow.UseVisualStyleBackColor = true;
            this.boxSalaryBelow.CheckedChanged += new System.EventHandler(this.boxTravelByPublic_CheckedChanged);
            // 
            // boxSalaryAbove
            // 
            this.boxSalaryAbove.AutoSize = true;
            this.boxSalaryAbove.Location = new System.Drawing.Point(186, 17);
            this.boxSalaryAbove.Name = "boxSalaryAbove";
            this.boxSalaryAbove.Size = new System.Drawing.Size(45, 17);
            this.boxSalaryAbove.TabIndex = 0;
            this.boxSalaryAbove.Text = "Tak";
            this.boxSalaryAbove.UseVisualStyleBackColor = true;
            this.boxSalaryAbove.CheckedChanged += new System.EventHandler(this.boxTravelByAuto_CheckedChanged);
            // 
            // boxHaveHistoriaNo
            // 
            this.boxHaveHistoriaNo.AutoSize = true;
            this.boxHaveHistoriaNo.Location = new System.Drawing.Point(562, 17);
            this.boxHaveHistoriaNo.Name = "boxHaveHistoriaNo";
            this.boxHaveHistoriaNo.Size = new System.Drawing.Size(99, 17);
            this.boxHaveHistoriaNo.TabIndex = 2;
            this.boxHaveHistoriaNo.Text = "Nie";
            this.boxHaveHistoriaNo.UseVisualStyleBackColor = true;
            this.boxHaveHistoriaNo.CheckedChanged += new System.EventHandler(this.boxWhichPlayerManiac_CheckedChanged);
            // 
            // boxHaveHistoriaYes
            // 
            this.boxHaveHistoriaYes.AutoSize = true;
            this.boxHaveHistoriaYes.Location = new System.Drawing.Point(77, 17);
            this.boxHaveHistoriaYes.Name = "boxHaveHistoriaYes";
            this.boxHaveHistoriaYes.Size = new System.Drawing.Size(103, 17);
            this.boxHaveHistoriaYes.TabIndex = 0;
            this.boxHaveHistoriaYes.Text = "Tak";
            this.boxHaveHistoriaYes.UseVisualStyleBackColor = true;
            this.boxHaveHistoriaYes.CheckedChanged += new System.EventHandler(this.boxWhichPlayerRare_CheckedChanged);
            // 
            // pnlAnswersQuestion2
            // 
            this.pnlAnswersQuestion2.Controls.Add(this.boxIfHasEtatNo);
            this.pnlAnswersQuestion2.Controls.Add(this.boxIfHasEtatYes);
            this.pnlAnswersQuestion2.Location = new System.Drawing.Point(58, 242);
            this.pnlAnswersQuestion2.Name = "pnlAnswersQuestion2";
            this.pnlAnswersQuestion2.Size = new System.Drawing.Size(744, 49);
            this.pnlAnswersQuestion2.TabIndex = 4;
            // 
            // boxIfHasEtatNo
            // 
            this.boxIfHasEtatNo.AutoSize = true;
            this.boxIfHasEtatNo.Location = new System.Drawing.Point(485, 17);
            this.boxIfHasEtatNo.Name = "boxIfHasEtatNo";
            this.boxIfHasEtatNo.Size = new System.Drawing.Size(42, 17);
            this.boxIfHasEtatNo.TabIndex = 1;
            this.boxIfHasEtatNo.Text = "Nie";
            this.boxIfHasEtatNo.UseVisualStyleBackColor = true;
            this.boxIfHasEtatNo.CheckedChanged += new System.EventHandler(this.boxIfUseNo_CheckedChanged);
            // 
            // boxIfHasEtatYes
            // 
            this.boxIfHasEtatYes.AutoSize = true;
            this.boxIfHasEtatYes.Location = new System.Drawing.Point(186, 17);
            this.boxIfHasEtatYes.Name = "boxIfHasEtatYes";
            this.boxIfHasEtatYes.Size = new System.Drawing.Size(45, 17);
            this.boxIfHasEtatYes.TabIndex = 0;
            this.boxIfHasEtatYes.Text = "Tak";
            this.boxIfHasEtatYes.UseVisualStyleBackColor = true;
            this.boxIfHasEtatYes.CheckedChanged += new System.EventHandler(this.boxIfUseYes_CheckedChanged);
            // 
            // pnlAnswersQuestion3
            // 
            this.pnlAnswersQuestion3.Controls.Add(this.boxIfHasUmowaNo);
            this.pnlAnswersQuestion3.Controls.Add(this.boxIfHasUmowaYes);
            this.pnlAnswersQuestion3.Location = new System.Drawing.Point(58, 242);
            this.pnlAnswersQuestion3.Name = "pnlAnswersQuestion3";
            this.pnlAnswersQuestion3.Size = new System.Drawing.Size(744, 49);
            this.pnlAnswersQuestion3.TabIndex = 5;
            // 
            // boxIfHasUmowaNo
            // 
            this.boxIfHasUmowaNo.AutoSize = true;
            this.boxIfHasUmowaNo.Location = new System.Drawing.Point(485, 17);
            this.boxIfHasUmowaNo.Name = "boxIfHasUmowaNo";
            this.boxIfHasUmowaNo.Size = new System.Drawing.Size(42, 17);
            this.boxIfHasUmowaNo.TabIndex = 1;
            this.boxIfHasUmowaNo.Text = "Nie";
            this.boxIfHasUmowaNo.UseVisualStyleBackColor = true;
            this.boxIfHasUmowaNo.CheckedChanged += new System.EventHandler(this.boxIfGraphicNo_CheckedChanged);
            // 
            // boxIfHasUmowaYes
            // 
            this.boxIfHasUmowaYes.AutoSize = true;
            this.boxIfHasUmowaYes.Location = new System.Drawing.Point(186, 17);
            this.boxIfHasUmowaYes.Name = "boxIfHasUmowaYes";
            this.boxIfHasUmowaYes.Size = new System.Drawing.Size(45, 17);
            this.boxIfHasUmowaYes.TabIndex = 0;
            this.boxIfHasUmowaYes.Text = "Tak";
            this.boxIfHasUmowaYes.UseVisualStyleBackColor = true;
            this.boxIfHasUmowaYes.CheckedChanged += new System.EventHandler(this.boxIfGraphicYes_CheckedChanged);
            // 
            // pnlAnswersQuestion4
            // 
            this.pnlAnswersQuestion4.Controls.Add(this.boxIfHasOkresNo);
            this.pnlAnswersQuestion4.Controls.Add(this.boxIfHasOkresYes);
            this.pnlAnswersQuestion4.Location = new System.Drawing.Point(58, 242);
            this.pnlAnswersQuestion4.Name = "pnlAnswersQuestion4";
            this.pnlAnswersQuestion4.Size = new System.Drawing.Size(744, 49);
            this.pnlAnswersQuestion4.TabIndex = 6;
            // 
            // boxIfHasOkresNo
            // 
            this.boxIfHasOkresNo.AutoSize = true;
            this.boxIfHasOkresNo.Location = new System.Drawing.Point(485, 17);
            this.boxIfHasOkresNo.Name = "boxIfHasOkresNo";
            this.boxIfHasOkresNo.Size = new System.Drawing.Size(42, 17);
            this.boxIfHasOkresNo.TabIndex = 1;
            this.boxIfHasOkresNo.Text = "Nie";
            this.boxIfHasOkresNo.UseVisualStyleBackColor = true;
            this.boxIfHasOkresNo.CheckedChanged += new System.EventHandler(this.boxIfGraphicJobNo_CheckedChanged);
            // 
            // boxIfHasOkresYes
            // 
            this.boxIfHasOkresYes.AutoSize = true;
            this.boxIfHasOkresYes.Location = new System.Drawing.Point(186, 17);
            this.boxIfHasOkresYes.Name = "boxIfHasOkresYes";
            this.boxIfHasOkresYes.Size = new System.Drawing.Size(45, 17);
            this.boxIfHasOkresYes.TabIndex = 0;
            this.boxIfHasOkresYes.Text = "Tak";
            this.boxIfHasOkresYes.UseVisualStyleBackColor = true;
            this.boxIfHasOkresYes.CheckedChanged += new System.EventHandler(this.boxIfGraphicJobYes_CheckedChanged);
            // 
            // pnlAnswersQuestion5
            // 
            this.pnlAnswersQuestion5.Controls.Add(this.boxIfHasDzialalnoscNo);
            this.pnlAnswersQuestion5.Controls.Add(this.boxIfHasDzialalnoscYes);
            this.pnlAnswersQuestion5.Location = new System.Drawing.Point(58, 242);
            this.pnlAnswersQuestion5.Name = "pnlAnswersQuestion5";
            this.pnlAnswersQuestion5.Size = new System.Drawing.Size(744, 49);
            this.pnlAnswersQuestion5.TabIndex = 7;
            // 
            // boxIfHasDzialalnoscNo
            // 
            this.boxIfHasDzialalnoscNo.AutoSize = true;
            this.boxIfHasDzialalnoscNo.Location = new System.Drawing.Point(485, 17);
            this.boxIfHasDzialalnoscNo.Name = "boxIfHasDzialalnoscNo";
            this.boxIfHasDzialalnoscNo.Size = new System.Drawing.Size(42, 17);
            this.boxIfHasDzialalnoscNo.TabIndex = 1;
            this.boxIfHasDzialalnoscNo.Text = "Nie";
            this.boxIfHasDzialalnoscNo.UseVisualStyleBackColor = true;
            this.boxIfHasDzialalnoscNo.CheckedChanged += new System.EventHandler(this.boxIfDesignerNo_CheckedChanged);
            // 
            // boxIfHasDzialalnoscYes
            // 
            this.boxIfHasDzialalnoscYes.AutoSize = true;
            this.boxIfHasDzialalnoscYes.Location = new System.Drawing.Point(186, 17);
            this.boxIfHasDzialalnoscYes.Name = "boxIfHasDzialalnoscYes";
            this.boxIfHasDzialalnoscYes.Size = new System.Drawing.Size(45, 17);
            this.boxIfHasDzialalnoscYes.TabIndex = 0;
            this.boxIfHasDzialalnoscYes.Text = "Tak";
            this.boxIfHasDzialalnoscYes.UseVisualStyleBackColor = true;
            this.boxIfHasDzialalnoscYes.CheckedChanged += new System.EventHandler(this.boxIfDesignerYes_CheckedChanged);
            // 
            // pnlAnswersQuestion6
            // 
            this.pnlAnswersQuestion6.Controls.Add(this.boxIfDzialalnoscPolskaNo);
            this.pnlAnswersQuestion6.Controls.Add(this.boxIfDzialalnoscPolskaYes);
            this.pnlAnswersQuestion6.Location = new System.Drawing.Point(58, 242);
            this.pnlAnswersQuestion6.Name = "pnlAnswersQuestion6";
            this.pnlAnswersQuestion6.Size = new System.Drawing.Size(744, 49);
            this.pnlAnswersQuestion6.TabIndex = 8;
            // 
            // boxIfDzialalnoscPolskaNo
            // 
            this.boxIfDzialalnoscPolskaNo.AutoSize = true;
            this.boxIfDzialalnoscPolskaNo.Location = new System.Drawing.Point(485, 17);
            this.boxIfDzialalnoscPolskaNo.Name = "boxIfDzialalnoscPolskaNo";
            this.boxIfDzialalnoscPolskaNo.Size = new System.Drawing.Size(42, 17);
            this.boxIfDzialalnoscPolskaNo.TabIndex = 1;
            this.boxIfDzialalnoscPolskaNo.Text = "Nie";
            this.boxIfDzialalnoscPolskaNo.UseVisualStyleBackColor = true;
            this.boxIfDzialalnoscPolskaNo.CheckedChanged += new System.EventHandler(this.boxIfDesignerJobNo_CheckedChanged);
            // 
            // boxIfDzialalnoscPolskaYes
            // 
            this.boxIfDzialalnoscPolskaYes.AutoSize = true;
            this.boxIfDzialalnoscPolskaYes.Location = new System.Drawing.Point(186, 17);
            this.boxIfDzialalnoscPolskaYes.Name = "boxIfDzialalnoscPolskaYes";
            this.boxIfDzialalnoscPolskaYes.Size = new System.Drawing.Size(45, 17);
            this.boxIfDzialalnoscPolskaYes.TabIndex = 0;
            this.boxIfDzialalnoscPolskaYes.Text = "Tak";
            this.boxIfDzialalnoscPolskaYes.UseVisualStyleBackColor = true;
            this.boxIfDzialalnoscPolskaYes.CheckedChanged += new System.EventHandler(this.boxIfDesignerJobYes_CheckedChanged);
            // 
            // pnlAnswersQuestion7
            // 
            this.pnlAnswersQuestion7.Controls.Add(this.boxIfOkresDluzszyNo);
            this.pnlAnswersQuestion7.Controls.Add(this.boxIfOkresDluzszyYes);
            this.pnlAnswersQuestion7.Location = new System.Drawing.Point(58, 242);
            this.pnlAnswersQuestion7.Name = "pnlAnswersQuestion7";
            this.pnlAnswersQuestion7.Size = new System.Drawing.Size(744, 49);
            this.pnlAnswersQuestion7.TabIndex = 9;
            // 
            // boxIfOkresDluzszyNo
            // 
            this.boxIfOkresDluzszyNo.AutoSize = true;
            this.boxIfOkresDluzszyNo.Location = new System.Drawing.Point(485, 17);
            this.boxIfOkresDluzszyNo.Name = "boxIfOkresDluzszyNo";
            this.boxIfOkresDluzszyNo.Size = new System.Drawing.Size(42, 17);
            this.boxIfOkresDluzszyNo.TabIndex = 1;
            this.boxIfOkresDluzszyNo.Text = "Nie";
            this.boxIfOkresDluzszyNo.UseVisualStyleBackColor = true;
            this.boxIfOkresDluzszyNo.CheckedChanged += new System.EventHandler(this.boxIfPlayerNo_CheckedChanged);
            // 
            // boxIfOkresDluzszyYes
            // 
            this.boxIfOkresDluzszyYes.AutoSize = true;
            this.boxIfOkresDluzszyYes.Location = new System.Drawing.Point(186, 17);
            this.boxIfOkresDluzszyYes.Name = "boxIfOkresDluzszyYes";
            this.boxIfOkresDluzszyYes.Size = new System.Drawing.Size(45, 17);
            this.boxIfOkresDluzszyYes.TabIndex = 0;
            this.boxIfOkresDluzszyYes.Text = "Tak";
            this.boxIfOkresDluzszyYes.UseVisualStyleBackColor = true;
            this.boxIfOkresDluzszyYes.CheckedChanged += new System.EventHandler(this.boxIfPlayerYes_CheckedChanged);
            // 
            // pnlAnswersQuestion8
            // 
            this.pnlAnswersQuestion8.Controls.Add(this.boxHaveHistoriaYes);
            this.pnlAnswersQuestion8.Controls.Add(this.boxWhichPlayerCasual);
            this.pnlAnswersQuestion8.Controls.Add(this.boxHaveHistoriaNo);
            this.pnlAnswersQuestion8.Location = new System.Drawing.Point(58, 242);
            this.pnlAnswersQuestion8.Name = "pnlAnswersQuestion8";
            this.pnlAnswersQuestion8.Size = new System.Drawing.Size(744, 49);
            this.pnlAnswersQuestion8.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pytanie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Zwróć uwagę na:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 67);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(838, 114);
            this.textBox2.TabIndex = 13;
            // 
            // pnlAnswersQuestion9
            // 
            this.pnlAnswersQuestion9.Controls.Add(this.boxHistoriaPozytywnaNo);
            this.pnlAnswersQuestion9.Controls.Add(this.boxHistoriaPozytywnaYes);
            this.pnlAnswersQuestion9.Location = new System.Drawing.Point(58, 242);
            this.pnlAnswersQuestion9.Name = "pnlAnswersQuestion9";
            this.pnlAnswersQuestion9.Size = new System.Drawing.Size(744, 49);
            this.pnlAnswersQuestion9.TabIndex = 5;
            // 
            // boxHistoriaPozytywnaNo
            // 
            this.boxHistoriaPozytywnaNo.AutoSize = true;
            this.boxHistoriaPozytywnaNo.Location = new System.Drawing.Point(485, 17);
            this.boxHistoriaPozytywnaNo.Name = "boxHistoriaPozytywnaNo";
            this.boxHistoriaPozytywnaNo.Size = new System.Drawing.Size(42, 17);
            this.boxHistoriaPozytywnaNo.TabIndex = 1;
            this.boxHistoriaPozytywnaNo.Text = "Nie";
            this.boxHistoriaPozytywnaNo.UseVisualStyleBackColor = true;
            // 
            // boxHistoriaPozytywnaYes
            // 
            this.boxHistoriaPozytywnaYes.AutoSize = true;
            this.boxHistoriaPozytywnaYes.Location = new System.Drawing.Point(186, 17);
            this.boxHistoriaPozytywnaYes.Name = "boxHistoriaPozytywnaYes";
            this.boxHistoriaPozytywnaYes.Size = new System.Drawing.Size(45, 17);
            this.boxHistoriaPozytywnaYes.TabIndex = 0;
            this.boxHistoriaPozytywnaYes.Text = "Tak";
            this.boxHistoriaPozytywnaYes.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 438);
            this.Controls.Add(this.pnlAnswersQuestion9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlAnswersQuestion2);
            this.Controls.Add(this.pnlAnswersQuestion1);
            this.Controls.Add(this.pnlAnswersQuestion3);
            this.Controls.Add(this.pnlAnswersQuestion5);
            this.Controls.Add(this.pnlAnswersQuestion6);
            this.Controls.Add(this.pnlAnswersQuestion7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlAnswersQuestion8);
            this.Controls.Add(this.pnlAnswersQuestion4);
            this.Controls.Add(this.pnlAnswersQuestion0);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ankieta";
            this.pnlAnswersQuestion0.ResumeLayout(false);
            this.pnlAnswersQuestion0.PerformLayout();
            this.pnlAnswersQuestion1.ResumeLayout(false);
            this.pnlAnswersQuestion1.PerformLayout();
            this.pnlAnswersQuestion2.ResumeLayout(false);
            this.pnlAnswersQuestion2.PerformLayout();
            this.pnlAnswersQuestion3.ResumeLayout(false);
            this.pnlAnswersQuestion3.PerformLayout();
            this.pnlAnswersQuestion4.ResumeLayout(false);
            this.pnlAnswersQuestion4.PerformLayout();
            this.pnlAnswersQuestion5.ResumeLayout(false);
            this.pnlAnswersQuestion5.PerformLayout();
            this.pnlAnswersQuestion6.ResumeLayout(false);
            this.pnlAnswersQuestion6.PerformLayout();
            this.pnlAnswersQuestion7.ResumeLayout(false);
            this.pnlAnswersQuestion7.PerformLayout();
            this.pnlAnswersQuestion8.ResumeLayout(false);
            this.pnlAnswersQuestion8.PerformLayout();
            this.pnlAnswersQuestion9.ResumeLayout(false);
            this.pnlAnswersQuestion9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlAnswersQuestion0;
        private System.Windows.Forms.CheckBox boxIfTooYoung;
        private System.Windows.Forms.CheckBox boxIfOldEnough;
        private System.Windows.Forms.Panel pnlAnswersQuestion1;
        private System.Windows.Forms.CheckBox boxHaveHistoriaNo;
        private System.Windows.Forms.CheckBox boxWhichPlayerCasual;
        private System.Windows.Forms.CheckBox boxHaveHistoriaYes;
        private System.Windows.Forms.Panel pnlAnswersQuestion2;
        private System.Windows.Forms.CheckBox boxSalaryBelow;
        private System.Windows.Forms.CheckBox boxSalaryAbove;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pnlAnswersQuestion3;
        private System.Windows.Forms.Panel pnlAnswersQuestion4;
        private System.Windows.Forms.Panel pnlAnswersQuestion5;
        private System.Windows.Forms.Panel pnlAnswersQuestion6;
        private System.Windows.Forms.Panel pnlAnswersQuestion7;
        private System.Windows.Forms.Panel pnlAnswersQuestion8;
        private System.Windows.Forms.CheckBox boxIfHasEtatNo;
        private System.Windows.Forms.CheckBox boxIfHasEtatYes;
        private System.Windows.Forms.CheckBox boxIfHasUmowaNo;
        private System.Windows.Forms.CheckBox boxIfHasUmowaYes;
        private System.Windows.Forms.CheckBox boxIfHasOkresNo;
        private System.Windows.Forms.CheckBox boxIfHasOkresYes;
        private System.Windows.Forms.CheckBox boxIfHasDzialalnoscNo;
        private System.Windows.Forms.CheckBox boxIfHasDzialalnoscYes;
        private System.Windows.Forms.CheckBox boxIfDzialalnoscPolskaNo;
        private System.Windows.Forms.CheckBox boxIfDzialalnoscPolskaYes;
        private System.Windows.Forms.CheckBox boxIfOkresDluzszyNo;
        private System.Windows.Forms.CheckBox boxIfOkresDluzszyYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel pnlAnswersQuestion9;
        private System.Windows.Forms.CheckBox boxHistoriaPozytywnaNo;
        private System.Windows.Forms.CheckBox boxHistoriaPozytywnaYes;
    }
}