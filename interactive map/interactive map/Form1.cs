using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interactive_map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = true;
            label7.Text = "МЦК Лужники";
            pictureBox6.Location = new Point(633, 516);
            label5.Location = new Point(748, 549);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label7.Visible = true;
            label7.Text = "Парк Горького";
            pictureBox6.Location = new Point(633, 516);
            label5.Location = new Point(748, 549);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = true;
            label7.Visible = true;
            label7.Text = "МИД";
            pictureBox6.Location = new Point(633, 423);
            label5.Location = new Point(748, 453);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label7.Text = "Новодевичей монастырь";
            pictureBox6.Location = new Point(633, 516);
            label5.Location = new Point(748, 549);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = true;
            label7.Text = "Метро Киевская";
            pictureBox6.Location = new Point(633, 516);
            label5.Location = new Point(748, 549);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = true;
            label7.Text = "Здания РАН";
            pictureBox6.Location = new Point(633, 516);
            label5.Location = new Point(748, 549);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label7.Text = "Метро Воробевы горы";
            pictureBox6.Location = new Point(633, 516);
            label5.Location = new Point(748, 549);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label7.Text = "Стадион Лужники";
            pictureBox6.Location = new Point(633, 516);
            label5.Location = new Point(748, 549);
        }
    }
}
