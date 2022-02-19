using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_for_Prog
{
    class ObjectForMoving : MovingObject
    {
        public ObjectForMoving(Trajectory trajectory) : base(trajectory)
        {
            
        }
        
        public static int sizeOfObject1 = 1;
        public static int SizeOfObject1
        {
            get { return sizeOfObject1; }
            set { sizeOfObject1 = value; }
        }

        public static int sizeOfObject2 = 2;
        public static int SizeOfObject2
        {
            get { return sizeOfObject2; }
            set { sizeOfObject2 = value; }
        }

        public static int sizeOfObject3 = 3;
        public static int SizeOfObject3
        {
            get { return sizeOfObject3; }
            set { sizeOfObject3 = value; }
        }

        public static int sizeOfObject4 = 4;
        public static int SizeOfObject4
        {
            get { return sizeOfObject4; }
            set { sizeOfObject4 = value; }
        }

        public Point[] figureParts = new Point[12];

        public static double SpeedOfBreathing = 1; //Для контроля скорости дыхания при помощи Трекбара
        public static void Wait(double timeInSeconds) // Используем для пауз при отрисовке, для создания дыхания
        {
            Thread.Sleep((int)(timeInSeconds * 500 * SpeedOfBreathing));
        }
        
        public override void Move(PictureBox pb)
        {
            base.MoveCentralPoint(pb);
            

             for ( int n = 0; n < 9;) // Для отрисовки фигуры для дыхания
             {
                
                   // По точкам по принципу змейка рисуем нужную нам фигру
                 figureParts[0] = new Point(xPoint + n * SizeOfObject4, yPoint);
                 figureParts[1] = new Point(xPoint + n * SizeOfObject4, yPoint + n * SizeOfObject3);
                 figureParts[2] = new Point(xPoint - n * SizeOfObject4, yPoint + n * SizeOfObject3);
                 figureParts[3] = new Point(xPoint - n * SizeOfObject4, yPoint);
                 figureParts[4] = new Point(xPoint + n * SizeOfObject3, yPoint);
                 figureParts[5] = new Point(xPoint + n * SizeOfObject3, yPoint - n * SizeOfObject2);
                 figureParts[6] = new Point(xPoint - n * SizeOfObject1, yPoint - n * SizeOfObject2);
                 figureParts[7] = new Point(xPoint - n * SizeOfObject1, yPoint - n * SizeOfObject3);
                 figureParts[8] = new Point(xPoint + n * SizeOfObject1, yPoint - n * SizeOfObject3);
                 figureParts[9] = new Point(xPoint + n * SizeOfObject1, yPoint - n * SizeOfObject2);
                 figureParts[10] = new Point(xPoint -n * SizeOfObject3, yPoint -n * SizeOfObject2);
                 figureParts[11] = new Point(xPoint -n * SizeOfObject3, yPoint);

                 Trajectory.graphic.DrawPolygon(Trajectory.penObject, figureParts);

                n += 3 ;
                Wait(1);

                
             }

        }
    }
}

