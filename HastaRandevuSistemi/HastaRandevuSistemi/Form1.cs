using System.Diagnostics;
using HastaRandevuSistemi.Models;
using Microsoft.Data.SqlClient;

namespace HastaRandevuSistemi
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=YOUR_SERVER;Database=YOUR_DB;User Id=YOUR_USER;Password=YOUR_PASSWORD;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BranslariDoldur();
            SaatleriDoldur();
        }

        public void BranslariDoldur()
        {
            List<Brans> branslar = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sorgu = "SELECT * FROM Branslar";
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    branslar = new List<Brans>();
                    branslar.Clear();
                    branslar.Add(new Brans
                    {
                        Id = 0,
                        BransAdi = "Brans Seciniz"
                    });

                    while (reader.Read())
                    {
                        branslar.Add(new Brans
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            BransAdi = (string)reader["BransAdi"]
                        });
                    }

                    cmbBranslar.DataSource = branslar;
                    cmbBranslar.DisplayMember = "BransAdi";
                    cmbBranslar.ValueMember = "Id";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                finally
                {
                    connection.Close();
                }
            }
        }

        private void cmbBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBranslar.SelectedValue is int BransId)
            {
                List<Doktor> doktorlar = null;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string sorgu = "SELECT * FROM Doktorlar WHERE BransId = @BransId";
                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@BransId", BransId);
                        SqlDataReader reader = command.ExecuteReader();

                        doktorlar = new List<Doktor>();
                        doktorlar.Clear();
                        doktorlar.Add(new Doktor
                        {
                            Id = 0,
                            DoktorAdi = "Doktor Seciniz"
                        });

                        while (reader.Read())
                        {
                            doktorlar.Add(new Doktor
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                DoktorAdi = (string)reader["DoktorAdi"],
                                DoktorSoyadi = (string)reader["DoktorSoyadi"],
                                BransId = Convert.ToInt32(reader["BransId"])
                            });
                        }

                        cmbDoktorlar.DataSource = doktorlar;
                        cmbDoktorlar.DisplayMember = "TamAd";
                        cmbDoktorlar.ValueMember = "Id";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        private void SaatleriDoldur()
        {
            cmbSaat.Items.Clear();
            string[] saatler = { "09:00", "10:00", "11:00", "13:00", "14:00", "15:00" };
            cmbSaat.Items.AddRange(saatler);
            cmbSaat.SelectedIndex = 0;
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {

            if (cmbBranslar.SelectedIndex <= 0 || cmbDoktorlar.SelectedIndex <= 0 ||
                string.IsNullOrWhiteSpace(txtHastaAdi.Text) ||
                string.IsNullOrWhiteSpace(txtHastaSoyadi.Text) ||
                cmbSaat.SelectedItem == null)
            {
                MessageBox.Show("Lutfen Tum Alanlari Doldurunuz!!");
                return;
            }

            int bransId = (int)cmbBranslar.SelectedValue;
            int doktorId = (int)cmbDoktorlar.SelectedValue;
            string hastaAdi = txtHastaAdi.Text.Trim();
            string hastaSoyadi = txtHastaSoyadi.Text.Trim();

            DateTime secilenTarih = dtpTarih.Value.Date;
            TimeSpan secilenSaat = TimeSpan.Parse(cmbSaat.SelectedItem.ToString());
            DateTime randevuTarihi = secilenTarih.Add(secilenSaat);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string kontrolSorgusu = "SELECT COUNT(*) FROM Randevular WHERE DoktorID = @DoktorID AND Tarih = @Tarih";
                    SqlCommand kontrolKomutu = new SqlCommand(kontrolSorgusu, connection);
                    kontrolKomutu.Parameters.AddWithValue("@DoktorID", doktorId);
                    kontrolKomutu.Parameters.AddWithValue("@Tarih", randevuTarihi);
                    int sonuc = (int)kontrolKomutu.ExecuteScalar();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Bu Randevu saati doldudur. Lutfen baska bir gun veya saat seciniz!!");
                        return;
                    }

                    string eklemeSorgusu = @"INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih)
                                     VALUES (@HastaAdi, @HastaSoyadi, @BransID, @DoktorID, @Tarih)";
                    SqlCommand eklemeKomutu = new SqlCommand(eklemeSorgusu, connection);
                    eklemeKomutu.Parameters.AddWithValue("@HastaAdi", hastaAdi);
                    eklemeKomutu.Parameters.AddWithValue("@HastaSoyadi", hastaSoyadi);
                    eklemeKomutu.Parameters.AddWithValue("@BransID", bransId);
                    eklemeKomutu.Parameters.AddWithValue("@DoktorID", doktorId);
                    eklemeKomutu.Parameters.AddWithValue("@Tarih", randevuTarihi);

                    int kayitSonucu = eklemeKomutu.ExecuteNonQuery();

                    if (kayitSonucu > 0)
                    {
                        MessageBox.Show("Randevu Olusturuldu!");

                        txtHastaAdi.Clear();
                        txtHastaSoyadi.Clear();
                        cmbBranslar.SelectedIndex = 0;
                        cmbDoktorlar.DataSource = null;
                        cmbSaat.SelectedIndex = 0;
                        dtpTarih.Value = DateTime.Now;

                    }
                    else
                    {
                        MessageBox.Show("Randevu Olusturulamadi. Lutfen tekrar deneyiniz!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

    }
}
