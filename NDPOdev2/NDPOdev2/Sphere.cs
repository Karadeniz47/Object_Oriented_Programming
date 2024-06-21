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
    public class Sphere : Shape
    {
        public override bool CollidesWith(ICollidable other)
        {
            if(other is Circle circle)
            {
                return Collision.Collide(this, circle);
            }
            else if(other is Cylinder cylinder)
            { 
                return Collision.Collide(this, cylinder);
            }
            else if(other is MyRectangle rectangle)
            {
                return Collision.Collide(this,rectangle);
            }
            else if(other is RectangularPrism prism)
            {
                return Collision.Collide(this, prism);
            }
            else if(other is Sphere sphere)
            {
                return Collision.Collide(this,sphere);
            }
            else
            {
                return false;
            }
        }
        public int Radius { get; set; }
   

        public Sphere(Point center)
        {
            Center = center;
            Radius = 80;
        }

        public override void Draw(Graphics g)
        {
            int diameter = Radius * 2;
            int x = Center.X - Radius;
            int y = Center.Y - Radius;
            g.DrawEllipse(Pens.Black, x, y, diameter, diameter);
            g.DrawEllipse(Pens.Black, Center.X-Radius, Center.Y-Radius/2, diameter, Radius);
        }
    }
}
