using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_for_Prog
{
    public abstract class Trajectory
    {
        public double injection { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double xStart { get; set; }
        public double yStart { get; set; }
        public Graphics graphic { get; set; }

        private Point[] points = new Point[150];
        public Point[] Points { get { return points; } private set { } }

        public double step { get; set; }

        private double scale = 1;

        public double Scale { get { return scale; } set { scale = value; } }


        private Color pictureBoxColor = Color.White; // для изменения цвета рабочий области

        public Color PictureBoxColor
        {
            get { return pictureBoxColor; }
            set { pictureBoxColor = value; }
        }

        private Color trajectoryColor = Color.Black; //для изменения цвета траектории
        public Color TrajectoryColor
        {
            get { return trajectoryColor; }
            set { trajectoryColor = value; } 
        }
        public Pen pen { get; set; }

        public Pen penObject { get; set; }       // Для отедльной отрисовки объекта
        private Color objectColor = Color.Black; 

        public Color ObjectColor
        {
            get { return objectColor; }
            set { objectColor = value; }
        }

        

        public abstract void Draw(PictureBox pb);
    }
}
