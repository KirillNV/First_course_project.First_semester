using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_for_Prog
{
    class Figure : TrajectoryNew
    {
        private double a = 100;
        private double b = 100;
    }
    public override void Draw(PictureBox pb) // передаем рисунок в PictureBox
    {                                        //Модификатор override требуется для расширения или изменения абстрактной или виртуальной реализации
        xStart = pb.Width / 2;// начало отсчета - центр PictureBox
        yStart = pb.Height / 2;
        injection = 0;
        
        graphic = pb.CreateGraphics();// используем его для графика

        graphic.Clear(Color.White);// закрашиваем всю область в белый цвет, при каждом выводе метода
        pen = new Pen(Color.Black, 2f); // создаем ручку с выбранным цветом
        points = new Point[400];

        step = Math.PI * 2 / points.Length;
        
        for (int i = 0; i < points.Length; i++) // цилк для нахождения координат точек
        {
            x = xStart - a * injection / (Math.PI * 2) * scale;
            y = yStart - b * Math.Sin(injection) * scale;
            points[i] = new Point((int)x, (int)y);
            injection = injection + step;
        }// После отрисовки получили, что у рисунка не соединены начальные и конечные точки

        Point[] pointsForHelp = new Point[2];// для этого добавим доп массив и внесем в него перую и последнюю точку из основного массива
        pointsForHelp[0] = points[0];
        pointsForHelp[1] = points[points.Length - 1];

        graphic.DrawLines(pen, points); // Рисунок графика
        graphic.DrawLines(pen, pointsForHelp);// рисунок, которые соединяет начальную и конченую точки
    }
}
