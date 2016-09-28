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

        }

        private void Form1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

            Graphics fg = this.CreateGraphics();

            Font drawFont = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            fg.DrawString("Merry", drawFont, drawBrush, 250, 40);
            Thread.Sleep(1000);

            Refresh();

            Font newfont = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush drawBrush2 = new SolidBrush(Color.Green);

            fg.DrawString("Christmas", drawFont, drawBrush2, 350, 40);

            Thread.Sleep(1000);

            Refresh();






        }
    }
}
