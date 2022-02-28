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
    public partial class Frm02_1_Compound_CalcForm : Form
    {
        public Frm02_1_Compound_CalcForm()
        {
            InitializeComponent();
        }

        double Start_Money;
        double Rate;
        double Times;
        double Result;

        private void btn04_ClearUp_Click(object sender, EventArgs e)
        {
            txtBox01_start_money.Text = "0";
            txtBox02_rate.Text = "0";
            txtBox03_times.Text = "0";
            txtBox04__total_return.Text = "";
        }

        private void btn01_return_per_month_Click(object sender, EventArgs e)
        {
            //STEP.1    確認文字方塊內是否正確輸入數字；若非預期輸入，則以文字方塊或Label提醒
            //STEP.2    通過判斷後，將數字提取出來

            bool isNum_txtBox01 = double.TryParse(txtBox01_start_money.Text, out Start_Money);
            bool isNum_txtBox02 = double.TryParse(txtBox02_rate.Text, out Rate);
            bool isNum_txtBox03 = double.TryParse(txtBox03_times.Text, out Times);

            if (isNum_txtBox01 && isNum_txtBox02 && isNum_txtBox03)
            {
                //  MessageBox.Show("轉型成功, \n"+"m1= " + Start_Money +"\n"+"m2= "+Rate +"\n" + "m3= " + Times);
                Rate = Rate / 100;

                //STEP.3    將數字做複利計算，可練習在Utility.cs建立計算複利用的方法

                double tmp;
                tmp = Start_Money;

                for (int cnt=0; cnt<Times; cnt++)
                {
                    //  MessageBox.Show("目前跑了: "+(cnt+1)+"次");      //測試for迴圈次數用
                    tmp = tmp * (Rate + 1);
                }

                Result = (int)Math.Round(tmp);

                //STEP.4    於本利和顯示結果

                txtBox04__total_return.Text = Result.ToString();  //double轉string


                /* 存到全域變數，在印出報表的功能使用 */
                Compound.start_money= txtBox01_start_money.Text;
                Compound.rate = txtBox02_rate.Text;
                Compound.times = txtBox03_times.Text; 
                Compound.total_return= Result.ToString();
            }
            else
            {
                MessageBox.Show("請填入正確數字", "複利計算器提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            /*                                                               //測試 class 和 method 用
            MyClass test01 = new MyClass();
            test01.Method_01_SayHello();
            */
        }

        private void btn02_money_earned_Click(object sender, EventArgs e)
        {
            double Earned_Money = Result - Start_Money;
            MessageBox.Show("在這次的投資裡，一共賺了 $ "+Earned_Money, "淨賺金額");
        }

        private void btn03_data_report_Click(object sender, EventArgs e)
        {
            Frm02_2_ReportForm s = new Frm02_2_ReportForm();
            s.Show();
            
        }
    }

    partial class MyClass
    {
        void Method_03_Check()
        {
            MessageBox.Show("");
        }
    }

}
