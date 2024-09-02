namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            texboxEst1_1 = new TextBox();
            texboxEst1_2 = new TextBox();
            texboxEst1_3 = new TextBox();
            texboxEst2_1 = new TextBox();
            texboxEst2_2 = new TextBox();
            texboxEst2_3 = new TextBox();
            texboxEst3_1 = new TextBox();
            texboxEst3_2 = new TextBox();
            texboxEst3_3 = new TextBox();
            listPromediosEst = new ListBox();
            listPromediosEx = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 24);
            label1.Name = "label1";
            label1.Size = new Size(370, 32);
            label1.TabIndex = 0;
            label1.Text = "CALIFICACIONES ESTUDIANTES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(207, 78);
            label2.Name = "label2";
            label2.Size = new Size(48, 30);
            label2.TabIndex = 1;
            label2.Text = "Ex1";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(303, 78);
            label3.Name = "label3";
            label3.Size = new Size(48, 30);
            label3.TabIndex = 2;
            label3.Text = "Ex2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(390, 78);
            label4.Name = "label4";
            label4.Size = new Size(48, 30);
            label4.TabIndex = 3;
            label4.Text = "Ex3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 112);
            label5.Name = "label5";
            label5.Size = new Size(134, 30);
            label5.TabIndex = 4;
            label5.Text = "Estudiante 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 157);
            label6.Name = "label6";
            label6.Size = new Size(134, 30);
            label6.TabIndex = 5;
            label6.Text = "Estudiante 2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 203);
            label7.Name = "label7";
            label7.Size = new Size(134, 30);
            label7.TabIndex = 6;
            label7.Text = "Estudiante 3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(477, 199);
            label8.Name = "label8";
            label8.Size = new Size(261, 30);
            label8.TabIndex = 7;
            label8.Text = "Promedios por examenes";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(477, 78);
            label10.Name = "label10";
            label10.Size = new Size(276, 30);
            label10.TabIndex = 9;
            label10.Text = "Promedios por estudiantes";
            // 
            // texboxEst1_1
            // 
            texboxEst1_1.Location = new Point(207, 112);
            texboxEst1_1.Multiline = true;
            texboxEst1_1.Name = "texboxEst1_1";
            texboxEst1_1.Size = new Size(48, 34);
            texboxEst1_1.TabIndex = 10;
            // 
            // texboxEst1_2
            // 
            texboxEst1_2.Location = new Point(303, 112);
            texboxEst1_2.Multiline = true;
            texboxEst1_2.Name = "texboxEst1_2";
            texboxEst1_2.Size = new Size(48, 34);
            texboxEst1_2.TabIndex = 11;
            // 
            // texboxEst1_3
            // 
            texboxEst1_3.Location = new Point(390, 112);
            texboxEst1_3.Multiline = true;
            texboxEst1_3.Name = "texboxEst1_3";
            texboxEst1_3.Size = new Size(48, 34);
            texboxEst1_3.TabIndex = 12;
            // 
            // texboxEst2_1
            // 
            texboxEst2_1.Location = new Point(207, 157);
            texboxEst2_1.Multiline = true;
            texboxEst2_1.Name = "texboxEst2_1";
            texboxEst2_1.Size = new Size(48, 34);
            texboxEst2_1.TabIndex = 13;
            // 
            // texboxEst2_2
            // 
            texboxEst2_2.Location = new Point(303, 157);
            texboxEst2_2.Multiline = true;
            texboxEst2_2.Name = "texboxEst2_2";
            texboxEst2_2.Size = new Size(48, 34);
            texboxEst2_2.TabIndex = 14;
            // 
            // texboxEst2_3
            // 
            texboxEst2_3.Location = new Point(390, 157);
            texboxEst2_3.Multiline = true;
            texboxEst2_3.Name = "texboxEst2_3";
            texboxEst2_3.Size = new Size(48, 34);
            texboxEst2_3.TabIndex = 15;
            // 
            // texboxEst3_1
            // 
            texboxEst3_1.Location = new Point(207, 203);
            texboxEst3_1.Multiline = true;
            texboxEst3_1.Name = "texboxEst3_1";
            texboxEst3_1.Size = new Size(48, 34);
            texboxEst3_1.TabIndex = 16;
            // 
            // texboxEst3_2
            // 
            texboxEst3_2.Location = new Point(303, 203);
            texboxEst3_2.Multiline = true;
            texboxEst3_2.Name = "texboxEst3_2";
            texboxEst3_2.Size = new Size(48, 34);
            texboxEst3_2.TabIndex = 17;
            // 
            // texboxEst3_3
            // 
            texboxEst3_3.Location = new Point(390, 203);
            texboxEst3_3.Multiline = true;
            texboxEst3_3.Name = "texboxEst3_3";
            texboxEst3_3.Size = new Size(48, 34);
            texboxEst3_3.TabIndex = 18;
            // 
            // listPromediosEst
            // 
            listPromediosEst.FormattingEnabled = true;
            listPromediosEst.ItemHeight = 15;
            listPromediosEst.Location = new Point(477, 113);
            listPromediosEst.Name = "listPromediosEst";
            listPromediosEst.Size = new Size(295, 79);
            listPromediosEst.TabIndex = 19;
            // 
            // listPromediosEx
            // 
            listPromediosEx.FormattingEnabled = true;
            listPromediosEx.ItemHeight = 15;
            listPromediosEx.Location = new Point(477, 236);
            listPromediosEx.Name = "listPromediosEx";
            listPromediosEx.Size = new Size(295, 79);
            listPromediosEx.TabIndex = 20;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(37, 255);
            button1.Name = "button1";
            button1.Size = new Size(288, 63);
            button1.TabIndex = 21;
            button1.Text = "CALCULAR PROMEDIOS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 355);
            Controls.Add(button1);
            Controls.Add(listPromediosEx);
            Controls.Add(listPromediosEst);
            Controls.Add(texboxEst3_3);
            Controls.Add(texboxEst3_2);
            Controls.Add(texboxEst3_1);
            Controls.Add(texboxEst2_3);
            Controls.Add(texboxEst2_2);
            Controls.Add(texboxEst2_1);
            Controls.Add(texboxEst1_3);
            Controls.Add(texboxEst1_2);
            Controls.Add(texboxEst1_1);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calificaciones Estudiantes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private TextBox texboxEst1_1;
        private TextBox texboxEst1_2;
        private TextBox texboxEst1_3;
        private TextBox texboxEst2_1;
        private TextBox texboxEst2_2;
        private TextBox texboxEst2_3;
        private TextBox texboxEst3_1;
        private TextBox texboxEst3_2;
        private TextBox texboxEst3_3;
        private ListBox listPromediosEst;
        private ListBox listPromediosEx;
        private Button button1;
    }
}
