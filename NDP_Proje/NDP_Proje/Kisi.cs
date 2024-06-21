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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Proje
{
   
    public  class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string Telefon { get; set; }
        public string Email { get; set; }

        public Kisi(string ad, string soyad,string telefon,string email)
        {
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
            Email = email;
         
        }

       
    }

}
