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
    public partial class Form4 : Form
    {
        Kuafor kuafor;
        private int randevuID;
       
        public Form4(int id,Kuafor kuafor)
        {
            InitializeComponent();
            randevuID = id;
            this.kuafor = kuafor;   
        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Geçmişte bir tarih seçemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (RandevuZamanKontrol(dateTimePicker1.Value.ToShortDateString(), comboBox2.SelectedItem.ToString(),randevuID))
            {
                MessageBox.Show("Aynı tarih ve saatte bir randevu mevcut", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                double fiyat = 0;
                string isim = "";

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
                string tarih = dateTimePicker1.Value.ToShortDateString();

                kuafor.RandevuGuncelle(randevuID, tarih,comboBox2.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, isim, fiyat);
                MessageBox.Show("Randevu Güncellendi");
            }
          
        }

        private bool RandevuZamanKontrol(string tarih, string saat,int ID)
        {
            // Randevular.txt dosyasını oku
            string[] randevular = File.ReadAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\randevular.txt");

            // Her bir randevuyu kontrol et
            foreach (string randevu in randevular)
            {
                // Randevuyu virgüle göre ayır
                string[] parcalar = randevu.Split(',');

                // İlk parça ID'yi temsil eder
                int ıd = int.Parse(parcalar[0]);
                string t = parcalar[1];
                string s = parcalar[2];
                if (ıd == ID) continue;


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
