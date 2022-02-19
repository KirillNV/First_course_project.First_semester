using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_for_Prog
{
    abstract class MovingObject
    {
        //передаем траекторию, в которой будет двигаться точка/объект 
         
        public MovingObject(Trajectory trajectory)
        {
            Trajectory = trajectory;
        }

        public Trajectory Trajectory { get; set; }
        public int xPoint { get; set; }
        public int yPoint { get; set; }
        private int i = 0;
        private int speed = 1;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        private bool indicator = false;


        // Реализуем движение точки/объекта по траектории
        protected void MoveCentralPoint(PictureBox pb)
        {
            Trajectory.Draw(pb);
            if (indicator)
            {
                if (i >= Trajectory.Points.Length - 1)
                {
                    indicator = false;
                }
                else
                {
                   
                     //проверка во избежания исключения ArrayOutOfBound
                    
                    if (i < 0)
                        i = 0;
                    xPoint = Trajectory.Points[i].X;
                    yPoint = Trajectory.Points[i].Y;
                    i = i + speed;
                }
            }
            else
            {
                if (i == 0 || i < 0)
                {
                    indicator = true;
                }
                else
                {
                   
                    if (i > Trajectory.Points.Length - 1)
                        i = Trajectory.Points.Length - 1;

                    xPoint = Trajectory.Points[i].X;
                    yPoint = Trajectory.Points[i].Y;
                    i = i - speed;
                }
            }
        }
        public abstract void Move(PictureBox pb);
    }
}
