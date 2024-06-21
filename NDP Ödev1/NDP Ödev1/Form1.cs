/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				          NESNEYE DAYALI PROGRAMLAMA DERSİ
**
**				ÖDEV NUMARASI…...: 1
**				ÖĞRENCİ ADI...............: İSMAİL ALPER KARADENİZ
**				ÖĞRENCİ NUMARASI.: B221210065
**				DERS GRUBU…………: B
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NDP_Ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
        }

        private string dosyaYolu = "";
        private void RenkDegistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private bool KaydedilmemisMi()
        {
            if (dosyaYolu != "" && richTextBox1.Text != File.ReadAllText(dosyaYolu))
            {
                DialogResult result = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    dosyaKaydetToolStripMenuItem_Click_1(null, null);
                    return true;
                }
                else if (result == DialogResult.No)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(richTextBox1, e.Location);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        

       

        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KaydedilmemisMi())
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dosyaYolu = openFileDialog.FileName;
                    richTextBox1.Text = File.ReadAllText(dosyaYolu);
                }
            }

        }

        private void DosyaFarkliKaydet()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = saveFileDialog.FileName;
                File.WriteAllText(dosyaYolu, richTextBox1.Text);
            }
        }

        private void dosyaKaydetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dosyaYolu == "")
            {
                DosyaFarkliKaydet();
            }
            else
            {
                File.WriteAllText(dosyaYolu, richTextBox1.Text);
            }

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KaydedilmemisMi())
            {
                Application.Exit();
            }

        }

        private void kesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void yazıÇeşidiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog.Color;
            }
        }

        private void zeminRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog.Color;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
            
        }

        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();

        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();

        }

        private void yazıRengiDeğiştrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen metnin rengini değiştir
                richTextBox1.SelectionColor = colorDialog.Color;
            }

        }

        private void zeminDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog.Color;
            }

        }

        private void yazıTipiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }

        }

        private void renkToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (KaydedilmemisMi())
            {
                DialogResult result = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    dosyaKaydetToolStripMenuItem_Click_1(null, null);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; // İşlemi iptal et, formun kapanmasını engelle
                }
            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
    }
}
