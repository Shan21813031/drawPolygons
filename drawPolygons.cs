using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Graphics3
{


    public partial class drawPolygons : Form
    {
        /// Unit 6: Tasks 6.3
        /// Shan Ahmed
        /// </summary>
        /// 

        private int x = 150, y = 100, size = 100;
        public drawPolygons()
        {
            InitializeComponent();
        }

        private void drawPolygons_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;                // get a graphics object
            Pen myPen = new Pen(Color.Red, 10);  	// create a new red pen

            Point[] shape = new Point[]
            {
                new Point(x, y),
                new Point(x + size, y),
                new Point(x * 2, y + size),
                new Point(x + size, y * 3),
                new Point(x, y * 3),
                new Point(100, 200)
            };
            

            g.DrawPolygon(myPen, shape);             // draw shape using red`pen
            g.FillPolygon(Brushes.Red, shape);   // fill shape using a yellow brush 
            Font myFont = new Font("Arial", 30);
            g.DrawString("Shan's Hexagon", myFont, Brushes.Blue, 100, 300);
            BackColor = Color.Yellow;

        }


    }
}