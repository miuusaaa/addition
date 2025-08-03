using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adisyon
{
    public partial class Form2 : Form
    {
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable currentTable = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dt1.Columns.Add("Ürün:", typeof(string));
            dt1.Columns.Add("Fiyat:", typeof(double));
            dt2.Columns.Add("Ürün:", typeof(string));
            dt2.Columns.Add("Fiyat:", typeof(double));
            dt3.Columns.Add("Ürün:", typeof(string));
            dt3.Columns.Add("Fiyat:", typeof(double));
            dt4.Columns.Add("Ürün:", typeof(string));
            dt4.Columns.Add("Fiyat:", typeof(double));
            Dtgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dtgrid.AllowUserToAddRows = false;
            Dtgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dtgrid.MultiSelect = true; // Birden fazla satır seçmeyi aktif et




        }

        bool masasecildi = false;
        Dictionary<DataTable, bool> hesapKesildi = new Dictionary<DataTable, bool>();

        double masa1toplam = 0, masa2toplam = 0, masa3toplam = 0, masa4toplam = 0;

        private void BtnMasa1_Click(object sender, EventArgs e)
        {
            currentTable = dt1; // Önce currentTable'ı doğru ata

            // Sözlükte anahtar yoksa varsayılan olarak false ata
            if (!hesapKesildi.ContainsKey(currentTable))
            {
                hesapKesildi[currentTable] = false;
            }

            bool durum = hesapKesildi[currentTable];

            // Arayüz güncellemeleri
            BtnMasa1.BackColor = Color.BlueViolet;
            BtnMasa2.BackColor = DefaultBackColor;
            BtnMasa3.BackColor = DefaultBackColor;
            BtnMasa4.BackColor = DefaultBackColor;

            Dtgrid.DataSource = dt1;
            Dtgrid.ClearSelection(); // Seçimleri temizle

            if (durum)
            {
                LblTutar.Text = $"Hesap Kesildi\nTutar : {masa1toplam.ToString("C2")}"; // Örn: ₺123,45
               
            }
            else
            {
                LblTutar.Text = "Sipariş alınıyor.";
               
            }

            masasecildi = true;
        }

        private void BtnMasa2_Click(object sender, EventArgs e)
        {
            currentTable = dt2; // Önce currentTable'ı doğru ata

            // Sözlükte anahtar yoksa varsayılan olarak false ata
            if (!hesapKesildi.ContainsKey(currentTable))
            {
                hesapKesildi[currentTable] = false;
            }

            bool durum = hesapKesildi[currentTable];

            // Arayüz güncellemeleri
            BtnMasa1.BackColor = DefaultBackColor;
            BtnMasa2.BackColor = Color.BlueViolet;
            BtnMasa3.BackColor = DefaultBackColor;
            BtnMasa4.BackColor = DefaultBackColor;

            Dtgrid.DataSource = dt2;
            Dtgrid.ClearSelection(); // Seçimleri temizle

            if (durum)
            {
                LblTutar.Text = $"Hesap Kesildi\nTutar : {masa2toplam.ToString("C2")}"; // Örn: ₺123,45

            }
            else
            {
                LblTutar.Text = "Sipariş alınıyor.";

            }

            masasecildi = true;
        }



        private void BtnMasa3_Click(object sender, EventArgs e)
        {
            currentTable = dt3; // Önce currentTable'ı doğru ata

            // Sözlükte anahtar yoksa varsayılan olarak false ata
            if (!hesapKesildi.ContainsKey(currentTable))
            {
                hesapKesildi[currentTable] = false;
            }

            bool durum = hesapKesildi[currentTable];

            // Arayüz güncellemeleri
            BtnMasa1.BackColor = DefaultBackColor;
            BtnMasa2.BackColor = DefaultBackColor;
            BtnMasa3.BackColor = Color.BlueViolet;
            BtnMasa4.BackColor = DefaultBackColor;

            Dtgrid.DataSource = dt3;
            Dtgrid.ClearSelection(); // Seçimleri temizle

            if (durum)
            {
                LblTutar.Text = $"Hesap Kesildi\nTutar : {masa3toplam.ToString("C2")}"; // Örn: ₺123,45
            }
            else
            {

                LblTutar.Text = "Sipariş alınıyor.";

            }

            masasecildi = true;
        }

        private void BtnMasa4_Click(object sender, EventArgs e)
        {
            currentTable = dt4; // Önce currentTable'ı doğru ata

            // Sözlükte anahtar yoksa varsayılan olarak false ata
            if (!hesapKesildi.ContainsKey(currentTable))
            {
                hesapKesildi[currentTable] = false;
            }

            bool durum = hesapKesildi[currentTable];

            // Arayüz güncellemeleri
            BtnMasa1.BackColor = DefaultBackColor;
            BtnMasa2.BackColor = DefaultBackColor;
            BtnMasa3.BackColor = DefaultBackColor;
            BtnMasa4.BackColor = Color.BlueViolet;

            Dtgrid.DataSource = dt4;
            Dtgrid.ClearSelection(); // Seçimleri temizle

            if (durum)
            {
                LblTutar.Text = $"Hesap Kesildi\nTutar : {masa4toplam.ToString("C2")}";

            }
            else
            {
                LblTutar.Text = "Sipariş alınıyor.";
            }

            masasecildi = true;
        }


        private void BtnSu_Click(object sender, EventArgs e)
        {
            if (!masasecildi)
            {
                MessageBox.Show("Lütfen bir masa seçin.");
                return;

            }

            else if (hesapKesildi[currentTable]== true)
            {
                MessageBox.Show("Hesap kesildğinden ürün eklenemez.");
                return;
            }
            else if (currentTable == dt1)
            {
                dt1.Rows.Add("Su", 5);
                Dtgrid.DataSource = dt1;
                Dtgrid.Refresh();
                masa1toplam += 5;
            }
            else if (currentTable == dt2)
            {
                dt2.Rows.Add("Su", 5);
                Dtgrid.DataSource = dt2;
                Dtgrid.Refresh();
                masa2toplam += 5;
            }
            else if (currentTable == dt3)
            {
                dt3.Rows.Add("Su", 5);
                Dtgrid.DataSource = dt3;
                Dtgrid.Refresh();
                masa3toplam += 5;
            }
            else
            {
                dt4.Rows.Add("Su", 5);
                Dtgrid.DataSource = dt4;
                Dtgrid.Refresh();
                masa4toplam += 5;
            }

        }
        private void BtnCay_Click(object sender, EventArgs e)
        {
            if (!masasecildi)
            {
                MessageBox.Show("Lütfen bir masa seçin.");
                return;
            }

            else if (hesapKesildi[currentTable] == true)
            {
                MessageBox.Show("Hesap kesildğinden ürün eklenemez.");
                return;
            }

            else if (currentTable == dt1)
            {
                dt1.Rows.Add("Çay", 7.5);
                Dtgrid.DataSource = dt1;
                Dtgrid.Refresh();
                masa1toplam += 7.5;
            }
            else if (currentTable == dt2)
            {
                dt2.Rows.Add("Çay", 7.5);
                Dtgrid.DataSource = dt2;
                Dtgrid.Refresh();
                masa2toplam += 7.5;
            }

            else if (currentTable == dt3)
            {
                dt3.Rows.Add("Çay", 7.5);
                Dtgrid.DataSource = dt3;
                Dtgrid.Refresh();
                masa3toplam += 7.5;
            }
            else
            {
                dt4.Rows.Add("Çay", 7.5);
                Dtgrid.DataSource = dt4;
                Dtgrid.Refresh();
                masa4toplam += 7.5;
            }
        }

        private void BtnKahve_Click(object sender, EventArgs e)
        {
            if (!masasecildi)
            {
                MessageBox.Show("Lütfen bir masa seçin.");
                return;
            }

            else if (hesapKesildi[currentTable] == true)
            {
                MessageBox.Show("Hesap kesildğinden ürün eklenemez.");
                return;
            }

            else if (currentTable == dt1)
            {
                dt1.Rows.Add("Kahve", 8);
                Dtgrid.DataSource = dt1;
                Dtgrid.Refresh();
                masa1toplam += 8;
            }
            else if (currentTable == dt2)
            {
                dt2.Rows.Add("Kahve", 8);
                Dtgrid.DataSource = dt2;
                Dtgrid.Refresh();
                masa2toplam += 8;
            }
            else if (currentTable == dt3)
            {
                dt3.Rows.Add("Kahve", 8);
                Dtgrid.DataSource = dt3;
                Dtgrid.Refresh();
                masa3toplam += 8;
            }
            else
            {
                dt4.Rows.Add("Kahve", 8);
                Dtgrid.DataSource = dt4;
                Dtgrid.Refresh();
                masa4toplam += 8;
            }
        }

        private void BtnKola_Click(object sender, EventArgs e)
        {
            if (!masasecildi)
            {
                MessageBox.Show("Lütfen bir masa seçin.");
                return;
            }

            else if (hesapKesildi[currentTable] == true)
            {
                MessageBox.Show("Hesap kesildğinden ürün eklenemez.");
                return;
            }

            else if (currentTable == dt1)
            {
                dt1.Rows.Add("Kola", 10);
                Dtgrid.DataSource = dt1;
                Dtgrid.Refresh();
                masa1toplam += 10;
            }
            else if (currentTable == dt2)
            {
                dt2.Rows.Add("Kola", 10);
                Dtgrid.DataSource = dt2;
                Dtgrid.Refresh();
                masa2toplam += 10;
            }
            else if (currentTable == dt3)
            {
                dt3.Rows.Add("Kola", 10);
                Dtgrid.DataSource = dt3;
                Dtgrid.Refresh();
                masa3toplam += 10;
            }
            else
            {
                dt4.Rows.Add("Kola", 10);
                Dtgrid.DataSource = dt4;
                Dtgrid.Refresh();
                masa4toplam += 10;
            }
        }
        private void BtnAyran_Click(object sender, EventArgs e)
        {
            if (!masasecildi)
            {
                MessageBox.Show("Lütfen bir masa seçin.");
                return;
            }

            else if (hesapKesildi[currentTable] == true)
            {
                MessageBox.Show("Hesap kesildğinden ürün eklenemez.");
                return;
            }

            else if (currentTable == dt1)
            {
                dt1.Rows.Add("Ayran", 6);
                Dtgrid.DataSource = dt1;
                Dtgrid.Refresh();
                masa1toplam += 6;
            }
            else if (currentTable == dt2)
            {
                dt2.Rows.Add("Ayran", 6);
                Dtgrid.DataSource = dt2;
                Dtgrid.Refresh();
                masa2toplam += 6;
            }
            else if (currentTable == dt3)
            {
                dt3.Rows.Add("Ayran", 6);
                Dtgrid.DataSource = dt3;
                Dtgrid.Refresh();
                masa3toplam += 6;
            }
            else
            {
                dt4.Rows.Add("Ayran", 6);
                Dtgrid.DataSource = dt4;
                Dtgrid.Refresh();
                masa4toplam += 6;
            }
        }
        private void BtnLimonata_Click(object sender, EventArgs e)
        {
            if (!masasecildi)
            {
                MessageBox.Show("Lütfen bir masa seçin.");
                return;
            }

            else if (hesapKesildi[currentTable] == true)
            {
                MessageBox.Show("Hesap kesildğinden ürün eklenemez.");
                return;
            }

            else if (currentTable == dt1)
            {
                dt1.Rows.Add("Limonata", 15);
                Dtgrid.DataSource = dt1;
                Dtgrid.Refresh();
                masa1toplam += 15;
            }
            else if (currentTable == dt2)
            {
                dt2.Rows.Add("Limonata", 15);
                Dtgrid.DataSource = dt2;
                Dtgrid.Refresh();
                masa2toplam += 15;
            }
            else if (currentTable == dt3)
            {
                dt3.Rows.Add("Limonata", 15);
                Dtgrid.DataSource = dt3;
                Dtgrid.Refresh();
                masa3toplam += 15;
            }
            else
            {
                dt4.Rows.Add("Limonata", 15);
                Dtgrid.DataSource = dt4;
                Dtgrid.Refresh();
                masa4toplam += 15;
            }
        }
        private void BtnIhlamur_Click(object sender, EventArgs e)
        {
            if (!masasecildi)
            {
                MessageBox.Show("Lütfen bir masa seçin.");
                return;
            }

            else if (hesapKesildi[currentTable] == true)
            {
                MessageBox.Show("Hesap kesildğinden ürün eklenemez.");
                return;
            }


            else if (hesapKesildi[currentTable] == true)
            {
                MessageBox.Show("Hesap kesildiğinden ürün ekleme yapılamaz");
            }

            else if (currentTable == dt1)
            {
                dt1.Rows.Add("Ihlamur", 20);
                Dtgrid.DataSource = dt1;
                Dtgrid.Refresh();
                masa1toplam += 20;
            }
            else if (currentTable == dt2)
            {
                dt2.Rows.Add("Ihlamur", 20);
                Dtgrid.DataSource = dt2;
                Dtgrid.Refresh();
                masa2toplam += 20;
            }
            else if (currentTable == dt3)
            {
                dt3.Rows.Add("Ihlamur", 20);
                Dtgrid.DataSource = dt3;
                Dtgrid.Refresh();
                masa3toplam += 20;
            }
            else
            {
                dt4.Rows.Add("Ihlamur", 20);
                Dtgrid.DataSource = dt4;
                Dtgrid.Refresh();
                masa4toplam += 20;
            }
        }
        private void BtnSalep_Click(object sender, EventArgs e)
        {
            if (!masasecildi)
            {
                MessageBox.Show("Lütfen bir masa seçin.");
                return;
            }

            else if (hesapKesildi[currentTable] == true)
            {
                MessageBox.Show("Hesap kesildğinden ürün eklenemez.");
                return;
            }

            else if (currentTable == dt1)
            {
                dt1.Rows.Add("Salep", 25.75);
                Dtgrid.DataSource = dt1;
                Dtgrid.Refresh();
                masa1toplam += 25.75;
            }
            else if (currentTable == dt2)
            {
                dt2.Rows.Add("Salep", 25.75);
                Dtgrid.DataSource = dt2;
                Dtgrid.Refresh();
                masa2toplam += 25.75;
            }

            else if (currentTable == dt3)
            {
                dt3.Rows.Add("Salep", 25.75);
                Dtgrid.DataSource = dt3;
                Dtgrid.Refresh();
                masa3toplam += 25.75;
            }
            else
            {
                dt4.Rows.Add("Salep", 25.75);
                Dtgrid.DataSource = dt4;
                Dtgrid.Refresh();
                masa4toplam += 25.75;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (!masasecildi)
            {
                MessageBox.Show("Lütfen bir masa seçin.");
                return;
            }

            else if (hesapKesildi[currentTable] == true)
            {
                MessageBox.Show("Hesap kesildğinden ürün eklenemez.");
                return;
            }

            else if (currentTable == dt1)
            {
                if (Dtgrid.SelectedRows.Count > 0)
                {
                    DataTable dt = (DataTable)Dtgrid.DataSource; // DataTable referansını al

                    // Seçili satırların ID'lerini önce bir listeye al
                    List<int> selectedIndexes = new List<int>();

                    foreach (DataGridViewRow row in Dtgrid.SelectedRows)
                    {
                        selectedIndexes.Add(row.Index); // Seçili satırların indekslerini sakla
                    }

                    // Seçili satırları **baştan sona değil, sondan başa doğru** silmelisin.
                    selectedIndexes.Sort();  // İndeksleri sıralıyoruz
                    selectedIndexes.Reverse(); // **Sondan başa doğru** silmek için ters çeviriyoruz

                    foreach (int rowIndex in selectedIndexes)
                    {
                        if (rowIndex >= 0 && rowIndex < dt.Rows.Count) // Geçerli bir indeks mi?
                        {
                            double fiyat = Convert.ToDouble(dt.Rows[rowIndex]["Fiyat:"]);
                            masa1toplam -= fiyat; // 🔧 TOPLAMDAN DÜŞ

                            dt.Rows[rowIndex].Delete(); // Satırı sil

                        }
                    }

                    dt.AcceptChanges(); // **Tüm silme işlemleri tamamlandıktan sonra** değişiklikleri uygula
                }
                else
                {
                    MessageBox.Show("Lütfen sipariş kısmından bir ürün seçin.");
                }

                Dtgrid.DataSource = dt1;
                Dtgrid.Refresh();
            }
            else if (currentTable == dt2)
            {
                if (Dtgrid.SelectedRows.Count > 0)
                {
                    DataTable dt = (DataTable)Dtgrid.DataSource;


                    List<int> selectedIndexes = new List<int>();

                    foreach (DataGridViewRow row in Dtgrid.SelectedRows)
                    {
                        selectedIndexes.Add(row.Index);
                    }


                    selectedIndexes.Sort();
                    selectedIndexes.Reverse();

                    foreach (int rowIndex in selectedIndexes)
                    {
                        if (rowIndex >= 0 && rowIndex < dt.Rows.Count) // Geçerli bir indeks mi?
                        {
                            double fiyat = Convert.ToDouble(dt.Rows[rowIndex]["Fiyat:"]);
                            masa2toplam -= fiyat; // 🔧 TOPLAMDAN DÜŞ

                            dt.Rows[rowIndex].Delete(); // Satırı sil
                        }
                    }

                    dt.AcceptChanges(); // **Tüm silme işlemleri tamamlandıktan sonra** değişiklikleri uygula
                }
                else
                {
                    MessageBox.Show("Lütfen sipariş kısmından bir ürün seçin.");
                }

                Dtgrid.DataSource = dt2;
                Dtgrid.Refresh();
            }

            else if (currentTable == dt3)
            {
                if (Dtgrid.SelectedRows.Count > 0)
                {
                    DataTable dt = (DataTable)Dtgrid.DataSource; // DataTable referansını al

                    // Seçili satırların ID'lerini önce bir listeye al
                    List<int> selectedIndexes = new List<int>();

                    foreach (DataGridViewRow row in Dtgrid.SelectedRows)
                    {
                        selectedIndexes.Add(row.Index); // Seçili satırların indekslerini sakla
                    }

                    // Seçili satırları **baştan sona değil, sondan başa doğru** silmelisin.
                    selectedIndexes.Sort();  // İndeksleri sıralıyoruz
                    selectedIndexes.Reverse(); // **Sondan başa doğru** silmek için ters çeviriyoruz

                    foreach (int rowIndex in selectedIndexes)
                    {
                        if (rowIndex >= 0 && rowIndex < dt.Rows.Count) // Geçerli bir indeks mi?
                        {
                            double fiyat = Convert.ToDouble(dt.Rows[rowIndex]["Fiyat:"]);
                            masa3toplam -= fiyat; // 🔧 TOPLAMDAN DÜŞ

                            dt.Rows[rowIndex].Delete(); // Satırı sil
                        }
                    }

                    dt.AcceptChanges(); // **Tüm silme işlemleri tamamlandıktan sonra** değişiklikleri uygula
                }
                else
                {
                    MessageBox.Show("Lütfen sipariş kısmından bir ürün seçin.");
                }

                Dtgrid.DataSource = dt3;
                Dtgrid.Refresh();
            }
            else
            {
                if (Dtgrid.SelectedRows.Count > 0)
                {
                    DataTable dt = (DataTable)Dtgrid.DataSource; // DataTable referansını al

                    // Seçili satırların ID'lerini önce bir listeye al
                    List<int> selectedIndexes = new List<int>();

                    foreach (DataGridViewRow row in Dtgrid.SelectedRows)
                    {
                        selectedIndexes.Add(row.Index); // Seçili satırların indekslerini sakla
                    }

                    // Seçili satırları **baştan sona değil, sondan başa doğru** silmelisin.
                    selectedIndexes.Sort();  // İndeksleri sıralıyoruz
                    selectedIndexes.Reverse(); // **Sondan başa doğru** silmek için ters çeviriyoruz

                    foreach (int rowIndex in selectedIndexes)
                    {
                        if (rowIndex >= 0 && rowIndex < dt.Rows.Count) // Geçerli bir indeks mi?
                        {
                            double fiyat = Convert.ToDouble(dt.Rows[rowIndex]["Fiyat:"]);
                            masa4toplam -= fiyat; // 🔧 TOPLAMDAN DÜŞ

                            dt.Rows[rowIndex].Delete(); // Satırı sil

                        }
                    }

                    dt.AcceptChanges(); // **Tüm silme işlemleri tamamlandıktan sonra** değişiklikleri uygula
                }
                else
                {
                    MessageBox.Show("Lütfen sipariş kısmından bir ürün seçin.");
                }

                Dtgrid.DataSource = dt4;
                Dtgrid.Refresh();
            }
        }

        private void BtnHesap_Click(object sender, EventArgs e)
        {
            if (!masasecildi)
            {
                MessageBox.Show("Lütfen hesabını kesmek istediğiniz masayı seçin.");
            }

            else if (currentTable.Rows.Count == 0)
            {
                MessageBox.Show("Masada herhangi bir ürün yok. Hesap kesilemez!");
                return;
            }
            
            else if (currentTable == dt1)
            {
                LblTutar.Text = $"Hesap Kesildi\nTutar : {masa1toplam.ToString("C2")}";
            }
            else if (currentTable == dt2)
            {
                LblTutar.Text = $"Hesap Kesildi\nTutar : {masa2toplam.ToString("C2")}";
            }
            else if (currentTable == dt3)
            {
                LblTutar.Text = $"Hesap Kesildi\nTutar : {masa3toplam.ToString("C2")}";
            }
            else
            {
                LblTutar.Text = $"Hesap Kesildi\nTutar : {masa4toplam.ToString("C2")}";
            }

            hesapKesildi[currentTable] = true;
        }

        private void btnOdendi_Click(object sender, EventArgs e)
        {
            if (!masasecildi)
            {
                MessageBox.Show("Lütfen bir masa seçin !");
                return;
            }

            if (!hesapKesildi.ContainsKey(currentTable) || !hesapKesildi[currentTable])
            {
                MessageBox.Show("Lütfen masanın hesabını kesin !");
                return;
            }

            // Ödeme işlemi
            if (currentTable == dt1)
            {
                masa1toplam = 0;
                dt1.Clear();
            }
            else if (currentTable == dt2)
            {
                masa2toplam = 0;
                dt2.Clear();
            }
            else if (currentTable == dt3)
            {
                masa3toplam = 0;
                dt3.Clear();
            }
            else if (currentTable == dt4)
            {
                masa4toplam = 0;
                dt4.Clear();
            }

            LblTutar.Text = "";
            hesapKesildi[currentTable] = false;  // Hesap ödendi, tekrar aktif olsun

            MessageBox.Show("Ödeme alındı, teşekkürler!");

            LblTutar.Text = "Sipariş alınıyor.";
        }

       
    }
}

    
