namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbcal = new TextBox();
            tbresult = new TextBox();
            label1 = new Label();
            bnCE = new Button();
            bnC = new Button();
            bnDEL = new Button();
            bn7 = new Button();
            bn8 = new Button();
            bn9 = new Button();
            bn4 = new Button();
            bn5 = new Button();
            bn6 = new Button();
            bn1 = new Button();
            bn2 = new Button();
            bn3 = new Button();
            bnpm = new Button();
            bn0 = new Button();
            bndot = new Button();
            bndivide = new Button();
            bnX = new Button();
            bnminus = new Button();
            bnplus = new Button();
            bnresult = new Button();
            SuspendLayout();
            // 
            // tbcal
            // 
            tbcal.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            tbcal.Location = new Point(113, 97);
            tbcal.Name = "tbcal";
            tbcal.Size = new Size(349, 35);
            tbcal.TabIndex = 0;
            // 
            // tbresult
            // 
            tbresult.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            tbresult.Location = new Point(115, 148);
            tbresult.Name = "tbresult";
            tbresult.Size = new Size(347, 35);
            tbresult.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(75, 9);
            label1.Name = "label1";
            label1.Size = new Size(426, 65);
            label1.TabIndex = 1;
            label1.Text = "Simple Calculator";
            // 
            // bnCE
            // 
            bnCE.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bnCE.Location = new Point(115, 213);
            bnCE.Name = "bnCE";
            bnCE.Size = new Size(74, 36);
            bnCE.TabIndex = 2;
            bnCE.Text = "CE";
            bnCE.UseVisualStyleBackColor = true;
            bnCE.Click += button1_Click;
            // 
            // bnC
            // 
            bnC.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bnC.Location = new Point(205, 213);
            bnC.Name = "bnC";
            bnC.Size = new Size(74, 36);
            bnC.TabIndex = 2;
            bnC.Text = "C";
            bnC.UseVisualStyleBackColor = true;
            bnC.Click += button1_Click;
            // 
            // bnDEL
            // 
            bnDEL.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bnDEL.Location = new Point(294, 213);
            bnDEL.Name = "bnDEL";
            bnDEL.Size = new Size(74, 36);
            bnDEL.TabIndex = 2;
            bnDEL.Text = "del";
            bnDEL.UseVisualStyleBackColor = true;
            bnDEL.Click += button1_Click;
            // 
            // bn7
            // 
            bn7.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bn7.ForeColor = Color.Red;
            bn7.Location = new Point(113, 268);
            bn7.Name = "bn7";
            bn7.Size = new Size(74, 36);
            bn7.TabIndex = 2;
            bn7.Text = "7";
            bn7.UseVisualStyleBackColor = true;
            bn7.Click += button1_Click;
            // 
            // bn8
            // 
            bn8.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bn8.ForeColor = Color.Red;
            bn8.Location = new Point(205, 268);
            bn8.Name = "bn8";
            bn8.Size = new Size(74, 36);
            bn8.TabIndex = 2;
            bn8.Text = "8";
            bn8.UseVisualStyleBackColor = true;
            bn8.Click += button1_Click;
            // 
            // bn9
            // 
            bn9.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bn9.ForeColor = Color.Red;
            bn9.Location = new Point(294, 268);
            bn9.Name = "bn9";
            bn9.Size = new Size(74, 36);
            bn9.TabIndex = 2;
            bn9.Text = "9";
            bn9.UseVisualStyleBackColor = true;
            bn9.Click += button1_Click;
            // 
            // bn4
            // 
            bn4.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bn4.ForeColor = Color.Red;
            bn4.Location = new Point(115, 319);
            bn4.Name = "bn4";
            bn4.Size = new Size(74, 36);
            bn4.TabIndex = 2;
            bn4.Text = "4";
            bn4.UseVisualStyleBackColor = true;
            bn4.Click += button1_Click;
            // 
            // bn5
            // 
            bn5.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bn5.ForeColor = Color.Red;
            bn5.Location = new Point(205, 319);
            bn5.Name = "bn5";
            bn5.Size = new Size(74, 36);
            bn5.TabIndex = 2;
            bn5.Text = "5";
            bn5.UseVisualStyleBackColor = true;
            bn5.Click += button1_Click;
            // 
            // bn6
            // 
            bn6.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bn6.ForeColor = Color.Red;
            bn6.Location = new Point(294, 319);
            bn6.Name = "bn6";
            bn6.Size = new Size(74, 36);
            bn6.TabIndex = 2;
            bn6.Text = "6";
            bn6.UseVisualStyleBackColor = true;
            bn6.Click += button1_Click;
            // 
            // bn1
            // 
            bn1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bn1.ForeColor = Color.Red;
            bn1.Location = new Point(115, 371);
            bn1.Name = "bn1";
            bn1.Size = new Size(74, 36);
            bn1.TabIndex = 2;
            bn1.Text = "1";
            bn1.UseVisualStyleBackColor = true;
            bn1.Click += button1_Click;
            // 
            // bn2
            // 
            bn2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bn2.ForeColor = Color.Red;
            bn2.Location = new Point(205, 371);
            bn2.Name = "bn2";
            bn2.Size = new Size(74, 36);
            bn2.TabIndex = 2;
            bn2.Text = "2";
            bn2.UseVisualStyleBackColor = true;
            bn2.Click += button1_Click;
            // 
            // bn3
            // 
            bn3.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bn3.ForeColor = Color.Red;
            bn3.Location = new Point(294, 371);
            bn3.Name = "bn3";
            bn3.Size = new Size(74, 36);
            bn3.TabIndex = 2;
            bn3.Text = "3";
            bn3.UseVisualStyleBackColor = true;
            bn3.Click += button1_Click;
            // 
            // bnpm
            // 
            bnpm.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bnpm.Location = new Point(115, 423);
            bnpm.Name = "bnpm";
            bnpm.Size = new Size(74, 36);
            bnpm.TabIndex = 2;
            bnpm.Text = "+/-";
            bnpm.UseVisualStyleBackColor = true;
            bnpm.Click += button1_Click;
            // 
            // bn0
            // 
            bn0.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bn0.ForeColor = Color.Red;
            bn0.Location = new Point(205, 423);
            bn0.Name = "bn0";
            bn0.Size = new Size(74, 36);
            bn0.TabIndex = 2;
            bn0.Text = "0";
            bn0.UseVisualStyleBackColor = true;
            bn0.Click += button1_Click;
            // 
            // bndot
            // 
            bndot.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bndot.Location = new Point(294, 423);
            bndot.Name = "bndot";
            bndot.Size = new Size(74, 36);
            bndot.TabIndex = 2;
            bndot.Text = ".";
            bndot.UseVisualStyleBackColor = true;
            bndot.Click += button1_Click;
            // 
            // bndivide
            // 
            bndivide.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bndivide.ForeColor = SystemColors.MenuHighlight;
            bndivide.Location = new Point(388, 213);
            bndivide.Name = "bndivide";
            bndivide.Size = new Size(74, 36);
            bndivide.TabIndex = 2;
            bndivide.Text = "%";
            bndivide.UseVisualStyleBackColor = true;
            bndivide.Click += button1_Click;
            // 
            // bnX
            // 
            bnX.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bnX.ForeColor = SystemColors.MenuHighlight;
            bnX.Location = new Point(388, 268);
            bnX.Name = "bnX";
            bnX.Size = new Size(74, 36);
            bnX.TabIndex = 2;
            bnX.Text = "X";
            bnX.UseVisualStyleBackColor = true;
            bnX.Click += button1_Click;
            // 
            // bnminus
            // 
            bnminus.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bnminus.ForeColor = SystemColors.MenuHighlight;
            bnminus.Location = new Point(388, 319);
            bnminus.Name = "bnminus";
            bnminus.Size = new Size(74, 36);
            bnminus.TabIndex = 2;
            bnminus.Text = "-";
            bnminus.UseVisualStyleBackColor = true;
            bnminus.Click += button1_Click;
            // 
            // bnplus
            // 
            bnplus.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bnplus.ForeColor = SystemColors.MenuHighlight;
            bnplus.Location = new Point(388, 371);
            bnplus.Name = "bnplus";
            bnplus.Size = new Size(74, 36);
            bnplus.TabIndex = 2;
            bnplus.Text = "+";
            bnplus.UseVisualStyleBackColor = true;
            bnplus.Click += button1_Click;
            // 
            // bnresult
            // 
            bnresult.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bnresult.Location = new Point(388, 423);
            bnresult.Name = "bnresult";
            bnresult.Size = new Size(74, 36);
            bnresult.TabIndex = 2;
            bnresult.Text = "=";
            bnresult.UseVisualStyleBackColor = true;
            bnresult.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 506);
            Controls.Add(bnresult);
            Controls.Add(bndot);
            Controls.Add(bn0);
            Controls.Add(bnplus);
            Controls.Add(bn3);
            Controls.Add(bn2);
            Controls.Add(bnminus);
            Controls.Add(bn6);
            Controls.Add(bn5);
            Controls.Add(bnpm);
            Controls.Add(bnX);
            Controls.Add(bn9);
            Controls.Add(bn1);
            Controls.Add(bn8);
            Controls.Add(bn4);
            Controls.Add(bndivide);
            Controls.Add(bnDEL);
            Controls.Add(bn7);
            Controls.Add(bnC);
            Controls.Add(bnCE);
            Controls.Add(label1);
            Controls.Add(tbresult);
            Controls.Add(tbcal);
            Name = "Form1";
            Text = "ㅊ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbcal;
        private TextBox tbresult;
        private Label label1;
        private Button bnCE;
        private Button bnC;
        private Button bnDEL;
        private Button bn7;
        private Button bn8;
        private Button bn9;
        private Button bn4;
        private Button bn5;
        private Button bn6;
        private Button bn1;
        private Button bn2;
        private Button bn3;
        private Button bnpm;
        private Button bn0;
        private Button bndot;
        private Button bndivide;
        private Button bnX;
        private Button bnminus;
        private Button bnplus;
        private Button bnresult;
    }
}
