/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				          PROGRAMLAMAYA GİRİŞİ DERSİ
**	
**				ÖDEV NUMARASI…...: 2
**				ÖĞRENCİ ADI...............: İsmail Alper Karadeniz
**				ÖĞRENCİ NUMARASI.: B221210065
**				DERS GRUBU…………: B
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPOdev2
{
    public abstract class Shape : ICollidable
    {
        public abstract bool CollidesWith(ICollidable other);
        public Shape()  
        {
            Center = new Point(0, 0); 
        }
        public abstract void Draw(Graphics g);

        public Point Center { get; set; }

        public void Move(int xDelta, int yDelta)
        {
            Center = new Point(Center.X + xDelta, Center.Y + yDelta);
        }
    }
}
