namespace KZkal
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
            components = new System.ComponentModel.Container();
            xx1 = new Button();
            xx2 = new Button();
            xx3 = new Button();
            xx4 = new Button();
            xx5 = new Button();
            xx6 = new Button();
            circ = new Label();
            Result = new TextBox();
            Relapse = new Button();
            toolTip1 = new ToolTip(components);
            KZMax = new CheckBox();
            Reset = new Button();
            Add5 = new Button();
            Add10 = new Button();
            Add15 = new Button();
            Add20 = new Button();
            Rem40 = new Button();
            Rem35 = new Button();
            Rem30 = new Button();
            Rem25 = new Button();
            Rem20 = new Button();
            Rem15 = new Button();
            Rem10 = new Button();
            Rem5 = new Button();
            Rem50 = new Button();
            Rem45 = new Button();
            QL = new Label();
            MadeBy = new Label();
            SuspendLayout();
            // 
            // xx1
            // 
            xx1.BackColor = Color.Transparent;
            xx1.Font = new Font("Segoe UI", 15F);
            xx1.ForeColor = SystemColors.ActiveCaptionText;
            xx1.Location = new Point(12, 12);
            xx1.Name = "xx1";
            xx1.Size = new Size(120, 40);
            xx1.TabIndex = 1;
            xx1.Text = "1XX";
            xx1.UseVisualStyleBackColor = false;
            xx1.Click += xx1_Click;
            // 
            // xx2
            // 
            xx2.Font = new Font("Segoe UI", 15F);
            xx2.Location = new Point(138, 12);
            xx2.Name = "xx2";
            xx2.Size = new Size(120, 40);
            xx2.TabIndex = 2;
            xx2.Text = "2XX";
            xx2.UseVisualStyleBackColor = true;
            xx2.Click += xx2_Click;
            // 
            // xx3
            // 
            xx3.Font = new Font("Segoe UI", 15F);
            xx3.Location = new Point(264, 12);
            xx3.Name = "xx3";
            xx3.Size = new Size(120, 40);
            xx3.TabIndex = 3;
            xx3.Text = "3XX";
            xx3.UseVisualStyleBackColor = true;
            xx3.Click += xx3_Click;
            // 
            // xx4
            // 
            xx4.Font = new Font("Segoe UI", 15F);
            xx4.Location = new Point(390, 12);
            xx4.Name = "xx4";
            xx4.Size = new Size(120, 40);
            xx4.TabIndex = 4;
            xx4.Text = "4XX";
            xx4.UseVisualStyleBackColor = true;
            xx4.Click += xx4_Click;
            // 
            // xx5
            // 
            xx5.Font = new Font("Segoe UI", 15F);
            xx5.Location = new Point(516, 12);
            xx5.Name = "xx5";
            xx5.Size = new Size(120, 40);
            xx5.TabIndex = 5;
            xx5.Text = "5XX";
            xx5.UseVisualStyleBackColor = true;
            xx5.Click += xx5_Click;
            // 
            // xx6
            // 
            xx6.Font = new Font("Segoe UI", 15F);
            xx6.Location = new Point(642, 12);
            xx6.Name = "xx6";
            xx6.Size = new Size(120, 40);
            xx6.TabIndex = 6;
            xx6.Text = "6XX";
            xx6.UseVisualStyleBackColor = true;
            xx6.Click += xx6_Click;
            // 
            // circ
            // 
            circ.AutoSize = true;
            circ.Font = new Font("Segoe UI", 15F);
            circ.Location = new Point(12, 111);
            circ.Name = "circ";
            circ.Size = new Size(157, 28);
            circ.TabIndex = 7;
            circ.Text = "Модификаторы";
            circ.Click += circ_Click;
            // 
            // Result
            // 
            Result.Font = new Font("Segoe UI", 25F);
            Result.Location = new Point(12, 58);
            Result.Multiline = true;
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Size = new Size(200, 50);
            Result.TabIndex = 8;
            Result.TextAlign = HorizontalAlignment.Center;
            Result.TextChanged += Result_TextChanged;
            // 
            // Relapse
            // 
            Relapse.Font = new Font("Segoe UI", 10F);
            Relapse.Location = new Point(12, 142);
            Relapse.Name = "Relapse";
            Relapse.Size = new Size(157, 50);
            Relapse.TabIndex = 10;
            Relapse.Text = "Рецедевив\r\n+15%\r\n\r\n";
            Relapse.UseVisualStyleBackColor = true;
            Relapse.Click += Relapse_Click;
            // 
            // KZMax
            // 
            KZMax.AutoSize = true;
            KZMax.Font = new Font("Segoe UI", 16F);
            KZMax.Location = new Point(218, 60);
            KZMax.Name = "KZMax";
            KZMax.Size = new Size(295, 34);
            KZMax.TabIndex = 11;
            KZMax.Text = "Максимальное наказание";
            KZMax.UseVisualStyleBackColor = true;
            KZMax.CheckedChanged += KZMax_CheckedChanged;
            // 
            // Reset
            // 
            Reset.Location = new Point(218, 85);
            Reset.Name = "Reset";
            Reset.Size = new Size(75, 23);
            Reset.TabIndex = 12;
            Reset.Text = "Сброс";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // Add5
            // 
            Add5.Location = new Point(12, 198);
            Add5.Name = "Add5";
            Add5.Size = new Size(69, 55);
            Add5.TabIndex = 13;
            Add5.Text = "Добавить\r\n5%\r\n";
            Add5.UseVisualStyleBackColor = true;
            Add5.Click += Add5_Click;
            // 
            // Add10
            // 
            Add10.Location = new Point(87, 198);
            Add10.Name = "Add10";
            Add10.Size = new Size(69, 55);
            Add10.TabIndex = 14;
            Add10.Text = "Добавить\r\n10%\r\n";
            Add10.UseVisualStyleBackColor = true;
            Add10.Click += Add10_Click;
            // 
            // Add15
            // 
            Add15.Location = new Point(162, 198);
            Add15.Name = "Add15";
            Add15.Size = new Size(69, 55);
            Add15.TabIndex = 15;
            Add15.Text = "Добавить\r\n15%\r\n";
            Add15.UseVisualStyleBackColor = true;
            Add15.Click += Add15_Click;
            // 
            // Add20
            // 
            Add20.Location = new Point(237, 198);
            Add20.Name = "Add20";
            Add20.Size = new Size(69, 55);
            Add20.TabIndex = 16;
            Add20.Text = "Добавить\r\n20%\r\n";
            Add20.UseVisualStyleBackColor = true;
            Add20.Click += Add20_Click;
            // 
            // Rem40
            // 
            Rem40.Location = new Point(237, 320);
            Rem40.Name = "Rem40";
            Rem40.Size = new Size(69, 55);
            Rem40.TabIndex = 20;
            Rem40.Text = "Убрать \r\n40%\r\n";
            Rem40.UseVisualStyleBackColor = true;
            Rem40.Click += Rem40_Click;
            // 
            // Rem35
            // 
            Rem35.Location = new Point(237, 259);
            Rem35.Name = "Rem35";
            Rem35.Size = new Size(69, 55);
            Rem35.TabIndex = 19;
            Rem35.Text = "Убрать\r\n35%\r\n";
            Rem35.UseVisualStyleBackColor = true;
            Rem35.Click += Rem35_Click;
            // 
            // Rem30
            // 
            Rem30.Location = new Point(162, 320);
            Rem30.Name = "Rem30";
            Rem30.Size = new Size(69, 55);
            Rem30.TabIndex = 18;
            Rem30.Text = "Убрать 30%\r\n";
            Rem30.UseVisualStyleBackColor = true;
            Rem30.Click += Rem30_Click;
            // 
            // Rem25
            // 
            Rem25.Location = new Point(162, 259);
            Rem25.Name = "Rem25";
            Rem25.Size = new Size(69, 55);
            Rem25.TabIndex = 17;
            Rem25.Text = "Убрать 25%\r\n";
            Rem25.UseVisualStyleBackColor = true;
            Rem25.Click += Rem25_Click;
            // 
            // Rem20
            // 
            Rem20.Location = new Point(87, 320);
            Rem20.Name = "Rem20";
            Rem20.Size = new Size(69, 55);
            Rem20.TabIndex = 24;
            Rem20.Text = "Убрать \r\n20%\r\n";
            Rem20.UseVisualStyleBackColor = true;
            Rem20.Click += Rem20_Click;
            // 
            // Rem15
            // 
            Rem15.Location = new Point(87, 259);
            Rem15.Name = "Rem15";
            Rem15.Size = new Size(69, 55);
            Rem15.TabIndex = 23;
            Rem15.Text = "Убрать\n15%\r\n";
            Rem15.UseVisualStyleBackColor = true;
            Rem15.Click += Rem15_Click;
            // 
            // Rem10
            // 
            Rem10.Location = new Point(12, 320);
            Rem10.Name = "Rem10";
            Rem10.Size = new Size(69, 55);
            Rem10.TabIndex = 22;
            Rem10.Text = "Убрать\r\n10%\r\n";
            Rem10.UseVisualStyleBackColor = true;
            Rem10.Click += Rem10_Click;
            // 
            // Rem5
            // 
            Rem5.Location = new Point(12, 259);
            Rem5.Name = "Rem5";
            Rem5.Size = new Size(69, 55);
            Rem5.TabIndex = 21;
            Rem5.Text = "Убрать\r\n5%\r\n";
            Rem5.UseVisualStyleBackColor = true;
            Rem5.Click += Rem5_Click;
            // 
            // Rem50
            // 
            Rem50.Location = new Point(312, 320);
            Rem50.Name = "Rem50";
            Rem50.Size = new Size(69, 55);
            Rem50.TabIndex = 25;
            Rem50.Text = "Убрать 50%\r\n";
            Rem50.UseVisualStyleBackColor = true;
            Rem50.Click += Rem50_Click;
            // 
            // Rem45
            // 
            Rem45.Location = new Point(312, 259);
            Rem45.Name = "Rem45";
            Rem45.Size = new Size(69, 55);
            Rem45.TabIndex = 26;
            Rem45.Text = "Убрать \r\n45%\r\n";
            Rem45.UseVisualStyleBackColor = true;
            Rem45.Click += Rem45_Click;
            // 
            // QL
            // 
            QL.AutoSize = true;
            QL.Location = new Point(649, 417);
            QL.Name = "QL";
            QL.Size = new Size(113, 15);
            QL.TabIndex = 27;
            QL.Text = "QL-14013025 NT-0.1";
            QL.Click += QL_Click;
            // 
            // MadeBy
            // 
            MadeBy.AutoSize = true;
            MadeBy.Font = new Font("Microsoft Sans Serif", 9F);
            MadeBy.Location = new Point(12, 417);
            MadeBy.Name = "MadeBy";
            MadeBy.Size = new Size(173, 15);
            MadeBy.TabIndex = 28;
            MadeBy.Text = "сделанно Моникой Шировой";
            MadeBy.Click += MadeBy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(784, 441);
            Controls.Add(MadeBy);
            Controls.Add(QL);
            Controls.Add(Rem45);
            Controls.Add(Rem50);
            Controls.Add(Rem20);
            Controls.Add(Rem15);
            Controls.Add(Rem10);
            Controls.Add(Rem5);
            Controls.Add(Rem40);
            Controls.Add(Rem35);
            Controls.Add(Rem30);
            Controls.Add(Rem25);
            Controls.Add(Add20);
            Controls.Add(Add15);
            Controls.Add(Add10);
            Controls.Add(Add5);
            Controls.Add(Reset);
            Controls.Add(KZMax);
            Controls.Add(Relapse);
            Controls.Add(Result);
            Controls.Add(circ);
            Controls.Add(xx6);
            Controls.Add(xx5);
            Controls.Add(xx4);
            Controls.Add(xx3);
            Controls.Add(xx2);
            Controls.Add(xx1);
            Name = "Form1";
            Text = "Shitcurity - 3000 ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button xx1;
        private Button xx2;
        private Button xx3;
        private Button xx4;
        private Button xx5;
        private Button xx6;
        private Label circ;
        private TextBox Result;
        private Button Relapse;
        private ToolTip toolTip1;
        private CheckBox KZMax;
        private Button Reset;
        private Button Add5;
        private Button Add10;
        private Button Add15;
        private Button Add20;
        private Button Rem40;
        private Button Rem35;
        private Button Rem30;
        private Button Rem25;
        private Button Rem20;
        private Button Rem15;
        private Button Rem10;
        private Button Rem5;
        private Button Rem50;
        private Button Rem45;
        private Label QL;
        private Label MadeBy;
    }
}
