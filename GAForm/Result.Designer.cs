namespace GAForm
{
    partial class Result
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
            BestGenesX = new TextBox();
            BestGeneFitVal = new TextBox();
            PoptxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CrossovertxtBox = new TextBox();
            label3 = new Label();
            MuttxtBox = new TextBox();
            label4 = new Label();
            ElitetxtBox = new TextBox();
            label5 = new Label();
            GentxtBox = new TextBox();
            ExecBtn = new Button();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            BestGenesY = new TextBox();
            label8 = new Label();
            ExitButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // BestGenesX
            // 
            BestGenesX.BackColor = Color.FromArgb(43, 45, 62);
            BestGenesX.BorderStyle = BorderStyle.None;
            BestGenesX.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BestGenesX.ForeColor = SystemColors.Control;
            BestGenesX.Location = new Point(143, 346);
            BestGenesX.Name = "BestGenesX";
            BestGenesX.ReadOnly = true;
            BestGenesX.Size = new Size(203, 25);
            BestGenesX.TabIndex = 2;
            // 
            // BestGeneFitVal
            // 
            BestGeneFitVal.BackColor = Color.FromArgb(43, 45, 62);
            BestGeneFitVal.BorderStyle = BorderStyle.None;
            BestGeneFitVal.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BestGeneFitVal.ForeColor = SystemColors.Control;
            BestGeneFitVal.Location = new Point(143, 438);
            BestGeneFitVal.Name = "BestGeneFitVal";
            BestGeneFitVal.ReadOnly = true;
            BestGeneFitVal.Size = new Size(203, 25);
            BestGeneFitVal.TabIndex = 3;
            // 
            // PoptxtBox
            // 
            PoptxtBox.BackColor = Color.FromArgb(52, 63, 86);
            PoptxtBox.BorderStyle = BorderStyle.None;
            PoptxtBox.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PoptxtBox.ForeColor = SystemColors.Control;
            PoptxtBox.Location = new Point(18, 75);
            PoptxtBox.Name = "PoptxtBox";
            PoptxtBox.Size = new Size(125, 25);
            PoptxtBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(18, 23);
            label1.Name = "label1";
            label1.Size = new Size(159, 23);
            label1.TabIndex = 5;
            label1.Text = "Population Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(19, 23);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 7;
            label2.Text = "Crossover Rate";
            // 
            // CrossovertxtBox
            // 
            CrossovertxtBox.BackColor = Color.FromArgb(52, 63, 86);
            CrossovertxtBox.BorderStyle = BorderStyle.None;
            CrossovertxtBox.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CrossovertxtBox.ForeColor = SystemColors.Control;
            CrossovertxtBox.Location = new Point(19, 75);
            CrossovertxtBox.Name = "CrossovertxtBox";
            CrossovertxtBox.Size = new Size(125, 25);
            CrossovertxtBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(18, 23);
            label3.Name = "label3";
            label3.Size = new Size(154, 23);
            label3.TabIndex = 9;
            label3.Text = "Mutation Rate";
            // 
            // MuttxtBox
            // 
            MuttxtBox.BackColor = Color.FromArgb(52, 63, 86);
            MuttxtBox.BorderStyle = BorderStyle.None;
            MuttxtBox.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MuttxtBox.ForeColor = SystemColors.Control;
            MuttxtBox.Location = new Point(18, 75);
            MuttxtBox.Name = "MuttxtBox";
            MuttxtBox.Size = new Size(125, 25);
            MuttxtBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(22, 23);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 11;
            label4.Text = "Elite Count";
            // 
            // ElitetxtBox
            // 
            ElitetxtBox.BackColor = Color.FromArgb(52, 63, 86);
            ElitetxtBox.BorderStyle = BorderStyle.None;
            ElitetxtBox.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ElitetxtBox.ForeColor = SystemColors.Control;
            ElitetxtBox.Location = new Point(22, 75);
            ElitetxtBox.Name = "ElitetxtBox";
            ElitetxtBox.Size = new Size(125, 25);
            ElitetxtBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(19, 23);
            label5.Name = "label5";
            label5.Size = new Size(163, 22);
            label5.TabIndex = 13;
            label5.Text = "Generation Count";
            // 
            // GentxtBox
            // 
            GentxtBox.BackColor = Color.FromArgb(52, 63, 86);
            GentxtBox.BorderStyle = BorderStyle.None;
            GentxtBox.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GentxtBox.ForeColor = SystemColors.Control;
            GentxtBox.Location = new Point(19, 75);
            GentxtBox.Name = "GentxtBox";
            GentxtBox.Size = new Size(125, 25);
            GentxtBox.TabIndex = 12;
            // 
            // ExecBtn
            // 
            ExecBtn.BackColor = Color.FromArgb(43, 45, 62);
            ExecBtn.FlatStyle = FlatStyle.Popup;
            ExecBtn.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ExecBtn.ForeColor = SystemColors.Control;
            ExecBtn.Location = new Point(17, 163);
            ExecBtn.Name = "ExecBtn";
            ExecBtn.Size = new Size(353, 93);
            ExecBtn.TabIndex = 15;
            ExecBtn.Text = "Execute";
            ExecBtn.UseVisualStyleBackColor = false;
            ExecBtn.Click += ExecBtn_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.FromArgb(43, 45, 62);
            formsPlot1.DisplayScale = 1.25F;
            formsPlot1.Location = new Point(381, 149);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(733, 391);
            formsPlot1.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(42, 438);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 19;
            label6.Text = "Fitness";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(42, 346);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 20;
            label7.Text = "Best X";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 45, 62);
            panel1.Controls.Add(PoptxtBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 114);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(43, 45, 62);
            panel2.Controls.Add(CrossovertxtBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(235, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 114);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(43, 45, 62);
            panel3.Controls.Add(MuttxtBox);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(462, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 114);
            panel3.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(43, 45, 62);
            panel4.Controls.Add(ElitetxtBox);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(689, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 114);
            panel4.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(43, 45, 62);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(GentxtBox);
            panel5.Location = new Point(911, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 114);
            panel5.TabIndex = 22;
            // 
            // BestGenesY
            // 
            BestGenesY.BackColor = Color.FromArgb(43, 45, 62);
            BestGenesY.BorderStyle = BorderStyle.None;
            BestGenesY.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BestGenesY.ForeColor = SystemColors.Control;
            BestGenesY.Location = new Point(143, 394);
            BestGenesY.Name = "BestGenesY";
            BestGenesY.ReadOnly = true;
            BestGenesY.Size = new Size(203, 25);
            BestGenesY.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(42, 394);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 24;
            label8.Text = "Best Y";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(43, 45, 62);
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.ForeColor = SystemColors.Control;
            ExitButton.Location = new Point(17, 490);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(46, 39);
            ExitButton.TabIndex = 25;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 63, 86);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1120, 541);
            Controls.Add(ExitButton);
            Controls.Add(label8);
            Controls.Add(BestGenesY);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(formsPlot1);
            Controls.Add(ExecBtn);
            Controls.Add(BestGeneFitVal);
            Controls.Add(BestGenesX);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Result";
            ShowIcon = false;
            Text = "GeneticAlg";
            Load += Result_load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox BestGenesX;
        private TextBox BestGeneFitVal;
        private TextBox PoptxtBox;
        private Label label1;
        private Label label2;
        private TextBox CrossovertxtBox;
        private Label label3;
        private TextBox MuttxtBox;
        private Label label4;
        private TextBox ElitetxtBox;
        private Label label5;
        private TextBox GentxtBox;
        private Button ExecBtn;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TextBox BestGenesY;
        private Label label8;
        private Button ExitButton;
    }
}