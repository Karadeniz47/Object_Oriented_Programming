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
    [Serializable]
    public class Randevu
    {
        public string Tarih { get; set; }
        public string Saat { get; set; }
        public Musteri Musteri { get; set; }
        public Hizmet Hizmet { get; set; }
       

        public static  int RandevuID = 0;

        public Randevu(string tarih,string saat, Musteri musteri, Hizmet hizmet)
        {
            Tarih = tarih;
            Saat = saat;
            Musteri = musteri;
            Hizmet = hizmet;
            RandevuID++;
        }
      
    }

}
