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
using NDP_Proje;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NDP_Proje
{
    public partial class Form2 : Form
    {
        Kuafor kuafor;
        string[] randevuSatirlari;
       

        public Form2(Kuafor kuafor, string[] randevuSatirlari)
        {
            InitializeComponent();
            this.kuafor = kuafor;
            this.randevuSatirlari = randevuSatirlari;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // DataGridView kontrolünü temizleyin.
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            // 'randevular.txt' dosyasını okuyun ve her satırı bir diziye dönüştürün.
             randevuSatirlari = File.ReadAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\randevular.txt");

            // Sütun başlıklarını manuel olarak ekleyin.
            // Örnek sütun adları: "Tarih", "Saat", "Ad", "Soyad"
            dataGridView2.Columns.Add("ID", "ID");
            dataGridView2.Columns.Add("Tarih", "Tarih");
            dataGridView2.Columns.Add("Saat", "Saat");
            dataGridView2.Columns.Add("Ad", "Ad");
            dataGridView2.Columns.Add("Soyad", "Soyad");
            dataGridView2.Columns.Add("Telefon", "Telefon");
            dataGridView2.Columns.Add("Email", "Email");
            dataGridView2.Columns.Add("Hizmet", "Hizmet");
            dataGridView2.Columns.Add("Ücret", "Ücret");
           

            // Diğer sütun başlıklarını da benzer şekilde ekleyebilirsiniz.

            // Her satır için bir DataGridViewRow oluşturun ve DataGridView'e ekleyin.
            foreach (string satir in randevuSatirlari)
            {
                string[] veriler = satir.Split(',');
                dataGridView2.Rows.Add(veriler);
               
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


      
       
    }
}



