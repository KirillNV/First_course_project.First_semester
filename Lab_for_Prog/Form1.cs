using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_for_Prog
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            trajectory.TrajectoryColor = Color.Black;
            trajectory.ObjectColor = Color.Black;
            trajectory.TrajectoryColor = Properties.Settings.Default.SaveColorTrajectory;
            trajectory.ObjectColor = Properties.Settings.Default.SaveColorObject;
            trajectory.PictureBoxColor = Properties.Settings.Default.SaveColorPictureBox;
            trackBar.Value = Properties.Settings.Default.SaveTrajectoryOnTB;
            trackBarForObject.Value = Properties.Settings.Default.SaveSpeedObjectOnTB;
            trackBarForBreathing.Value = Properties.Settings.Default.SaveBteathingOnTB;
            Size = Properties.Settings.Default.WindowSize;
            Location = Properties.Settings.Default.WindowLocation;
        }

        static Trajectory trajectory = new Figure();
        MovingObject movingObject = new ObjectForMoving(trajectory);


        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            pictureBox.Height = ClientSize.Height;
            pictureBox.Width = ClientSize.Width / 2; // Размеры картинки зависият от длины и ширины
            trajectory.Draw(pictureBox);        // отрисовка графика

        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            trajectory.Scale = trackBar.Value / (double)(trackBar.Maximum - trackBar.Minimum);
            trajectory.Draw(pictureBox);
        }           //При передвижения бегунка будет меняться график

        private void pictureBox_Resize(object sender, EventArgs e)
        {
            pictureBox_Paint(sender, null);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            pictureBox_Resize(sender, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            movingObject.Move(pictureBox);
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void trackBarForObject_ValueChanged(object sender, EventArgs e)
        {
            movingObject.Speed = trackBarForObject.Value;
        }

        private void trackBarForBreathing_ValueChanged(object sender, EventArgs e)
        {
            ObjectForMoving.SpeedOfBreathing = trackBarForBreathing.Value;
        }

        public void Refreshing()
        {
            Refresh();
            trajectory.Draw(pictureBox);
        }
        
        private void radioButtonRed_Click(object sender, EventArgs e) // используем радиобаттен дря разных цветов
        {
            trajectory.TrajectoryColor = Color.Red;
            Refreshing();
        }

        private void radioButtonGreen_Click(object sender, EventArgs e)
        {
            trajectory.TrajectoryColor = Color.Green;
            Refreshing();
        }

        private void radioButtonBlue_Click(object sender, EventArgs e)
        {
            trajectory.TrajectoryColor = Color.Blue;
            Refreshing();
        }

        private void radioButtonTB1_Click(object sender, EventArgs e)
        {
            trajectory.PictureBoxColor = Color.LightSalmon;
            Refreshing();
        }

        private void radioButtonTB2_Click(object sender, EventArgs e)
        {
            trajectory.PictureBoxColor = Color.Aqua;
            Refreshing();
        }

        private void radioButtonTB3_Click(object sender, EventArgs e)
        {
            trajectory.PictureBoxColor = Color.Gray;
            Refreshing();
        }

        private void radioButtonObj1_Click(object sender, EventArgs e)
        {
            trajectory.ObjectColor = Color.Red;
            Refreshing();
        }

        private void radioButtonObj2_Click(object sender, EventArgs e)
        {
            trajectory.ObjectColor = Color.Green;
            Refreshing();
        }

        private void radioButtonObj3_Click(object sender, EventArgs e)//Конец цветов
        {
            trajectory.ObjectColor = Color.Blue;
            Refreshing();
        }
        
        private void textBoxForObjectSize1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ObjectForMoving.SizeOfObject1 = Int32.Parse(textBoxForObjectSize1.Text);
                Refreshing();
            }
            catch
            {
                MessageBox.Show("Нельзя вводить буквы или стирать! Введени новых значений допускается только выделением старых и изменении их на новые");
            }
        }


        private void textBoxForObjectSize2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ObjectForMoving.SizeOfObject2 = Int32.Parse(textBoxForObjectSize2.Text);
                Refreshing();
            }
            catch
            {
                MessageBox.Show("Нельзя вводить буквы или стирать! Введени новых значений допускается только выделением старых и изменении их на новые");
            }
        }

        private void textBoxForObjectSize3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ObjectForMoving.SizeOfObject3 = Int32.Parse(textBoxForObjectSize3.Text);
                Refreshing();
            }
            catch
            {
                MessageBox.Show("Нельзя вводить буквы или стирать! Введени новых значений допускается только выделением старых и изменении их на новые");
            }
        }

        private void textBoxForObjectSize4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ObjectForMoving.SizeOfObject4 = Int32.Parse(textBoxForObjectSize4.Text);
                Refreshing();
            }
            catch
            {
                MessageBox.Show("Нельзя вводить буквы или стирать! Введени новых значений допускается только выделением старых и изменении их на новые");
            }
        }

        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ObjectSettings1 = textBoxForObjectSize1.Text;
            Properties.Settings.Default.ObjectSettings2 = textBoxForObjectSize2.Text;
            Properties.Settings.Default.ObjectSettings3 = textBoxForObjectSize3.Text;
            Properties.Settings.Default.ObjectSettings4 = textBoxForObjectSize4.Text;
            Properties.Settings.Default.Save(); 

        }

        private void buttonBackSave_Click(object sender, EventArgs e)
        {
            textBoxForObjectSize1.Text = Properties.Settings.Default.ObjectSettings1;
            textBoxForObjectSize2.Text = Properties.Settings.Default.ObjectSettings2;
            textBoxForObjectSize3.Text = Properties.Settings.Default.ObjectSettings3;
            textBoxForObjectSize4.Text = Properties.Settings.Default.ObjectSettings4;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SaveColorTrajectory = trajectory.TrajectoryColor;
            Properties.Settings.Default.SaveColorPictureBox = trajectory.PictureBoxColor;
            Properties.Settings.Default.SaveColorObject = trajectory.ObjectColor;
            Properties.Settings.Default.SaveTrajectoryOnTB = trackBar.Value;
            Properties.Settings.Default.SaveSpeedObjectOnTB = trackBarForObject.Value;
            Properties.Settings.Default.SaveBteathingOnTB = trackBarForBreathing.Value;
            Properties.Settings.Default.WindowSize = Size;
            Properties.Settings.Default.WindowLocation = Location;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectForMoving.SizeOfObject1 = Int32.Parse(Clipboard.GetText());
            }
            catch
            {
                MessageBox.Show("Копировать только числа!");
            }
        }

        private void buttonFor2_Click(object sender, EventArgs e)
        {
            try
            { 
            ObjectForMoving.SizeOfObject2 = Int32.Parse(Clipboard.GetText());
            }
            catch
            {
                MessageBox.Show("Копировать только числа!");
            }
        }

        private void buttonFor3_Click(object sender, EventArgs e)
        {
            try
            { 
            ObjectForMoving.SizeOfObject3 = Int32.Parse(Clipboard.GetText());
            }
            catch
            {
                MessageBox.Show("Копировать только числа!");
            }
        }

        private void buttonFor4_Click(object sender, EventArgs e)
        { 
            try
            { 
            ObjectForMoving.SizeOfObject4 = Int32.Parse(Clipboard.GetText());
            }
            catch
            {
                MessageBox.Show("Копировать только числа!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }


    }
}
