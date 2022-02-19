using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_for_Prog
{
    public class Figure : Trajectory
    {
        private double a = 160;
        private double b = 160;


        public override void Draw(PictureBox pb) // передаем рисунок в PictureBox
        {                                        //Модификатор override требуется для расширения или изменения абстрактной или виртуальной реализации
            xStart = pb.Width / 2;// начало отсчета - центр PictureBox
            yStart = pb.Height / 2;
            injection = 0;

            graphic = pb.CreateGraphics();// используем его для графика

            graphic.Clear(PictureBoxColor);// закрашиваем всю область в белый цвет,
                                           // при каждом выводе метода

            pen = new Pen(TrajectoryColor, 2f); // создаем ручку с выбранным цветом

            step = Math.PI * 2 / Points.Length;
                
            for (int i = 0; i < Points.Length; i++) // цилк для нахождения координат точек
            {
                x = xStart - a * injection / (Math.PI * 2) * Scale;
                y = yStart - b * Math.Sin(injection) * Scale;
                Points[i] = new Point((int)x, (int)y);
                injection = injection + step;
            }// После отрисовки получили, что у рисунка не соединены начальные и конечные точки

            Point[] pointsForHelp = new Point[2];// для этого добавим доп массив и внесем в него перую и последнюю точку из основного массива
            pointsForHelp[0] = Points[0];
            pointsForHelp[1] = Points[Points.Length - 1];

            graphic.DrawLines(pen, Points); // Рисунок графика
            graphic.DrawLines(pen, pointsForHelp);// рисунок, которые соединяет начальную и конченую точки
            penObject = new Pen(ObjectColor, 3f); 
            
        }
    }
}
