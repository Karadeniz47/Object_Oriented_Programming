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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPOdev2
{
    public partial class DrawingForm : Form
    {
        private List<Shape> shapes;
        public DrawingForm(List<Shape> shapes)
        {
            InitializeComponent();
            label1.Text = "Çarpışma Yok";
            label1.ForeColor = Color.Green; // Rengi yeşil yapın
            this.shapes = shapes;
            this.KeyPreview = true; // KeyDown olayını dinleyebilmek için
            this.KeyDown += OnKeyDown; // Olay işleyici ekle

        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            int movementStep = 10;

            if (shapes.Count >= 2) // En az iki şekil olduğundan emin olun
            {
                // İlk şekil için `W`, `A`, `S`, `D` kontrolleri
                switch (e.KeyCode)
                {
                    case Keys.A:
                        MoveShape(0, -movementStep, 0); // Sola hareket
                        break;

                    case Keys.D:
                        MoveShape(0, movementStep, 0); // Sağa hareket
                        break;

                    case Keys.W:
                        MoveShape(0, 0, -movementStep); // Yukarı hareket
                        break;

                    case Keys.S:
                        MoveShape(0, 0, movementStep); // Aşağı hareket
                        break;
                }

                // İkinci şekil için yön tuşlarını kontrol et
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        MoveShape(1, -movementStep, 0); // Sola hareket
                        break;

                    case Keys.Right:
                        MoveShape(1, movementStep, 0); // Sağa hareket
                        break;

                    case Keys.Up:
                        MoveShape(1, 0, -movementStep); // Yukarı hareket
                        break;

                    case Keys.Down:
                        MoveShape(1, 0, movementStep); // Aşağı hareket
                        break;
                }
            }

            this.Invalidate(); // Formu yeniden çizmek için
        }

       

        public bool IsValidIndex(int index)
        {
            return index >= 0 && index < shapes.Count;
        }

        

        public bool HasCollision(int index, int xDelta, int yDelta)
        {
            var shapeToMove = shapes[index];
            Point newCenter = new Point(
                shapeToMove.Center.X + xDelta,
                shapeToMove.Center.Y + yDelta
            );

            bool hasCollision = false;

            foreach (var otherShape in shapes.Where((s, i) => i != index))
            {
                if (shapeToMove.CollidesWith(otherShape))
                {
                   hasCollision = true;
                    break;
                }
            }

          

            return hasCollision;
        }


        private void MoveShape(int index, int xDelta, int yDelta)
        {
            if (!IsValidIndex(index)) return;
            var shapeToMove = shapes[index];
            shapeToMove.Move(xDelta, yDelta); // Bu Move metodu, şekil türüne göre uygulanır
            this.Invalidate(); // Yeniden çizim

            if (!HasCollision(index, xDelta, yDelta))
            {
                label1.Text = "Çarpışma Yok";
                label1.ForeColor = Color.Green; // Rengi yeşil yapın
            }
            else
            {
                label1.Text = "Çarpışma Var";
                label1.ForeColor = Color.Red; // Rengi kırmızı yapın
            }
        }


        private void DrawingForm_Load(object sender, EventArgs e)
        {
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            foreach (var shape in shapes)
            {
                shape.Draw(g); // Her Shape için Draw metodunu kullanarak çizin
            }
           
        }



    }
}
