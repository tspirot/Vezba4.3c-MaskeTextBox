namespace Vezba4._3c
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
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            label3 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            maskedTextBox6 = new MaskedTextBox();
            maskedTextBox7 = new MaskedTextBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            maskedTextBox8 = new MaskedTextBox();
            label8 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(530, 14);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Date:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(593, 11);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(170, 27);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            maskedTextBox1.TypeValidationCompleted += maskedTextBox1_TypeValidationCompleted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 61);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Account";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(127, 58);
            maskedTextBox2.Mask = "PDQ000-000000000-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(204, 27);
            maskedTextBox2.TabIndex = 3;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(127, 108);
            maskedTextBox3.Mask = "Mr./Mrs. >L<LL?????????????????";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(204, 27);
            maskedTextBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 111);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(394, 108);
            maskedTextBox4.Mask = ">L<LL?????????????????";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(204, 27);
            maskedTextBox4.TabIndex = 6;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(127, 163);
            maskedTextBox5.Mask = "(999) 000-0009";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(204, 27);
            maskedTextBox5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 166);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 230);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 9;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(356, 230);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 10;
            label6.Text = "Item";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(548, 230);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 11;
            label7.Text = "Price";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 263);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(65, 27);
            textBox1.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Smoki", "Chipsy", "Milka" });
            comboBox1.Location = new Point(311, 263);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 28);
            comboBox1.TabIndex = 13;
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Location = new Point(527, 265);
            maskedTextBox6.Mask = "999,990.00";
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(125, 27);
            maskedTextBox6.TabIndex = 14;
            // 
            // maskedTextBox7
            // 
            maskedTextBox7.Location = new Point(527, 298);
            maskedTextBox7.Mask = "999,990.00";
            maskedTextBox7.Name = "maskedTextBox7";
            maskedTextBox7.Size = new Size(125, 27);
            maskedTextBox7.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Smoki", "Chipsy", "Milka" });
            comboBox2.Location = new Point(311, 296);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(171, 28);
            comboBox2.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 296);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(65, 27);
            textBox2.TabIndex = 15;
            // 
            // maskedTextBox8
            // 
            maskedTextBox8.Location = new Point(527, 343);
            maskedTextBox8.Mask = "999,990.00";
            maskedTextBox8.Name = "maskedTextBox8";
            maskedTextBox8.Size = new Size(125, 27);
            maskedTextBox8.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(440, 346);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 19;
            label8.Text = "Total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(maskedTextBox8);
            Controls.Add(maskedTextBox7);
            Controls.Add(comboBox2);
            Controls.Add(textBox2);
            Controls.Add(maskedTextBox6);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(maskedTextBox5);
            Controls.Add(label4);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(label3);
            Controls.Add(maskedTextBox2);
            Controls.Add(label2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private Label label3;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox6;
        private MaskedTextBox maskedTextBox7;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox8;
        private Label label8;
        private ToolTip toolTip1;
    }
}
