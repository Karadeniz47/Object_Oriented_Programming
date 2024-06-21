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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace NDP_Proje
{
    
    public class Kuafor :Kisi, IRandevuIslemleri
    {
      


        public Kuafor(string ad, string soyad, string telefon, string email) : base(ad, soyad, telefon, email)
        {

        }
        

        public void EkleVeYaz(Randevu randevu)
        {
          
            // Randevuyu bir txt dosyasına yazın
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\randevular.txt", true))
            {
                sw.WriteLine($"{Randevu.RandevuID},{randevu.Tarih},{randevu.Saat},{randevu.Musteri.Ad},{randevu.Musteri.Soyad},{randevu.Musteri.Telefon},{randevu.Musteri.Email},{randevu.Hizmet.Ad},{randevu.Hizmet.Ucret}tl");
            }
           
        }

        public void RandevuGuncelle(int id, string yeniTarih,string yeniSaat,  string yeniAd, string yeniSoyad,string telefonNumarasi,string email,string hizmet, double ücret)
        {
            // Randevuları okuyun ve listeye dönüştürün.
            List<string> randevuListesi = new List<string>(File.ReadAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\randevular.txt"));
            bool guncellendi = false;

            // Dosyadaki her satırı kontrol edin ve güncellenmesi gereken randevuyu bulun.
            for (int i = 0; i < randevuListesi.Count; i++)
            {
                string[] veriler = randevuListesi[i].Split(',');
                if (veriler[0] == id.ToString())
                {
                    // Randevu bilgilerini güncelleyin.
                    randevuListesi[i] = $"{id},{yeniTarih},{yeniSaat},{yeniAd},{yeniSoyad},{telefonNumarasi},{email},{hizmet},{ücret}tl";
                    guncellendi = true;
                    break;
                }
            }

            // Eğer bir güncelleme yapıldıysa, dosyayı yeniden yazın.
            if (guncellendi)
            {
                File.WriteAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\randevular.txt", randevuListesi);
            }
           
        }

        public  void Sil(int randevuId)
        {
            // 'randevular.txt' dosyasındaki tüm satırları okuyun.
            var lines = File.ReadAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\randevular.txt").ToList();

            // Silinecek randevunun satırını bulun.
            var lineToRemove = lines.FirstOrDefault(line => line.StartsWith($"{randevuId},"));

            // Eğer satır bulunursa, onu silin.
            if (lineToRemove != null)
            {
                lines.Remove(lineToRemove);
                // Dosyayı güncellenmiş satırlarla yeniden yazın.
                File.WriteAllLines("C:\\Users\\Huawei\\source\\repos\\NDP_Proje\\NDP_Proje\\randevular.txt", lines);
            }
        }
    }

}
