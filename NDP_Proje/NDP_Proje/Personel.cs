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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Proje
{
   
    public class Personel : Kisi,IPersonelIslemleri
    {
        public string Pozisyon { get; set; }
      

        public static int PersonelID = 0;

        public Personel(string ad, string soyad,string telefon,string email, string pozisyon) : base(ad, soyad,telefon,email)
        {
            Pozisyon = pozisyon;
            
            Pozisyon = pozisyon;
            PersonelID++;
        }

      

        public void EkleVeYaz(Personel personel)
        {
            // Randevuyu bir txt dosyasına yazın
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\personel.txt", true))
            {
                sw.WriteLine($"{Personel.PersonelID},{personel.Ad},{personel.Soyad},{personel.Telefon},{personel.Email},{personel.Pozisyon}");
            }

        }

        public void Sil(int personelId)
        {
            // 'randevular.txt' dosyasındaki tüm satırları okuyun.
            var lines = File.ReadAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\personel.txt").ToList();

            // Silinecek randevunun satırını bulun.
            var lineToRemove = lines.FirstOrDefault(line => line.StartsWith($"{personelId},"));

            // Eğer satır bulunursa, onu silin.
            if (lineToRemove != null)
            {
                lines.Remove(lineToRemove);
                // Dosyayı güncellenmiş satırlarla yeniden yazın.
                File.WriteAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\personel.txt", lines);
            }

        }

        public void PersonelGuncelle(int PersonelID, string yeniAd, string yeniSoyad, string yeniTelefon, string email, string pozisyon)
        {
            // Randevuları okuyun ve listeye dönüştürün.
            List<string> personelListesi = new List<string>(File.ReadAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\personel.txt"));
            bool guncellendi = false;

            // Dosyadaki her satırı kontrol edin ve güncellenmesi gereken randevuyu bulun.
            for (int i = 0; i < personelListesi.Count; i++)
            {
                string[] veriler = personelListesi[i].Split(',');
                if (veriler[0] == PersonelID.ToString())
                {
                    // Randevu bilgilerini güncelleyin.
                    personelListesi[i] = $"{PersonelID},{yeniAd},{yeniSoyad},{yeniTelefon},{email},{pozisyon}";
                    guncellendi = true;
                    break;
                }
            }

            // Eğer bir güncelleme yapıldıysa, dosyayı yeniden yazın.
            if (guncellendi)
            {
                File.WriteAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\personel.txt", personelListesi);
            }

        }


    }
}
