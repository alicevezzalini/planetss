using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planetss
{
    public partial class Form1 : Form
    {
        Planetario planetario = new Planetario();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.WindowState = FormWindowState.Maximized;

            Pianeta p = new Pianeta(200, Vector.Parse("500;400"), Vector.Parse("1;1"), Color.AliceBlue);
            Pianeta p1 = new Pianeta(20, Vector.Parse("600;350"), Vector.Parse("5;5"), Color.DarkGreen);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
