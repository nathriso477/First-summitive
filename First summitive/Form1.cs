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

// Created by Nathan.Rison
// Date: November 10 2016
// Purpose: to use graphics objects and timing effects

namespace First_summitive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //play a sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.sparkle);
            player.Play();

            // draws words
            Graphics fg = this.CreateGraphics();
            Font drawFont = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            fg.DrawString("Merry", drawFont, drawBrush, 150, 40);
            Thread.Sleep(1000);
            Font newfont = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush drawBrush2 = new SolidBrush(Color.Green);
            fg.DrawString("Christmas", drawFont, drawBrush2, 250, 40);
            Thread.Sleep(1000);
            SolidBrush drawBrush3 = new SolidBrush(Color.White);
            fg.Clear(Color.Black);
            Pen drawPen = new Pen(Color.White, 1);
            SolidBrush drawbrush4 = new SolidBrush(Color.Blue);
            Thread.Sleep(1000);
            //draw dots
            fg.FillEllipse(drawbrush4, 250, 50, 25, 25);
            fg.FillEllipse(drawbrush4, 354, 175, 25, 25);
            fg.FillEllipse(drawbrush4, 450, 50, 25, 25);
            fg.FillEllipse(drawbrush4, 150, 175, 25, 25);
            fg.FillEllipse(drawbrush4, 550, 175, 25, 25);
            fg.FillEllipse(drawbrush4, 250, 300, 25, 25);
            fg.FillEllipse(drawbrush4, 450, 300, 25, 25);
            Thread.Sleep(1000);

            //draw lines
            fg.DrawLine(drawPen, 250, 60, 470, 60);
            Thread.Sleep(1000);
            fg.DrawLine(drawPen, 250, 60, 360, 190);
            Thread.Sleep(1000);
            fg.DrawLine(drawPen, 360, 190, 265, 307);
            Thread.Sleep(1000);
            fg.DrawLine(drawPen, 265, 307, 160, 180);
            Thread.Sleep(1000);
            fg.DrawLine(drawPen, 160, 180, 360, 190);
            Thread.Sleep(1000);
            fg.DrawLine(drawPen, 360, 190, 566, 185);
            Thread.Sleep(1000);
            fg.DrawLine(drawPen, 566, 185, 470, 60);
            Thread.Sleep(1000);
            fg.DrawLine(drawPen, 250, 60, 160, 180);
            Thread.Sleep(1000);
            fg.DrawLine(drawPen, 360, 190, 470, 60);
            Thread.Sleep(1000);
            fg.DrawLine(drawPen, 360, 190, 470, 315);
            Thread.Sleep(1000);
            fg.DrawLine(drawPen, 470, 315, 265, 307);
            Thread.Sleep(1000);
            fg.DrawLine(drawPen, 566, 185, 470, 315);
            Thread.Sleep(1500);

            //plays a sound
            player = new SoundPlayer(Properties.Resources.merryxmas);
            player.Play();

            //displays different text
            label3.Visible = true;
            fg.Clear(Color.Black);
            Thread.Sleep(1500);
            ouputLable1.Visible = true;
            Thread.Sleep(1000);
            ouputlabel2.Visible = true;
            Thread.Sleep(1000);
            outputlabel3.Visible = true;

        }
    }
}