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
    public class MyRectangle : Shape
    {
       
        public override bool CollidesWith(ICollidable other) { 
            if(other is Circle other_circle)
            {
                return Collision.Collide(this, other_circle);

            }
            else if(other is Cylinder other_cylinder)
            {
                return Collision.Collide(this,other_cylinder);
            }
            else if(other is  MyRectangle other_rectangle)
            {
                return Collision.Collide(this, other_rectangle);
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
        public int Width { get; set; }
        public int Height { get; set; }
        public int Left => Center.X;
        public int Right => Center.X + Width;
        public int Top => Center.Y;
        public int Bottom => Center.Y + Height;

        public MyRectangle(Point upperLeftCorner)
        {
           Center = upperLeftCorner;
            Width = 170;
            Height = 120;
        }
        public override  void Draw(Graphics g)
        {
            // Dikdörtgeni çiz
            g.DrawRectangle(Pens.Black, Center.X, Center.Y, Width, Height);
        }
    }
}
