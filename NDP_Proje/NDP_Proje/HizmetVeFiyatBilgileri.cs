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
    public partial class HizmetVeFiyatBilgileri : Form
    {
       
        public HizmetVeFiyatBilgileri()
        {
            InitializeComponent();
        }

        private void HizmetVeFiyatBilgileri_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Hizmet", "Hizmet");
            dataGridView1.Columns.Add("Fiyat", "Fiyat");

            dataGridView1.Rows.Add("Saç Kesimi","50tl");
            dataGridView1.Rows.Add("Saç Boyama","70tl");
            dataGridView1.Rows.Add("Fön","30tl");
            dataGridView1.Rows.Add("Manikür","40tl");
        }
    }
}
