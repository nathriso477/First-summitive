using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

// Created by Nathan
// Date: Sept 2016
// Purpose: to use graphics objects and timing effects

namespace First_summitive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.Size = new Size(720, 480);
            //BackgroundImageLayout = ImageLayout.Tile;
        }

        private void Form1_Click(object sender, EventArgs e)
        {

            Graphics fg = this.CreateGraphics();

            Font drawFont = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            fg.DrawString("Merry", drawFont, drawBrush, 150, 40);
            Thread.Sleep(1000);

            Refresh();

            Font newfont = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush drawBrush2 = new SolidBrush(Color.Green);

            fg.DrawString("Christmas", drawFont, drawBrush2, 250, 40);

            Thread.Sleep(1000);

            Refresh();

            SolidBrush drawBrush3 = new SolidBrush(Color.White);
            fg.Clear(Color.Black);
            Pen drawPen = new Pen(Color.White, 10);
            fg.FillEllipse(drawBrush3, 25, 25, 5, 5);
            fg.FillEllipse(drawBrush3, 37, 46, 10,10 );
            fg.FillEllipse(drawBrush3, 70, 75, 5, 5);
            fg.FillEllipse(drawBrush3, 65, 65, 10, 10);

            

            fg.FillEllipse(drawBrush3, 100, 25, 5, 5);
            //fg.FillEllipse(drawBrush3, 100, 50, 10, 10);

        }


    }
}