namespace LoginPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 220);
            label1.Name = "label1";
            label1.Size = new Size(193, 28);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik Numarasi:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(281, 217);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(180, 34);
            maskedTextBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 34);
            textBox1.TabIndex = 2;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 263);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 3;
            label2.Text = "Sifre:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 140);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(523, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 42);
            label3.Name = "label3";
            label3.Size = new Size(449, 57);
            label3.TabIndex = 0;
            label3.Text = "Universite Giris Paneli";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCoral;
            panel2.Location = new Point(-5, 444);
            panel2.Name = "panel2";
            panel2.Size = new Size(722, 23);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(336, 297);
            button1.Name = "button1";
            button1.Size = new Size(104, 41);
            button1.TabIndex = 6;
            button1.Text = "Giris";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(475, 259);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(186, 32);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Sifremi Unuttum";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 466);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Kullanici Giris Paneli";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Button button1;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
    }
}
