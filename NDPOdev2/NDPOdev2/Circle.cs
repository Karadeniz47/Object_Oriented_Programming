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
    public class Circle : Shape,ICollidable
    {
       
        public int Radius { get; set; }

        public Circle(Point center)
        {
            Center = center;
            Radius = 80;
        }

        public override bool CollidesWith(ICollidable other)
        {
            if (other is Circle otherCircle)
            {
                return Collision.Collide(this, otherCircle);
            }
            else if(other is MyRectangle otherRectangle)
            {
                return Collision.Collide(this, otherRectangle);
            }
            else if(other is Sphere otherSphere)
            {
                return Collision.Collide(this, otherSphere);
            }
            else if(other is RectangularPrism otherRectangularPrism)   //??
            {
                return Collision.Collide(this,otherRectangularPrism);
            }
            else if(other is Cylinder otherCylinder)
            {
                return Collision.Collide(this, otherCylinder);
            }
            
            else { return false; }
        }

        public override void Draw(Graphics g)
        {
            
            int diameter = Radius * 2;
            int x = Center.X - Radius;
            int y = Center.Y - Radius;
            g.DrawEllipse(Pens.Black, x, y, diameter, diameter);
        }
    }
}
