/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3
**				ÖĞRENCİ ADI............: İsmail Alper Karadeniz
**				ÖĞRENCİ NUMARASI.......: B221210065
**                         DERSİN ALINDIĞI GRUP...: B
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NDP_Proje
{
    public partial class RandevuEkle : Form
    {
        Kuafor kuafor;
       
        public RandevuEkle(Kuafor k)
        {
            kuafor = k;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          

            // Örnek bir müşteri oluşturun
            Musteri musteri = new Musteri(textBox1.Text, textBox2.Text, textBox3.Text,textBox4.Text);

            // Örnek bir hizmet oluşturun
            double fiyat = 0;
            string isim = "";
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||string.IsNullOrWhiteSpace(textBox2.Text)||string.IsNullOrWhiteSpace(textBox3.Text)||string.IsNullOrWhiteSpace(textBox4.Text)|| comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Geçmişte bir tarih seçemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(RandevuZamanKontrol(dateTimePicker1.Value.ToShortDateString(),comboBox2.SelectedItem.ToString()))
            {
                MessageBox.Show("Aynı tarih ve saatte bir randevu mevcut", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string secilenhizmet = comboBox1.SelectedItem.ToString();
                if (secilenhizmet != null)
                {


                    if (comboBox1.SelectedItem.ToString() == "Saç Kesimi")
                    {
                        isim = "Saç Kesimi";
                        fiyat = 50;


                    }

                    else if (comboBox1.SelectedItem.ToString() == "Saç Boyama")
                    {
                        isim = "Saç Boyama";
                        fiyat = 70;

                    }

                    else if (comboBox1.SelectedItem.ToString() == "Fön")
                    {
                        isim = "Fön";
                        fiyat = 30;
                    }

                    else if (comboBox1.SelectedItem.ToString() == "Manikür")
                    {
                        isim = "Manikür";
                        fiyat = 40;
                    }





                }
                else
                {
                    // Kullanıcıya bir hizmet seçmesi gerektiğini bildirin
                    MessageBox.Show("Lütfen bir hizmet seçiniz.");
                }


                Hizmet hizmet = new Hizmet(isim, fiyat);
                int n = GetMaxId("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\randevular.txt");
                Randevu.RandevuID = n;


                string tarih = dateTimePicker1.Value.ToShortDateString();
                // Örnek bir randevu oluşturun
                Randevu randevu = new Randevu(tarih,comboBox2.SelectedItem.ToString(), musteri, hizmet);

                // Randevuyu kuaföre ekleyin
                kuafor.EkleVeYaz(randevu);
                MessageBox.Show("Randevu Eklendi");
            }

        }

          

        private void Form3_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            for (int hour = 0; hour < 24; hour++)
            {
                for (int minute = 0; minute < 60; minute += 30)
                {
                    // Saat bilgisini string olarak formatlıyoruz
                    string time = string.Format("{0:D2}:{1:D2}", hour, minute);

                    // Formatlanmış saat bilgisini ComboBox'a ekliyoruz
                    comboBox2.Items.Add(time);
                }
            }
        }

     

        public  int GetMaxId(string filePath)
        {
            int maxId = 0;
            var lines = File.ReadLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (int.TryParse(parts[0], out int id))
                {
                    if (id > maxId)
                    {
                        maxId = id;
                    }
                }
            }

            return maxId;
        }

        private bool RandevuZamanKontrol(string tarih,string saat)
        {
            // Randevular.txt dosyasını oku
            string[] randevular = File.ReadAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\randevular.txt");

            // Her bir randevuyu kontrol et
            foreach (string randevu in randevular)
            {
                // Randevuyu virgüle göre ayır
                string[] parcalar = randevu.Split(',');

                // İlk parça ID'yi temsil eder
               string t = parcalar[1];
                string s = parcalar[2];

                // Eğer girilen ID, bir randevunun ID'siyle eşleşiyorsa, true döndür
                if (tarih == t && saat == s)
                {
                    return true;
                }
            }

            // Eğer hiçbir randevunun ID'si girilen ID ile eşleşmiyorsa, false döndür
            return false;
        }
    }
}
