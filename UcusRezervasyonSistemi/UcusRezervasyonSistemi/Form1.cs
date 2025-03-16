namespace UcusRezervasyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + "-" + comboBox2.Text + "   Tarih: " + dateTimePicker1.Text + "   Saat: " + maskedTextBox1.Text + "   Yolcu Adi/Soyadi: " + textBox1.Text + "   TC: " + maskedTextBox2.Text + "   Telefon No: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Bilgileri Kaydedildi.");
        }
    }
}
