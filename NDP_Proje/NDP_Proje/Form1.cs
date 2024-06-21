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

namespace NDP_Proje
{
    public partial class Form1 : Form
    {
        Kuafor kuafor;
        Personel personel;
        string[] randevuSatirlari;
        string[] personelSatirlari;
        private string placeholderText1 = "RandevuID giriniz";
        private string placeholderText2 = "PersonelID giriniz";
        public Form1()
        {
            InitializeComponent();
            kuafor = new Kuafor("a","b","c","d");
            personel = new Personel("a", "b", "c", "d", "e");
            InitializePlaceholder(textBox1, placeholderText1);
            InitializePlaceholder(textBox2, placeholderText1);

            InitializePlaceholder(textBox3, placeholderText2);
            InitializePlaceholder(textBox4, placeholderText2);
        }

        private void InitializePlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = System.Drawing.Color.Gray;

            textBox.Enter += (sender, e) => RemovePlaceholder(sender, e, placeholderText);
            textBox.Leave += (sender, e) => SetPlaceholder(sender, e, placeholderText);
        }

        private void RemovePlaceholder(object sender, EventArgs e, string placeholderText)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == placeholderText)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e, string placeholderText)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
             randevuSatirlari = File.ReadAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\randevular.txt");
             personelSatirlari = File.ReadAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\personel.txt");

        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            RandevuEkle f = new RandevuEkle(kuafor);
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
           
            Form2 f = new Form2(kuafor,randevuSatirlari);
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = -1;
            bool isNumeric = int.TryParse(textBox1.Text, out a);
            if (!isNumeric || a <= 0)
            {
                MessageBox.Show("Lütfen 0'dan büyük bir tam sayı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!RandevuIDKontrol(Convert.ToInt32(textBox1.Text)))
            {
                MessageBox.Show("RandevuID bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Form4 f4 = new Form4(Convert.ToInt32(textBox1.Text), kuafor);
                f4.ShowDialog();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = -1;
            bool isNumeric = int.TryParse(textBox2.Text, out a);
            if (!isNumeric|| a <=0)
            {
                MessageBox.Show("Lütfen 0'dan büyük bir tam sayı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(!RandevuIDKontrol(Convert.ToInt32(textBox2.Text)))
            {
                MessageBox.Show("RandevuID bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
 
            else
            {
                kuafor.Sil(Convert.ToInt32(textBox2.Text));
                MessageBox.Show("Randevu Silindi");
            }

            
        }

        private bool RandevuIDKontrol(int id)
        {
            // Randevular.txt dosyasını oku
            string[] randevular = File.ReadAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\randevular.txt");

            // Her bir randevuyu kontrol et
            foreach (string randevu in randevular)
            {
                // Randevuyu virgüle göre ayır
                string[] parcalar = randevu.Split(',');

                // İlk parça ID'yi temsil eder
                int randevuID = int.Parse(parcalar[0]);

                // Eğer girilen ID, bir randevunun ID'siyle eşleşiyorsa, true döndür
                if (id == randevuID)
                {
                    return true;
                }
            }

            // Eğer hiçbir randevunun ID'si girilen ID ile eşleşmiyorsa, false döndür
            return false;
        }


        private bool PersonelIDKontrol(int id)
        {
            // Randevular.txt dosyasını oku
            string[] personeller = File.ReadAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\personel.txt");

            // Her bir randevuyu kontrol et
            foreach (string personel in personeller)
            {
                // Randevuyu virgüle göre ayır
                string[] parcalar = personel.Split(',');

                // İlk parça ID'yi temsil eder
                int personelID = int.Parse(parcalar[0]);

                // Eğer girilen ID, bir randevunun ID'siyle eşleşiyorsa, true döndür
                if (id == personelID)
                {
                    return true;
                }
            }

            // Eğer hiçbir randevunun ID'si girilen ID ile eşleşmiyorsa, false döndür
            return false;
        }



        private void button6_Click(object sender, EventArgs e)
        {
            PersonelEkle f = new PersonelEkle(personel);
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PersonelListesi f = new PersonelListesi(kuafor,personelSatirlari);
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a = -1;
            bool isNumeric = int.TryParse(textBox4.Text, out a);
            if (!isNumeric || a <= 0)
            {
                MessageBox.Show("Lütfen 0'dan büyük bir tam sayı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!PersonelIDKontrol(Convert.ToInt32(textBox4.Text)))
            {
                MessageBox.Show("personelID bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                PersonelGüncelle f = new PersonelGüncelle(personel,Convert.ToInt32(textBox4.Text));
                f.ShowDialog();
            }




         
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = -1;
            bool isNumeric = int.TryParse(textBox3.Text, out a);
            if (!isNumeric || a <= 0)
            {
                MessageBox.Show("Lütfen 0'dan büyük bir tam sayı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!PersonelIDKontrol(Convert.ToInt32(textBox3.Text)))
            {
                MessageBox.Show("PersonelID bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                personel.Sil(Convert.ToInt32(textBox3.Text));
                MessageBox.Show("Personel Silindi");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HizmetVeFiyatBilgileri f = new HizmetVeFiyatBilgileri();
            f.ShowDialog();
        }
    }
}
