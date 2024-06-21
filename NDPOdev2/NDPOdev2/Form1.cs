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
    public partial class Form1 : Form
    {
        private List<Shape> shapes = new List<Shape>(); // Yeni liste türü

        private Shape selectedShape1;
        private Shape selectedShape2;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxShape1.Items.Add("Daire");
            comboBoxShape1.Items.Add("Silindir");
            comboBoxShape1.Items.Add("Dikdörtgen");
            comboBoxShape1.Items.Add("Dikdörtgen_Prizma");
            comboBoxShape1.Items.Add("Kure");
           
            comboBoxShape2.Items.Add("Daire");
            comboBoxShape2.Items.Add("Silindir");
            comboBoxShape2.Items.Add("Dikdörtgen");
            comboBoxShape2.Items.Add("Dikdörtgen_Prizma");
            comboBoxShape2.Items.Add("Kure");
        }



        

        private void OpenShapeForm1(string shapeType)
        {
            Shape shape;

            switch (shapeType)
            {
                case "Daire":
                    shape = new Circle(new Point(100, 90));
                    break;

                case "Dikdörtgen":
                    shape = new MyRectangle(new Point(30, 30));
                    break;

                case "Kure":
                    shape = new Sphere(new Point(100, 90));
                    break;

                case "Silindir":
                    shape = new Cylinder(new Point(65, 55));
                    break;

                case "Dikdörtgen_Prizma":
                    shape = new RectangularPrism(new MyRectangle(new Point(35, 30)));
                    break;

                default:
                    return;
            }

            shapes.Add(shape);
        }

        private void OpenShapeForm2(string shapeType)
        {
            Shape shape;

            switch (shapeType)
            {
                case "Daire":
                    shape = new Circle(new Point(500, 250));
                    break;

                case "Dikdörtgen":
                    shape = new MyRectangle(new Point(400, 200));
                    break;

                case "Kure":
                    shape = new Sphere(new Point(500, 250));
                    break;

                case "Silindir":
                    shape = new Cylinder(new Point(460, 255));
                    break;

                case "Dikdörtgen_Prizma":
                    shape = new RectangularPrism(new MyRectangle(new Point(400, 200)));
                    break;

                default:
                    return;
            }

            shapes.Add(shape);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Öncelikle ComboBox'ta bir seçim yapılıp yapılmadığını kontrol edin
            if (comboBoxShape1.SelectedItem == null || comboBoxShape2.SelectedItem == null)
            {
                MessageBox.Show("Lütfen her iki ComboBox'tan da bir şekil seçin.", "Seçim Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Hatalı durumlarda metodu erken bitirerek devam etmeyin
            }
            OpenShapeForm1(comboBoxShape1.SelectedItem.ToString());
            OpenShapeForm2(comboBoxShape2.SelectedItem.ToString());
            DrawingForm drawingForm = new DrawingForm(shapes); // Shape türünde liste ile
            drawingForm.Show();
        }


    }
}