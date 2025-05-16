namespace HastaRandevuSistemi
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
            lblBranslar = new Label();
            lblDoktorlar = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbBranslar = new ComboBox();
            cmbDoktorlar = new ComboBox();
            label1 = new Label();
            dtpTarih = new DateTimePicker();
            cmbSaat = new ComboBox();
            txtHastaAdi = new TextBox();
            txtHastaSoyadi = new TextBox();
            btnRandevuOlustur = new Button();
            SuspendLayout();
            // 
            // lblBranslar
            // 
            lblBranslar.AutoSize = true;
            lblBranslar.Location = new Point(164, 131);
            lblBranslar.Name = "lblBranslar";
            lblBranslar.Size = new Size(133, 40);
            lblBranslar.TabIndex = 0;
            lblBranslar.Text = "Branslar:";
            // 
            // lblDoktorlar
            // 
            lblDoktorlar.AutoSize = true;
            lblDoktorlar.Location = new Point(912, 131);
            lblDoktorlar.Name = "lblDoktorlar";
            lblDoktorlar.Size = new Size(150, 40);
            lblDoktorlar.TabIndex = 1;
            lblDoktorlar.Text = "Doktorlar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(966, 260);
            label3.Name = "label3";
            label3.Size = new Size(88, 40);
            label3.TabIndex = 2;
            label3.Text = "Tarih:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(974, 372);
            label4.Name = "label4";
            label4.Size = new Size(80, 40);
            label4.TabIndex = 3;
            label4.Text = "Saat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(912, 483);
            label5.Name = "label5";
            label5.Size = new Size(150, 40);
            label5.TabIndex = 4;
            label5.Text = "Hasta Adi:";
            // 
            // cmbBranslar
            // 
            cmbBranslar.FormattingEnabled = true;
            cmbBranslar.Location = new Point(321, 123);
            cmbBranslar.Name = "cmbBranslar";
            cmbBranslar.Size = new Size(454, 48);
            cmbBranslar.TabIndex = 5;
            cmbBranslar.SelectedIndexChanged += cmbBranslar_SelectedIndexChanged;
            // 
            // cmbDoktorlar
            // 
            cmbDoktorlar.FormattingEnabled = true;
            cmbDoktorlar.Location = new Point(1068, 123);
            cmbDoktorlar.Name = "cmbDoktorlar";
            cmbDoktorlar.Size = new Size(454, 48);
            cmbDoktorlar.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(868, 593);
            label1.Name = "label1";
            label1.Size = new Size(194, 40);
            label1.TabIndex = 7;
            label1.Text = "Hasta Soyadi:";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(1068, 254);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(459, 46);
            dtpTarih.TabIndex = 8;
            // 
            // cmbSaat
            // 
            cmbSaat.FormattingEnabled = true;
            cmbSaat.Location = new Point(1073, 364);
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new Size(454, 48);
            cmbSaat.TabIndex = 9;
            // 
            // txtHastaAdi
            // 
            txtHastaAdi.Location = new Point(1073, 477);
            txtHastaAdi.Name = "txtHastaAdi";
            txtHastaAdi.Size = new Size(454, 46);
            txtHastaAdi.TabIndex = 10;
            // 
            // txtHastaSoyadi
            // 
            txtHastaSoyadi.Location = new Point(1073, 587);
            txtHastaSoyadi.Name = "txtHastaSoyadi";
            txtHastaSoyadi.Size = new Size(454, 46);
            txtHastaSoyadi.TabIndex = 11;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(1150, 700);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(317, 83);
            btnRandevuOlustur.TabIndex = 12;
            btnRandevuOlustur.Text = "Randevu Olustur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1735, 875);
            Controls.Add(btnRandevuOlustur);
            Controls.Add(txtHastaSoyadi);
            Controls.Add(txtHastaAdi);
            Controls.Add(cmbSaat);
            Controls.Add(dtpTarih);
            Controls.Add(label1);
            Controls.Add(cmbDoktorlar);
            Controls.Add(cmbBranslar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblDoktorlar);
            Controls.Add(lblBranslar);
            Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBranslar;
        private Label lblDoktorlar;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbBranslar;
        private ComboBox cmbDoktorlar;
        private Label label1;
        private DateTimePicker dtpTarih;
        private ComboBox cmbSaat;
        private TextBox txtHastaAdi;
        private TextBox txtHastaSoyadi;
        private Button btnRandevuOlustur;
    }
}
