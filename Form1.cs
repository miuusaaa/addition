using Microsoft.Data.SqlClient;

namespace Adisyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtBoxKullaniciAdi.Text;
            string sifre = txtBoxSifre.Text;

            // Baðlantý dizesini kendi veritabanýna göre deðiþtir
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Adisyon;Trusted_Connection=True;";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                string query = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @kullaniciAdi AND Sifre = @sifre";
                using (SqlCommand komut = new SqlCommand(query, baglanti))
                {
                    komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    int sonuc = (int)komut.ExecuteScalar();

                    if (sonuc > 0)
                    {
                        this.Hide();
                        var yeniform = new Form2();
                        yeniform.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Kullanýcý adý veya þifre yanlýþ.");
                    }
                }
            }
        }
    }
}
