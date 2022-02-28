using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Beginner
{
    public partial class Frm14_PictureForm : Form
    {
        public Frm14_PictureForm()
        {
            InitializeComponent();

            foreach (Control item in this.flowLayoutPanel1.Controls)
            {
                if (item is PictureBox)
                {
                    item.Click += PicBox_Click;
                }
            }
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            Form s = new Form();

            s.BackgroundImage = ((PictureBox)sender).Image;
            s.BackgroundImageLayout = ImageLayout.Zoom;
            s.WindowState = FormWindowState.Maximized;
            s.Show();

        }
    }
}