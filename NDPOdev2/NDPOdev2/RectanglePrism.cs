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
    public class RectangularPrism : Shape
    {
        public override bool CollidesWith(ICollidable other)
        {
            if (other is Circle other_circle)
            {
                return Collision.Collide(this, other_circle);
            }
            else if(other is Cylinder other_cylinder)
            {
                return Collision.Collide(this,other_cylinder);
            }
            else if(other is MyRectangle other_rectangle)
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
        public MyRectangle BaseRectangle { get; set; }
        public int Height { get; set; }
       
        public RectangularPrism(MyRectangle baseRectangle)
        {
            BaseRectangle = baseRectangle;
            Height =60;
            Center = baseRectangle.Center;
        }

      
        public override void Draw(Graphics g)
        {
            BaseRectangle.Center = this.Center;
            BaseRectangle.Draw(g);
            g.DrawLine(Pens.Black,BaseRectangle.Left,BaseRectangle.Top,BaseRectangle.Left -30,BaseRectangle.Top+30);
            g.DrawLine(Pens.Black, BaseRectangle.Left, BaseRectangle.Bottom, BaseRectangle.Left - 30, BaseRectangle.Bottom + 30);
            g.DrawLine(Pens.Black, BaseRectangle.Right, BaseRectangle.Top, BaseRectangle.Right - 30, BaseRectangle.Top + 30);
            g.DrawLine(Pens.Black, BaseRectangle.Right, BaseRectangle.Bottom, BaseRectangle.Right - 30, BaseRectangle.Bottom + 30);

            g.DrawLine(Pens.Black, BaseRectangle.Left-30, BaseRectangle.Top+30, BaseRectangle.Left - 30, BaseRectangle.Bottom + 30);
            g.DrawLine(Pens.Black, BaseRectangle.Right-30, BaseRectangle.Top+30, BaseRectangle.Right - 30, BaseRectangle.Bottom + 30);
            g.DrawLine(Pens.Black, BaseRectangle.Left-30, BaseRectangle.Top+30, BaseRectangle.Right - 30, BaseRectangle.Top + 30);
            g.DrawLine(Pens.Black, BaseRectangle.Left-30, BaseRectangle.Bottom+30, BaseRectangle.Right - 30, BaseRectangle.Bottom + 30);

        }
    }
}
