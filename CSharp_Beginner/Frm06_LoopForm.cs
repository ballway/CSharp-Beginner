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
    public partial class Frm06_LoopForm : Form
    {
        public Frm06_LoopForm()
        {
            InitializeComponent();
        }


        private void btn01_multiplication_table_Click(object sender, EventArgs e)
        {
            label_Result.Text = "九九乘法表\n";
            for (int i = 1; i <= 9; i++)
            {
                for (int y = 2; y <= 9; y++)
                {
                    label_Result.Text += $"{y, -5:N0}x{i , -5:N0}={(y* i), -5}|";
                }
                label_Result.Text += "\n";
            }

            /*
            label_Result.Text = "";
            //印出九九乘法表

            int num_A , num_B=9;
            int num_AxB;

            for(num_A=2 ; num_A<num_B+1 ; num_A++)
            {
                for(int cnt=1 ; cnt<10; cnt++)
                {
                    num_AxB = num_A * cnt;
                    //label_Result.Text += num_A + "x" + cnt + "=" + num_AxB.ToString("00") + " | ";
                    //label_Result.Text += "\t";
                    label_Result.Text += $"{num_A , 2}x{cnt, 2 }={(num_A*cnt),2 }|";
                }
                label_Result.Text += "\n";
                label_Result.BackColor = SystemColors.Info;     //  label加黃底
            }
            */
        }

        // 以下是會取用 textBox 的功能

        int input;


        private void btn00_clear_up_Click(object sender, EventArgs e)
        {
            label_Result.Text = "請按任意按鈕";
            label_Result.BackColor = SystemColors.Control;  //  label原底色

            bool isNum_txtBox01 = Int32.TryParse(txtBox01_Input.Text, out input);

            if (isNum_txtBox01)
            {
                input = 0;
                txtBox01_Input.Text = "" + input;
            }
            else
            {
                input = 0;
                txtBox01_Input.Text = "" + input;
            }
        }

        private void btn02_print_star_Click(object sender, EventArgs e)
        {
            label_Result.Text = "";

            bool isNum_txtBox01 = Int32.TryParse(txtBox01_Input.Text, out input);

            if( isNum_txtBox01 )
            {
                build_tree_1();

                label_Result.BackColor = SystemColors.Info;     //  label加黃底
            }
            else
            {
                MessageBox.Show("請輸入整數");
            }
        }


        private void btn00_add_Click(object sender, EventArgs e)
        {
            bool isNum_txtBox01 = Int32.TryParse(txtBox01_Input.Text, out input);

            if (isNum_txtBox01)
            {
                Input_add(ref input);
            }
            else
            {
                //  MessageBox.Show("請輸入整數");
                input = 0;
                Input_add(ref input);
            }
        }

        private void btn00_minus_Click(object sender, EventArgs e)
        {
            bool isNum_txtBox01 = Int32.TryParse(txtBox01_Input.Text, out input);

            if (isNum_txtBox01)
            {
                Input_minus(ref input);
            }
            else
            {
                //  MessageBox.Show("請輸入整數");
                input = 0;
                Input_minus(ref input);
            }
        }

        /// 以下是方法們 ///

        void build_tree_1()     //把樹印出來(簡單版)
        {
            if( input > 0 )
            {
                // 輸入數值為正，印樹
                for (int cnt_a = 0; cnt_a < input; cnt_a++)
                {
                    for (int cnt_b = 0; cnt_b < cnt_a + 1; cnt_b++)
                    {
                        label_Result.Text += "*";
                    }
                    label_Result.Text += "\n";
                }
            }
            else
            {
                MessageBox.Show("請輸入正整數");
            }
            
        }

        void Input_add(ref int x)   // 練習使用 ref 來同時讀取和修改值 (加法)
        {
            x++;
            txtBox01_Input.Text = "" + x;
        }

        void Input_minus(ref int x)   // 練習使用 ref 來同時讀取和修改值 (減法)
        {
            x--;
            txtBox01_Input.Text = "" + x;
        }

        static string MyParams()    //TODO 練習用 ....未完成...
        {
            return "";
        }

        private void btn03_while_number_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            string result = "";
            while (cnt < input)
            {
                result += cnt + " ";
                cnt++;
            }
            label_Result.Text = result;
        }
    }
}
