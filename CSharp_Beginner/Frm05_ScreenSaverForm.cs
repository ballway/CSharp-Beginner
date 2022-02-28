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
    public partial class Frm05_ScreenSaverForm : Form
    {
        public Frm05_ScreenSaverForm()
        {
            InitializeComponent();
        }

        const int left = 20, right = 30;
        const int up = 40, down = 50;
        int pattern1_x = left, pattern1_y = up;
        int pattern2_x = right, pattern2_y = up;

        private void Frm05_ScreenSaverForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm05_ScreenSaverForm_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveCube_Pattern1(pictureBox1);
            MoveCube_Pattern2(pictureBox2);
        }

        void MoveCube_Pattern1(Control item)
        {
                //  往左上移動
                //item.Left -= 5;
                //item.Top -= 5;

                if (item.Left <= 0)    //如果到左邊邊界，開始往右
                {
                    pattern1_x = right;
                }
                else if (item.Left + item.Width >= this.Width)    // TODO如果到右邊邊界，開始往左
                {
                    pattern1_x = left;
                }

                if (item.Top <= 0)     //如果到上面邊界，開始往下
                {
                    pattern1_y = down;
                }
                else if (item.Top + item.Height >= this.Height)    // TODO如果到下邊邊界，開始往上
                {
                    pattern1_y = up;
                }

                //  左右移動
                if (pattern1_x == left)                item.Left -= 5;
                else if (pattern1_x == right)     item.Left += 5;

                //  上下移動
                if (pattern1_y == up)                 item.Top -= 3;
                else if (pattern1_y == down)   item.Top += 3;
            
        }

        void MoveCube_Pattern2(Control item)
        {
            if (item.Left <= 0)    //如果到左邊邊界，開始往右
            {
                pattern2_x = right;
            }
            else if (item.Left + item.Width >= this.Width)    // TODO如果到右邊邊界，開始往左
            {
                pattern2_x = left;
            }

            if (item.Top <= 0)     //如果到上面邊界，開始往下
            {
                pattern2_y = down;
            }
            else if (item.Top + item.Height >= this.Height)    // TODO如果到下邊邊界，開始往上
            {
                pattern2_y = up;
            }

            //  左右移動
            if (pattern2_x == left) item.Left -= 6;
            else if (pattern2_x == right) item.Left += 6;

            //  上下移動
            if (pattern2_y == up) item.Top -= 2;
            else if (pattern2_y == down) item.Top += 2;

        }
    }
}
