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
    public partial class PersonelListesi : Form
    {
        Kuafor kuafor;
        string[] personelSatirlari;
        public PersonelListesi(Kuafor kuafor, string[]personelSatirlari)
        {
            InitializeComponent();
            this.kuafor = kuafor;
            this.personelSatirlari = personelSatirlari;
        }

        private void PersonelListesi_Load(object sender, EventArgs e)
        {
            // DataGridView kontrolünü temizleyin.
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // 'randevular.txt' dosyasını okuyun ve her satırı bir diziye dönüştürün.
            personelSatirlari = File.ReadAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\personel.txt");

            // Sütun başlıklarını manuel olarak ekleyin.
            // Örnek sütun adları: "Tarih", "Saat", "Ad", "Soyad"

            dataGridView1.Columns.Add("PersonelID", "PersonelID");
            dataGridView1.Columns.Add("Ad", "Ad");
            dataGridView1.Columns.Add("Soyad", "Soyad");
            dataGridView1.Columns.Add("Telefon", "Telefon");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Pozisyon", "Pozisyon");
          


            // Diğer sütun başlıklarını da benzer şekilde ekleyebilirsiniz.

            // Her satır için bir DataGridViewRow oluşturun ve DataGridView'e ekleyin.
            foreach (string satir in personelSatirlari)
            {
                string[] veriler = satir.Split(',');
                dataGridView1.Rows.Add(veriler);
            }
        }
    }
}
