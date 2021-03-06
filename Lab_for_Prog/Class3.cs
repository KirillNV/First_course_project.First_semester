using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_for_Prog
{
    public abstract class Trajectory
    {
        public double Injection { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double XStart { get; set; }
        public double YStart { get; set; }
        public Graphics TrajecGraphic { get; set; }

        private Point[] trajecPoints = new Point[400];
        public Point[] TrajecPoints { get { return trajecPoints; } private set { } }

        public double Step { get; set; }

        private double scale = 1;

        public double Scale { get { return scale; } set { scale = value; } }

        public Pen TrajecPen { get; set; }

        public abstract void Draw(PictureBox pb);
    }
