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
    public partial class PersonelEkle : Form
    {
        Personel personel;
        public PersonelEkle(Personel personel)
        {
            InitializeComponent();
           this.personel = personel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text)|| string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int n = GetMaxId("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\personel.txt");
                Personel.PersonelID = n;
                Personel personel = new Personel(textBox1.Text,textBox2.Text, textBox3.Text,textBox4.Text,textBox5.Text);

                personel.EkleVeYaz(personel);
                MessageBox.Show("Personel Eklendi");

            }
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {

        }

        public int GetMaxId(string filePath)
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

    }
}
