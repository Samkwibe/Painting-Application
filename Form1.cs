/* Painting  Group Project
 Samuel Kiwbe

 */




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;




namespace Paint_Group_Project
{
    public partial class Paint_Group_Project : Form
    {
        Pen p = new Pen(Color.Blue, 8);
        int x, y, h, w;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Paint" + " Samuel raymond");
        }

        

        public Paint_Group_Project()
        {
            InitializeComponent();
        }

        private void Paint_Group_Project_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void Paint_Group_Project_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g=this.CreateGraphics();
            h = e.X - x;
            w = e.Y - y;   
            Rectangle shape = new Rectangle(x, y, w, h);    
            if(Cercle1.Checked)
            {
                g.DrawEllipse(p, shape);
            }
            else if (Rectangle2.Checked) 
            {
             
                g.DrawRectangle(p, shape);
            }
            else if (Square4.Checked) 
            { 
                g.DrawRectangle(p, shape);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }




    }

}
