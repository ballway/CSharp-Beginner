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
    public partial class Frm04_MethodForm : Form
    {
        public Frm04_MethodForm()
        {
            InitializeComponent();
        }

        int check = 0;  //  用來避免事件無上限的增加

        private void btn02_add_Register1_Click(object sender, EventArgs e)
        {
           if(check==0)
            {
                btn01_Register1.Click += new EventHandler(btn01_Register1_Click);
                check += 1;
            }
            
        }

        private void btn01_Register1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, I'm Register1");
            
        }

        private void btn03_erase_Register1_Click(object sender, EventArgs e)
        {
            btn01_Register1.Click -= new EventHandler(btn01_Register1_Click);
            if(check==1)
            {
                check = 0;
            }
        }

        int current_cnt;

        private void btn04_Add1_Click(object sender, EventArgs e)
        {
            current_cnt++;
            label1_cnt_num.Text = "目前數字 = "+current_cnt;
        }

        private void btn05_Minus1_Click(object sender, EventArgs e)
        {
            current_cnt--;
            label1_cnt_num.Text = "目前數字 = " + current_cnt;
        }

        private void btn05_to_zero_Click(object sender, EventArgs e)
        {
            current_cnt = 0;
            label1_cnt_num.Text = "目前數字 = " + current_cnt;
        }

        private void btn06_static_practice_Click(object sender, EventArgs e)
        {
            
            ///  測試Utility.cs裡的 static變數 ///

            my_Static_Test.StaticVar++;
            MessageBox.Show("cnt= "+ my_Static_Test.StaticVar);

            ///  測試Utility.cs裡的 非static變數 ///

            my_Static_Test m_RT = new my_Static_Test();
            m_RT.NonStaticVar++;
            MessageBox.Show("Non Static cnt= " + m_RT.NonStaticVar);
            
        }

        int btn07_click_cnt = 0;

        private void btn07_tenary_operator_practice_Click(object sender, EventArgs e)
        {
            btn07_click_cnt++;
            btn07_tenary_operator_practice.Text = "計數: "+btn07_click_cnt;

            string result = (btn07_click_cnt >= 2) ? "超過2了" : "還沒超過2";       // 使用三元運算子的敘述
            label4.Text = result;
        }

        private void btn08_switch_practice_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("請問今天會下雨嗎?", "問題", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("會下雨，要帶傘喔");
                    break;

                case DialogResult.No:
                    MessageBox.Show("不會下雨，放心出門吧");
                    break;

                case DialogResult.Cancel:
                    MessageBox.Show("不知道欸");
                    break;
            }
        }

        private void btn08_array_practice_Click(object sender, EventArgs e)
        {
            int[] num = new int[5];
            num[0] = 1;
            num[1] = 3;
            num[2] = 5;
            num[3] = 50;
            num[4] = 100;

            int sum = 0;
            string result = "num[5] ={ ";

            /*
            for(int x=0; x<5; x++)
            {
                result += num[x] + "  ";
                sum = sum + num[x];
            }
            */

            foreach(int item in num)    //試用foreach迴圈來存取陣列裡的值
            {
                result += item + " ";
                sum = sum + item;
            }

            result += "}\n";
            result += "每項相加= " + sum;

            label_result_array.Text = result;
        }

        private void btn09_array_2_practice_Click(object sender, EventArgs e)
        {
            int[,] num = new int[2,4];
            num[0,0] = 1;           num[1, 0] = 53;
            num[0,1] = 3;           num[1, 1] = 6;
            num[0,2] = 5;           num[1, 2] = 8;
            num[0,3] = 50;         num[1, 3] = 9;

            int sum = 0;
            int num_max, num_min;
            string result="";

            num_max = num[0, 0];
            num_min = num[0, 0];

            for (int x=0; x<num.GetLength(0); x++)
            {
                for(int y=0; y<num.GetLength(1); y++)
                {
                    sum = sum + num[x, y];
                    if (num_max < num[x, y]) num_max = num[x, y];
                    if (num_min > num[x, y]) num_min = num[x, y];
                    result += "num[ " + x + " , " + y + " ] = " + num[x, y];
                    result += "\n";
                }
                result += "\n";
            }
            result += "sum= " + sum + "\n";
            result += "max= " + num_max + "\n";
            result += "min= " + num_min + "\n";

            label_result_array.Text ="結果在對話方塊";
            MessageBox.Show(result);
        }

        private void btn10_array_3_practice_Click(object sender, EventArgs e)
        {
            string result="";

            int total_member = 3;

            Member[] arr_member = new Member[ total_member ];
            
            for(int cnt=0; cnt<total_member; cnt++)
            {
                arr_member[cnt] = new Member();
            }

            arr_member[0].name = "小陳";
            arr_member[0].age = 25;

            arr_member[1].name = "小詹";
            arr_member[1].age = 24;

            arr_member[2].name = "小李";
            arr_member[2].age = 30;

            int max_age = arr_member[0].age;
            int old_index=0;

            for(int cnt=0; cnt<arr_member.GetLength(0); cnt++)
            {
                if(max_age< arr_member[cnt].age)
                {
                    max_age = arr_member[cnt].age;
                    old_index = cnt;
                }
                result += "member[" + cnt + "]  姓名: " + arr_member[cnt].name + ", " + arr_member[cnt].age + "歲\n";
            }

            // 印出結果
            result += "年紀最大的是 " + arr_member[old_index].name + " ,是 " + arr_member[old_index].age + "歲";
            label_result_array.Text = result;

        }

        private void btn10_array_4_practice_Click(object sender, EventArgs e)
        {
            int[] num = CreatArray(3);     //這邊填入要建立的陣列長度
            int max = num[0];
            string result = "";

            for(int cnt=0; cnt<num.GetLength(0); cnt++)
            {
                if (max < num[cnt]) max = num[cnt];
                result += "num[" + cnt + "]=" + num[cnt] + "\n";
            }
            result += "max=" + max;
            label_result_array.Text = result + "\n";
        }

        int[] CreatArray(int how_long)      //  用來建立陣列的方法，回傳值格式是整數陣列 int[]
        {
            int[] arr = new int[how_long];

            for(int cnt=0; cnt<how_long; cnt++)
            {
                arr[cnt] = cnt + 10;    //給陣列填入資料，這邊以索引值+10為例
            }

            return arr;
        }

        private void btn11_swap_int_practice_Click(object sender, EventArgs e)
        {
            int num_1 = 100;
            int num_2 = 200;

            MessageBox.Show("數字1=" + num_1 + "  數字2=" + num_2);
            swap(ref num_1, ref num_2);
            MessageBox.Show("數字1=" + num_1 + "  數字2=" + num_2);
        }

        private void btn12_swap_string_practice_Click(object sender, EventArgs e)
        {
            string str_1 = "AAA";
            string str_2 = "BBB";

            MessageBox.Show("字串1=" + str_1 + "  字串2=" + str_2);
            swap(ref str_1, ref str_2);
            MessageBox.Show("字串1=" + str_1 + "  字串2=" + str_2);
        }

        //  Overload 同名方法
        void swap (ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        void swap(ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }

        // Generic泛用方法
        void Generic_swap<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }

        private void btn13_swap_int_practice_Click(object sender, EventArgs e)
        {
            int num_1 = 100;
            int num_2 = 200;

            MessageBox.Show("數字1=" + num_1 + "  數字2=" + num_2);
            Generic_swap<int>(ref num_1, ref num_2);     //  呼叫泛用方法Generic_swap，T填入int型態
            MessageBox.Show("數字1=" + num_1 + "  數字2=" + num_2);
        }

        private void btn14_swap_string_practice_Click(object sender, EventArgs e)
        {
            string str_1 = "AAA";
            string str_2 = "BBB";

            MessageBox.Show("字串1=" + str_1 + "  字串2=" + str_2);
            Generic_swap<string>(ref str_1, ref str_2);     //  呼叫泛用方法Generic_swap，T填入string型態
            MessageBox.Show("字串1=" + str_1 + "  字串2=" + str_2);
        }

        private void btn15_random_practice_Click(object sender, EventArgs e)
        {
            int[] lottery = new int[6];
            Random Generate = new Random(Guid.NewGuid().GetHashCode());     //Guid.NewGuid().GetHashCode()  亂數種子加在小括號裡

            for (int x=0; x<lottery.GetLength(0); x++)
            {
                lottery[x] = Generate.Next(1, 50);      // 範圍: 1~49

                for(int y=0; y<x; y++)
                {
                    while( lottery[x]==lottery[y] )     //避免產生重複的亂數
                    {
                        lottery[x] = Generate.Next(1, 50);
                        y = 0;
                    }
                }
            }
            
            //lottery[0] = Generate.Next(0, 50);
            label_result_random.Text = "" + lottery[0];
            label_result_random.Text += "  " + lottery[1];
            label_result_random.Text += "  " + lottery[2];
            label_result_random.Text += "  " + lottery[3];
            label_result_random.Text += "  " + lottery[4];
            label_result_random.Text += "  " + lottery[5];
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            Frm03_POSForm frm03 = new Frm03_POSForm();
            frm03.Show();
        }
    }
}
