using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double height;
        double weight;
        double BMI;
        bool isMan;
        private void button1_Click(object sender, EventArgs e)
        {
            height = Convert.ToDouble(height1.Text) / 100;
            weight = Convert.ToDouble(weight1.Text);
            BMI = Math.Round(weight / (height * height));
            trackBar1.Value = Convert.ToInt32(BMI);
            if (trackBar1.Value < 19)
            {
                if (isMan == true)
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("Mac\\Home\\Desktop\\image\\bmi-underweight-icon.png");
                    labelCondition.Text = "Недостаточный";
                }
                else
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("Mac\\Home\\Desktop\\image\\bmi-underweight-icon.png");
                    labelCondition.Text = "Недостаточный";
                }
            }
            if (trackBar1.Value >= 19 && trackBar1.Value < 25)
            {
                if (isMan == true)
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("Mac\\Home\\Desktop\\image\\bmi-healthy-icon.png");
                    labelCondition.Text = "Здоровый";
                }
                else
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("Mac\\Home\\Desktop\\image\\bmi-healthy-icon.png");
                    labelCondition.Text = "Здоровый";
                }

            }
            if (trackBar1.Value >= 25 && trackBar1.Value < 30)
            {
                if (isMan == true)
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("Mac\\Home\\Desktop\\image\\bmi-overweight-icon.png");
                    labelCondition.Text = "Избыточный";
                }
                else
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("Mac\\Home\\Desktop\\image\\bmi-overweight-icon.png");
                    labelCondition.Text = "Избыточный";
                }

            }
            if (trackBar1.Value >= 30)
            {
                if (isMan == true)
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("Mac\\Home\\Desktop\\image\\bmi-obese-icon.png");
                    labelCondition.Text = "Ожирение";
                }
                else
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("Mac\\Home\\Desktop\\image\\bmi-obese-icon.png");
                    labelCondition.Text = "Ожирение";
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            weight1.Text = null;
            height1.Text = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox.Image = System.Drawing.Image.FromFile("Mac\\Home\\Desktop\\image\\bmi-healthy-icon.png");
            isMan = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox.Image = System.Drawing.Image.FromFile("Mac\\Home\\Desktop\\image\\bmi-healthy-icon.png");
            isMan = true;
        }
    }
}
