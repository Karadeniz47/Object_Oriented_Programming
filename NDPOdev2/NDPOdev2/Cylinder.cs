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
    public class Cylinder : Shape
    {
       
        public override bool CollidesWith(ICollidable other) 
        { 
            if(other is Circle circle1)
            {
                return Collision.Collide(this,circle1);
            }
            else if(other is Cylinder cylinder)
            {
                return Collision.Collide(this, cylinder);
            }
            else if (other is MyRectangle rectangle)
            {
                return Collision.Collide(this, rectangle);
            }
            else if(other is RectangularPrism prism)
            {
                return Collision.Collide(this, prism);
            }
            else if(other is Sphere sphere)
            {
                return Collision.Collide(this, sphere);
            }
            else
            {
                return false;
            }
        }
        public int Radius { get; set; }
        public int Height { get; set; }
        public int NumCircles { get; set; }

        public Cylinder(Point center)
        {
            Center = center;
            Radius = 60;
            Height = 100;
            NumCircles = 100;
        }

        // Cylinder'ı çizen Draw metodu
        public override void Draw(Graphics g)
        {
            // İki elipsin merkezi
            int centerX = Center.X;
            int centerY1 = Center.Y - Height / 4; // Üst elipsin merkezi
            int centerY2 = Center.Y + Height / 4 + Height / 2; // Alt elipsin merkezi

            // Elipslerin boyutları
            int diameterX = 2 * Radius;
            int diameterY = Height / 2;

            // Üst elipsi çiz
            g.DrawEllipse(Pens.Blue, centerX - Radius, centerY1 - diameterY / 2, diameterX, diameterY);

            // Alt elipsi çiz
            g.DrawEllipse(Pens.Blue, centerX - Radius, centerY2 - diameterY / 2, diameterX, diameterY);

            // Elipsler arasına düz çizgileri çiz
            g.DrawLine(Pens.Blue, centerX - Radius, centerY1, centerX - Radius, centerY2);
            g.DrawLine(Pens.Blue, centerX + Radius, centerY1, centerX + Radius, centerY2);
        }
    }
}
