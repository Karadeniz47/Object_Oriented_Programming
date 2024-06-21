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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NDPOdev2
{
    public static class Collision
    {
        public static bool Collide(Circle circle1, Circle circle2)
        {
            // Calculate distance between centers of circles
            double distance = Math.Sqrt(Math.Pow((circle1.Center.X - circle2.Center.X), 2) + Math.Pow((circle1.Center.Y - circle2.Center.Y), 2));

            // Check if sum of radii is greater than distance between centers
            if ((circle1.Radius + circle2.Radius) > distance)
                return true;
            else
                return false;
        }
        public static bool Collide(Circle circle, MyRectangle rectangle)
        {
            // Calculate the closest point on the rectangle to the center of the circle
            int closestX = Math.Max(rectangle.Left, Math.Min(circle.Center.X, rectangle.Right));
            int closestY = Math.Max(rectangle.Top, Math.Min(circle.Center.Y, rectangle.Bottom));

            // Calculate the distance between the closest point and the center of the circle
            double distance = Math.Sqrt(Math.Pow((closestX - circle.Center.X), 2) + Math.Pow((closestY - circle.Center.Y), 2));

            // Check if the distance is less than or equal to the radius of the circle
            return distance <= circle.Radius;
        }
        public static bool Collide(Circle circle1,Sphere sphere1)
        {
            // Calculate distance between centers of circles
            double distance = Math.Sqrt(Math.Pow((circle1.Center.X - sphere1.Center.X), 2) + Math.Pow((circle1.Center.Y - sphere1.Center.Y), 2));

            // Check if sum of radii is greater than distance between centers
            if ((circle1.Radius + sphere1.Radius) > distance)
                return true;
            else
                return false;
        }
        public static bool Collide(Circle circle,RectangularPrism prism)
        {
            //// Dairenin merkezi ve yarıçapı
            //Point circleCenter = circle.Center;
            //int circleRadius = circle.Radius;

            //// Dikdörtgen prizmanın köşe noktalarını belirle
            //Point upperLeftCorner = prism.BaseRectangle.Center;
            //Point upperRightCorner = new Point(prism.BaseRectangle.Center.X + prism.BaseRectangle.Width, prism.BaseRectangle.Center.Y);
            //Point lowerLeftCorner = new Point(prism.BaseRectangle.Center.X, prism.BaseRectangle.Center.Y + prism.Height);
            //Point lowerRightCorner = new Point(prism.BaseRectangle.Center.X + prism.BaseRectangle.Width, prism.BaseRectangle.Center.Y + prism.Height);

            //// Dairenin merkezi ile dikdörtgen prizmanın kenarları arasındaki en yakın noktayı bul
            //int closestX = Math.Max(upperLeftCorner.X, Math.Min(circleCenter.X, upperRightCorner.X));
            //int closestY = Math.Max(upperLeftCorner.Y, Math.Min(circleCenter.Y, lowerLeftCorner.Y));

            //// Daire merkezi ile en yakın nokta arasındaki uzaklığı hesapla
            //int distanceX = circleCenter.X - closestX;
            //int distanceY = circleCenter.Y - closestY;
            //double distance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY);

            //// Eğer uzaklık dairenin yarıçapından küçük veya eşitse, çarpışma vardır
            //return distance <= circleRadius;

            // Dairenin merkezi ve yarıçapı
            Point circleCenter = circle.Center;
            int circleRadius = circle.Radius;

            // Prizmanın perspektif çizgileri
            Point topLeft = new Point(prism.BaseRectangle.Left, prism.BaseRectangle.Top);
            Point topRight = new Point(prism.BaseRectangle.Right, prism.BaseRectangle.Top);
            Point bottomLeft = new Point(prism.BaseRectangle.Left - 30, prism.BaseRectangle.Bottom + 30);
            Point bottomRight = new Point(prism.BaseRectangle.Right - 30, prism.BaseRectangle.Bottom + 30);

            // Dairenin merkezi prizmanın temel dikdörtgeni içinde mi?
            if (circleCenter.X >= topLeft.X && circleCenter.X <= topRight.X &&
                circleCenter.Y >= topLeft.Y && circleCenter.Y <= bottomLeft.Y)
            {
                return true;
            }

            // Daire ile perspektif çizgileri arasındaki mesafeyi kontrol et
            Point[] points = new Point[] { topLeft, topRight, bottomRight, bottomLeft };

            // Daire, perspektif çizgileri ile çarpışıyor mu?
            for (int i = 0; i < points.Length; i++)
            {
                Point start = points[i];
                Point end = points[(i + 1) % points.Length];

                double distance = DistanceToSegment(circleCenter, start, end);

                if (distance <= circleRadius)
                {
                    return true;
                }
            }

            // Çarpışma tespit edilmezse
            return false;

        }
        public static double DistanceToSegment(Point p, Point start, Point end)
        {
            // Doğru segmenti ile nokta arasındaki en kısa mesafeyi hesaplar
            double lengthSquared = Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2);

            if (lengthSquared == 0)
            {
                return Math.Sqrt(Math.Pow(p.X - start.X, 2) + Math.Pow(p.Y - start.Y, 2));
            }

            double t = ((p.X - start.X) * (end.X - start.X) + (p.Y - start.Y) * (end.Y - start.Y)) / lengthSquared;
            t = Math.Max(0, Math.Min(1, t));

            Point projection = new Point(
                (int)(start.X + t * (end.X - start.X)),
                (int)(start.Y + t * (end.Y - start.Y))
            );

            return Math.Sqrt(Math.Pow(projection.X - p.X, 2) + Math.Pow(projection.Y - p.Y, 2));
        }
        public static bool Collide(Circle circle, Cylinder cylinder)
        {
            // Dairenin merkezi ve yarıçapı
            Point circleCenter = circle.Center;
            int circleRadius = circle.Radius;

            // Silindirin alt taban merkezi, yarıçapı, ve yüksekliği
            Point cylinderBaseCenter = cylinder.Center;
            int cylinderRadius = cylinder.Radius;
            int cylinderHeight = cylinder.Height;

            // Yatay mesafeyi hesapla
            double horizontalDistance = Math.Sqrt(
                Math.Pow(circleCenter.X - cylinderBaseCenter.X, 2) +
                Math.Pow(circleCenter.Y - cylinderBaseCenter.Y, 2)
            );

            // Yatay çarpışma kontrolü
            bool horizontalCollision = horizontalDistance <= (cylinderRadius + circleRadius);

            if (horizontalCollision)
            {
                // Dikey mesafeyi hesapla
                int verticalDistance = Math.Abs(circleCenter.Y - cylinderBaseCenter.Y);

                // Dikey çarpışma kontrolü: Dairenin merkezinin silindirin yüksekliği içinde olup olmadığını kontrol edin
                if (verticalDistance <= (cylinderHeight / 2 + circleRadius))
                {
                    return true; // Hem yatay hem dikey çarpışma var
                }
            }

            return false; // Çarpışma yok
        }
       

        public static bool Collide(Cylinder cylinder, Circle circle)
        {
            // Dairenin merkezi ve yarıçapı
            Point circleCenter = circle.Center;
            int circleRadius = circle.Radius;

            // Silindirin alt taban merkezi, yarıçapı, ve yüksekliği
            Point cylinderBaseCenter = cylinder.Center;
            int cylinderRadius = cylinder.Radius;
            int cylinderHeight = cylinder.Height;

            // Yatay mesafeyi hesapla
            double horizontalDistance = Math.Sqrt(
                Math.Pow(circleCenter.X - cylinderBaseCenter.X, 2) +
                Math.Pow(circleCenter.Y - cylinderBaseCenter.Y, 2)
            );

            // Yatay çarpışma kontrolü
            bool horizontalCollision = horizontalDistance <= (cylinderRadius + circleRadius);

            if (horizontalCollision)
            {
                // Dikey mesafeyi hesapla
                int verticalDistance = Math.Abs(circleCenter.Y - cylinderBaseCenter.Y);

                // Dikey çarpışma kontrolü: Dairenin merkezinin silindirin yüksekliği içinde olup olmadığını kontrol edin
                if (verticalDistance <= (cylinderHeight / 2 + circleRadius))
                {
                    return true; // Hem yatay hem dikey çarpışma var
                }
            }

            return false; // Çarpışma yok

        }
        public static bool Collide(Cylinder cylinder, MyRectangle rectangle)
        {
            // Silindirin taban merkezi ve yarıçapı
            Point cylinderBaseCenter = cylinder.Center;
            int cylinderRadius = cylinder.Radius;

            // Silindirin tabanı ile dikdörtgen arasındaki yatay mesafeyi kontrol et
            double closestX = Math.Max(rectangle.Left, Math.Min(cylinderBaseCenter.X, rectangle.Right));
            double closestY = Math.Max(rectangle.Top, Math.Min(cylinderBaseCenter.Y, rectangle.Bottom));

            // Silindirin taban merkezi ile dikdörtgenin en yakın noktası arasındaki yatay mesafeyi hesapla
            double distanceX = cylinderBaseCenter.X - closestX;
            double distanceY = cylinderBaseCenter.Y - closestY;

            // Silindirin yüksekliği boyunca olan mesafeyi kontrol edin
            int d = cylinderBaseCenter.Y + cylinder.Height / 2 + rectangle.Height / 2;
            int e = Math.Abs((cylinderBaseCenter.Y + cylinder.Height / 2) - (rectangle.Height / 2));

            bool withinHeightRange = e < d;
            //(cylinderBaseCenter.Y >= rectangle.Top && cylinderBaseCenter.Y <= rectangle.Bottom);


            // Yatay mesafeyi hesapla
            double horizontalDistance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY);

            // Eğer silindirin tabanı yatay olarak dikdörtgenin içindeyse ve silindirin yarıçapı ile bu mesafe arasında bir çarpışma varsa, çarpışma vardır.
            return withinHeightRange && horizontalDistance <= cylinderRadius;
        } 
        public static bool Collide(Cylinder cylinder, Sphere sphere)
        {
            // Silindir ile kürenin merkezleri arasındaki yatay mesafeyi hesaplayın
            double horizontalDistance = Math.Sqrt(
                Math.Pow((sphere.Center.X - cylinder.Center.X), 2) +
                Math.Pow((sphere.Center.Y - cylinder.Center.Y), 2)
            );

            // Yatay mesafenin silindir ve kürenin yarıçaplarının toplamına eşit veya daha küçük olup olmadığını kontrol edin
            if (horizontalDistance <= (cylinder.Radius + sphere.Radius))
            {
                // Silindirin taban merkezi ile kürenin merkezi arasındaki dikey farkı hesaplayın
                double verticalDistance = Math.Abs(sphere.Center.Y - cylinder.Center.Y);

                // Silindirin yarıçapının içinde olup olmadığını kontrol edin
                // Silindirin yarıçapının kürenin yarıçapı kadar yukarıya ve aşağıya doğru uzanması gerekir
                double cylinderHeightRange = cylinder.Height / 2;

                if (verticalDistance <= (cylinderHeightRange + sphere.Radius))
                {
                    return true; // Çarpışma var
                }
            }

            return false; // Çarpışma yok
        }
        public static bool Collide(Cylinder cylinder, RectangularPrism prism)
        {
            // Silindirin taban merkezi ve yarıçapı
            Point cylinderBaseCenter = cylinder.Center;
            int cylinderRadius = cylinder.Radius;

            // Prizmanın yatay ve dikey sınırları
            MyRectangle baseRectangle = prism.BaseRectangle;
            int prismWidth = baseRectangle.Width;
            int prismHeight = prism.Height;

            // Prizmanın taban ve üst köşelerini belirleyin
            Point upperLeft = new Point(baseRectangle.Left, baseRectangle.Top);
            Point lowerRight = new Point(baseRectangle.Right, baseRectangle.Bottom);

            // Silindirin taban merkezi ile prizmanın yatay sınırları arasındaki mesafeyi hesaplayın
            double closestX = Math.Max(upperLeft.X, Math.Min(cylinderBaseCenter.X, lowerRight.X));
            double closestY = Math.Max(upperLeft.Y, Math.Min(cylinderBaseCenter.Y, lowerRight.Y));

            double distanceX = Math.Abs(cylinderBaseCenter.X - closestX);
            double distanceY = Math.Abs(cylinderBaseCenter.Y - closestY);

            // Yatay mesafeyi hesaplayın
            double horizontalDistance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY);

            // Silindirin dikey sınırlarını belirleyin
            double cylinderBottom = cylinderBaseCenter.Y - (cylinder.Height / 2);
            double cylinderTop = cylinderBaseCenter.Y + (cylinder.Height / 2);

            double prismBottom = upperLeft.Y; // Prizmanın alt sınırı
            double prismTop = upperLeft.Y + prismHeight; // Prizmanın üst sınırı

            // Dikey eksende silindirin prizmanın içinde olup olmadığını kontrol edin
            bool withinHeightRange = (cylinderBottom <= prismTop) || (cylinderTop >= prismBottom);

            // Çarpışma kontrolü: Silindirin taban merkezi ile prizmanın köşeleri arasındaki yatay mesafeyi ve dikey sınırları kontrol edin
            return withinHeightRange && (horizontalDistance <= cylinderRadius);
        } 
        public static bool Collide(Cylinder cylinder1, Cylinder cylinder2)
        {
            // Silindirlerin merkezleri arasındaki yatay mesafe
            double distanceX = Math.Abs(cylinder1.Center.X - cylinder2.Center.X);

            // Silindirlerin merkezleri arasındaki dikey mesafe
            double distanceY = Math.Abs(cylinder1.Center.Y - cylinder2.Center.Y);

            // Silindirlerin merkezleri arasındaki tam mesafe
            double distance = Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2));

            // Taban çarpışması kontrolü
            bool baseCollision = distanceX < (cylinder1.Radius + cylinder2.Radius) &&
                                 distanceY < cylinder1.Height / 2 + cylinder2.Height / 2;

            // Yan yüzey çarpışması kontrolü
            bool sideCollision = distance < (cylinder1.Radius + cylinder2.Radius);

            return baseCollision || sideCollision;
        }


        public static bool Collide(MyRectangle rectangle,Circle circle)
        {
            // Calculate the closest point on the rectangle to the center of the circle
            int closestX = Math.Max(rectangle.Left, Math.Min(circle.Center.X, rectangle.Right));
            int closestY = Math.Max(rectangle.Top, Math.Min(circle.Center.Y, rectangle.Bottom));

            // Calculate the distance between the closest point and the center of the circle
            double distance = Math.Sqrt(Math.Pow((closestX - circle.Center.X), 2) + Math.Pow((closestY - circle.Center.Y), 2));

            // Check if the distance is less than or equal to the radius of the circle
            return distance <= circle.Radius;

        }
        public static bool Collide(MyRectangle rectangle,Cylinder cylinder)
        {
            // Silindirin taban merkezi ve yarıçapı
            Point cylinderBaseCenter = cylinder.Center;
            int cylinderRadius = cylinder.Radius;

            // Silindirin tabanı ile dikdörtgen arasındaki yatay mesafeyi kontrol et
            double closestX = Math.Max(rectangle.Left, Math.Min(cylinderBaseCenter.X, rectangle.Right));
            double closestY = Math.Max(rectangle.Top, Math.Min(cylinderBaseCenter.Y, rectangle.Bottom));

            // Silindirin taban merkezi ile dikdörtgenin en yakın noktası arasındaki yatay mesafeyi hesapla
            double distanceX = cylinderBaseCenter.X - closestX;
            double distanceY = cylinderBaseCenter.Y - closestY;

            // Silindirin yüksekliği boyunca olan mesafeyi kontrol edin
            int d = cylinderBaseCenter.Y + cylinder.Height / 2 + rectangle.Height / 2;
            int e = Math.Abs((cylinderBaseCenter.Y + cylinder.Height / 2) - (rectangle.Height / 2));

            bool withinHeightRange = e < d;
            //(cylinderBaseCenter.Y >= rectangle.Top && cylinderBaseCenter.Y <= rectangle.Bottom);


            // Yatay mesafeyi hesapla
            double horizontalDistance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY);

            // Eğer silindirin tabanı yatay olarak dikdörtgenin içindeyse ve silindirin yarıçapı ile bu mesafe arasında bir çarpışma varsa, çarpışma vardır.
            return withinHeightRange && horizontalDistance <= cylinderRadius;

        }
        public static bool Collide(MyRectangle rect1, MyRectangle rect2)
        {
            int x1 = rect1.Center.X;
            int y1 = rect1.Center.Y;
            int x2 = rect2.Center.X;
            int y2 = rect2.Center.Y;

            if (Math.Abs(x1 - x2) < (rect1.Width + rect2.Width) / 2 && Math.Abs(y1 - y2) < (rect1.Height + rect2.Height) / 2)
                return true;
            else
                return false;
        }
        public static bool Collide(MyRectangle rectangle, RectangularPrism prism)
        {
            int x1 = rectangle.Center.X;
            int y1 = rectangle.Center.Y;
            int x2 = prism.BaseRectangle.Center.X;
            int y2 = prism.BaseRectangle.Center.Y;
            if (Math.Abs(x1 - x2) < (rectangle.Width + rectangle.Width) / 2 && Math.Abs(y1 - y2) < (rectangle.Height + rectangle.Height) / 2)
                return true;
            else
                return false;

        }
        public static bool Collide(MyRectangle rectangle, Sphere sphere)
        {
            // Dikdörtgenin sınırları
            int rectLeft = rectangle.Left;
            int rectRight = rectangle.Right;
            int rectTop = rectangle.Top;
            int rectBottom = rectangle.Bottom;

            // Kürenin merkezi ve yarıçapı
            Point sphereCenter = sphere.Center;
            int sphereRadius = sphere.Radius;

            // Kürenin merkezi ile dikdörtgenin en yakın noktası arasındaki mesafeyi hesapla
            int closestX = Math.Max(rectLeft, Math.Min(sphereCenter.X, rectRight));
            int closestY = Math.Max(rectTop, Math.Min(sphereCenter.Y, rectBottom));

            // Yakın noktadan küre merkezine olan mesafeyi hesapla
            int distanceX = sphereCenter.X - closestX;
            int distanceY = sphereCenter.Y - closestY;

            double distance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY);

            // Çarpışma kontrolü
            return distance <= sphereRadius;
        }


        public static bool Collide(RectangularPrism prism,Circle circle)
        {
            // Dairenin merkezi ve yarıçapı
            Point circleCenter = circle.Center;
            int circleRadius = circle.Radius;

            // Prizmanın perspektif çizgileri
            Point topLeft = new Point(prism.BaseRectangle.Left, prism.BaseRectangle.Top);
            Point topRight = new Point(prism.BaseRectangle.Right, prism.BaseRectangle.Top);
            Point bottomLeft = new Point(prism.BaseRectangle.Left - 30, prism.BaseRectangle.Bottom + 30);
            Point bottomRight = new Point(prism.BaseRectangle.Right - 30, prism.BaseRectangle.Bottom + 30);

            // Dairenin merkezi prizmanın temel dikdörtgeni içinde mi?
            if (circleCenter.X >= topLeft.X && circleCenter.X <= topRight.X &&
                circleCenter.Y >= topLeft.Y && circleCenter.Y <= bottomLeft.Y)
            {
                return true;
            }

            // Daire ile perspektif çizgileri arasındaki mesafeyi kontrol et
            Point[] points = new Point[] { topLeft, topRight, bottomRight, bottomLeft };

            // Daire, perspektif çizgileri ile çarpışıyor mu?
            for (int i = 0; i < points.Length; i++)
            {
                Point start = points[i];
                Point end = points[(i + 1) % points.Length];

                double distance = DistanceToSegment(circleCenter, start, end);

                if (distance <= circleRadius)
                {
                    return true;
                }
            }

            // Çarpışma tespit edilmezse
            return false;



        }
        public static bool Collide(RectangularPrism prism, Cylinder cylinder)
        {
            // Silindirin taban merkezi ve yarıçapı
            Point cylinderBaseCenter = cylinder.Center;
            int cylinderRadius = cylinder.Radius;

            // Prizmanın yatay ve dikey sınırları
            MyRectangle baseRectangle = prism.BaseRectangle;
            int prismWidth = baseRectangle.Width;
            int prismHeight = prism.Height;

            // Prizmanın taban ve üst köşelerini belirleyin
            Point upperLeft = new Point(baseRectangle.Left, baseRectangle.Top);
            Point lowerRight = new Point(baseRectangle.Right, baseRectangle.Bottom);

            // Silindirin taban merkezi ile prizmanın yatay sınırları arasındaki mesafeyi hesaplayın
            double closestX = Math.Max(upperLeft.X, Math.Min(cylinderBaseCenter.X, lowerRight.X));
            double closestY = Math.Max(upperLeft.Y, Math.Min(cylinderBaseCenter.Y, lowerRight.Y));

            double distanceX = Math.Abs(cylinderBaseCenter.X - closestX);
            double distanceY = Math.Abs(cylinderBaseCenter.Y - closestY);

            // Yatay mesafeyi hesaplayın
            double horizontalDistance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY);

            // Silindirin dikey sınırlarını belirleyin
            double cylinderBottom = cylinderBaseCenter.Y - (cylinder.Height / 2);
            double cylinderTop = cylinderBaseCenter.Y + (cylinder.Height / 2);

            double prismBottom = upperLeft.Y; // Prizmanın alt sınırı
            double prismTop = upperLeft.Y + prismHeight; // Prizmanın üst sınırı

            // Dikey eksende silindirin prizmanın içinde olup olmadığını kontrol edin
            bool withinHeightRange = (cylinderBottom <= prismTop) || (cylinderTop >= prismBottom);

            // Çarpışma kontrolü: Silindirin taban merkezi ile prizmanın köşeleri arasındaki yatay mesafeyi ve dikey sınırları kontrol edin
            return withinHeightRange && (horizontalDistance <= cylinderRadius);

        }
        public static bool Collide(RectangularPrism prism, MyRectangle rectangle)
        {
            int x1 = rectangle.Center.X;
            int y1 = rectangle.Center.Y;
            int x2 = prism.BaseRectangle.Center.X;
            int y2 = prism.BaseRectangle.Center.Y;
            if (Math.Abs(x1 - x2) < (rectangle.Width + rectangle.Width) / 2 && Math.Abs(y1 - y2) < (rectangle.Height + rectangle.Height) / 2)
                return true;
            else
                return false;

        }
        public static bool Collide(RectangularPrism prism1, RectangularPrism prism2)
        {
            // İki prizmanın boyutları
            int width1 = prism1.BaseRectangle.Width;
            int height1 = prism1.BaseRectangle.Height;
            int width2 = prism2.BaseRectangle.Width;
            int height2 = prism2.BaseRectangle.Height;

            // İki prizmanın merkezlerini al
            Point center1 = prism1.Center;
            Point center2 = prism2.Center;

            // İki prizmanın birbirine çarpması için gereken minimum uzaklık hesabı
            int minDistanceX = (width1 + width2) / 2;
            int minDistanceY = (height1 + height2) / 2;

            // Merkezler arasındaki mesafe
            int distanceX = Math.Abs(center1.X - center2.X);
            int distanceY = Math.Abs(center1.Y - center2.Y);

            // Eğer herhangi bir yönde çarpışma varsa, iki prizma çarpışıyor demektir
            return distanceX <= minDistanceX && distanceY <= minDistanceY;
        }
        public static bool Collide(RectangularPrism prism,Sphere sphere)
        {
            

            // Calculate the closest point on the rectangle to the center of the circle
            int closestX = Math.Max(prism.BaseRectangle.Left, Math.Min(sphere.Center.X, prism.BaseRectangle.Right));
            int closestY = Math.Max(prism.BaseRectangle.Top, Math.Min(sphere.Center.Y, prism.BaseRectangle.Bottom));

            // Calculate the distance between the closest point and the center of the circle
            double distance = Math.Sqrt(Math.Pow((closestX - sphere.Center.X), 2) + Math.Pow((closestY - sphere.Center.Y), 2));

            // Check if the distance is less than or equal to the radius of the circle
            return distance <= sphere.Radius;

        }  


        public static bool Collide(Sphere sphere,Circle circle)
        {
            // Calculate distance between centers of circles
            double distance = Math.Sqrt(Math.Pow((circle.Center.X - sphere.Center.X), 2) + Math.Pow((circle.Center.Y - sphere.Center.Y), 2));

            // Check if sum of radii is greater than distance between centers
            if ((circle.Radius + sphere.Radius) > distance)
                return true;
            else
                return false;
        }
        public static bool Collide(Sphere sphere,Cylinder cylinder)
        {
            // Silindir ile kürenin merkezleri arasındaki yatay mesafeyi hesaplayın
            double horizontalDistance = Math.Sqrt(
                Math.Pow((sphere.Center.X - cylinder.Center.X), 2) +
                Math.Pow((sphere.Center.Y - cylinder.Center.Y), 2)
            );

            // Yatay mesafenin silindir ve kürenin yarıçaplarının toplamına eşit veya daha küçük olup olmadığını kontrol edin
            if (horizontalDistance <= (cylinder.Radius + sphere.Radius))
            {
                // Silindirin taban merkezi ile kürenin merkezi arasındaki dikey farkı hesaplayın
                double verticalDistance = Math.Abs(sphere.Center.Y - cylinder.Center.Y);

                // Silindirin yarıçapının içinde olup olmadığını kontrol edin
                // Silindirin yarıçapının kürenin yarıçapı kadar yukarıya ve aşağıya doğru uzanması gerekir
                double cylinderHeightRange = cylinder.Height / 2;

                if (verticalDistance <= (cylinderHeightRange + sphere.Radius))
                {
                    return true; // Çarpışma var
                }
            }
            return false; // Çarpışma yok
        }
        public static bool Collide(Sphere sphere,MyRectangle rectangle)
        {
            // Dikdörtgenin sınırları
            int rectLeft = rectangle.Left;
            int rectRight = rectangle.Right;
            int rectTop = rectangle.Top;
            int rectBottom = rectangle.Bottom;

            // Kürenin merkezi ve yarıçapı
            Point sphereCenter = sphere.Center;
            int sphereRadius = sphere.Radius;

            // Kürenin merkezi ile dikdörtgenin en yakın noktası arasındaki mesafeyi hesapla
            int closestX = Math.Max(rectLeft, Math.Min(sphereCenter.X, rectRight));
            int closestY = Math.Max(rectTop, Math.Min(sphereCenter.Y, rectBottom));

            // Yakın noktadan küre merkezine olan mesafeyi hesapla
            int distanceX = sphereCenter.X - closestX;
            int distanceY = sphereCenter.Y - closestY;

            double distance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY);

            // Çarpışma kontrolü
            return distance <= sphereRadius;

        }
        public static bool Collide(Sphere sphere,RectangularPrism prism)
        {
            // Calculate the closest point on the rectangle to the center of the circle
            int closestX = Math.Max(prism.BaseRectangle.Left, Math.Min(sphere.Center.X, prism.BaseRectangle.Right));
            int closestY = Math.Max(prism.BaseRectangle.Top, Math.Min(sphere.Center.Y, prism.BaseRectangle.Bottom));

            // Calculate the distance between the closest point and the center of the circle
            double distance = Math.Sqrt(Math.Pow((closestX - sphere.Center.X), 2) + Math.Pow((closestY - sphere.Center.Y), 2));

            // Check if the distance is less than or equal to the radius of the circle
            return distance <= sphere.Radius;
        }
        public static bool Collide(Sphere sphere1, Sphere sphere2)
        {
            // Calculate distance between centers of spheres
            double distance = Math.Sqrt(Math.Pow((sphere1.Center.X - sphere2.Center.X), 2) +
                                        Math.Pow((sphere1.Center.Y - sphere2.Center.Y), 2));

            // Check if sum of radii is greater than distance between centers
            if ((sphere1.Radius + sphere2.Radius) > distance)
                return true;
            else
                return false;
        }

    }
}
