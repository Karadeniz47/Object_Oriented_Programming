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

namespace NDP_Ödev1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biçimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeminRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıÇeşidiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıRengiDeğiştrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeminDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(788, 237);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.biçimToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaAçToolStripMenuItem,
            this.dosyaKaydetToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            this.dosyaToolStripMenuItem.Click += new System.EventHandler(this.dosyaToolStripMenuItem_Click);
            // 
            // dosyaAçToolStripMenuItem
            // 
            this.dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            this.dosyaAçToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dosyaAçToolStripMenuItem.Text = "Dosya Aç";
            this.dosyaAçToolStripMenuItem.Click += new System.EventHandler(this.dosyaAçToolStripMenuItem_Click);
            // 
            // dosyaKaydetToolStripMenuItem
            // 
            this.dosyaKaydetToolStripMenuItem.Name = "dosyaKaydetToolStripMenuItem";
            this.dosyaKaydetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dosyaKaydetToolStripMenuItem.Text = "Dosya Kaydet";
            this.dosyaKaydetToolStripMenuItem.Click += new System.EventHandler(this.dosyaKaydetToolStripMenuItem_Click_1);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // biçimToolStripMenuItem
            // 
            this.biçimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
            this.biçimToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.biçimToolStripMenuItem.Text = "Biçim";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click_1);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click_1);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkToolStripMenuItem,
            this.yazıÇeşidiToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // renkToolStripMenuItem
            // 
            this.renkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazıRengiToolStripMenuItem,
            this.zeminRengiToolStripMenuItem});
            this.renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            this.renkToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.renkToolStripMenuItem.Text = "Renk";
            // 
            // yazıRengiToolStripMenuItem
            // 
            this.yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            this.yazıRengiToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
            this.yazıRengiToolStripMenuItem.Click += new System.EventHandler(this.yazıRengiToolStripMenuItem_Click);
            // 
            // zeminRengiToolStripMenuItem
            // 
            this.zeminRengiToolStripMenuItem.Name = "zeminRengiToolStripMenuItem";
            this.zeminRengiToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.zeminRengiToolStripMenuItem.Text = "Zemin Rengi";
            this.zeminRengiToolStripMenuItem.Click += new System.EventHandler(this.zeminRengiToolStripMenuItem_Click);
            // 
            // yazıÇeşidiToolStripMenuItem
            // 
            this.yazıÇeşidiToolStripMenuItem.Name = "yazıÇeşidiToolStripMenuItem";
            this.yazıÇeşidiToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.yazıÇeşidiToolStripMenuItem.Text = "Yazı Çeşidi";
            this.yazıÇeşidiToolStripMenuItem.Click += new System.EventHandler(this.yazıÇeşidiToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem1,
            this.kopyalaToolStripMenuItem1,
            this.yapıştırToolStripMenuItem1,
            this.renkToolStripMenuItem1,
            this.yazıTipiDeğiştirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 124);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // kesToolStripMenuItem1
            // 
            this.kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            this.kesToolStripMenuItem1.Size = new System.Drawing.Size(189, 24);
            this.kesToolStripMenuItem1.Text = "Kes";
            this.kesToolStripMenuItem1.Click += new System.EventHandler(this.kesToolStripMenuItem1_Click);
            // 
            // kopyalaToolStripMenuItem1
            // 
            this.kopyalaToolStripMenuItem1.Name = "kopyalaToolStripMenuItem1";
            this.kopyalaToolStripMenuItem1.Size = new System.Drawing.Size(189, 24);
            this.kopyalaToolStripMenuItem1.Text = "Kopyala";
            this.kopyalaToolStripMenuItem1.Click += new System.EventHandler(this.kopyalaToolStripMenuItem1_Click);
            // 
            // yapıştırToolStripMenuItem1
            // 
            this.yapıştırToolStripMenuItem1.Name = "yapıştırToolStripMenuItem1";
            this.yapıştırToolStripMenuItem1.Size = new System.Drawing.Size(189, 24);
            this.yapıştırToolStripMenuItem1.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem1.Click += new System.EventHandler(this.yapıştırToolStripMenuItem1_Click);
            // 
            // renkToolStripMenuItem1
            // 
            this.renkToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazıRengiDeğiştrToolStripMenuItem,
            this.zeminDeğiştirToolStripMenuItem});
            this.renkToolStripMenuItem1.Name = "renkToolStripMenuItem1";
            this.renkToolStripMenuItem1.Size = new System.Drawing.Size(189, 24);
            this.renkToolStripMenuItem1.Text = "Renk";
            this.renkToolStripMenuItem1.Click += new System.EventHandler(this.renkToolStripMenuItem1_Click);
            // 
            // yazıRengiDeğiştrToolStripMenuItem
            // 
            this.yazıRengiDeğiştrToolStripMenuItem.Name = "yazıRengiDeğiştrToolStripMenuItem";
            this.yazıRengiDeğiştrToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.yazıRengiDeğiştrToolStripMenuItem.Text = "Yazı Rengi Değiştr";
            this.yazıRengiDeğiştrToolStripMenuItem.Click += new System.EventHandler(this.yazıRengiDeğiştrToolStripMenuItem_Click);
            // 
            // zeminDeğiştirToolStripMenuItem
            // 
            this.zeminDeğiştirToolStripMenuItem.Name = "zeminDeğiştirToolStripMenuItem";
            this.zeminDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.zeminDeğiştirToolStripMenuItem.Text = "Zemin Değiştir";
            this.zeminDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.zeminDeğiştirToolStripMenuItem_Click);
            // 
            // yazıTipiDeğiştirToolStripMenuItem
            // 
            this.yazıTipiDeğiştirToolStripMenuItem.Name = "yazıTipiDeğiştirToolStripMenuItem";
            this.yazıTipiDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.yazıTipiDeğiştirToolStripMenuItem.Text = "Yazı Tipi Değiştir";
            this.yazıTipiDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.yazıTipiDeğiştirToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biçimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeminRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıÇeşidiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yazıRengiDeğiştrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeminDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

