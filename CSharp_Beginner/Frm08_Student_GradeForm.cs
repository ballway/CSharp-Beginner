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
    public partial class Frm08_Student_GradeForm : Form
    {
        public Frm08_Student_GradeForm()
        {
            InitializeComponent();
        }

        string result_a, result_b, result_c;
        Student_Grade My;
        

        private void btn01_Input_Click(object sender, EventArgs e)
        {
            My.Name = txtBox01_Name.Text;
            bool isNum_A = double.TryParse( txtBox02_Grade_Chinese.Text , out My.Chinese);
            bool isNum_B = double.TryParse(txtBox03_Grade_English.Text, out My.English);
            bool isNum_C = double.TryParse(txtBox04_Grade_Math.Text, out My.Math);

            if( My.Name!="" && isNum_A && isNum_B && isNum_C )     //如果輸入格式正確
            {
                result_a = "姓名 : " + My.Name+ "\n國文 : " +
                    My.Chinese+ "\n英文 : " + My.English+ "\n數學 : " + My.Math;

                double Max = GetMax(My.Chinese, My.English, My.Math);
                double Min = GetMin(My.Chinese, My.English, My.Math);

                result_b = "最高分: ";

                if (My.Chinese == Max)
                {
                    result_b += "國文";
                }

                if (My.English == Max) 
                {
                    if ( My.Chinese == Max ) result_b += ", ";
                    result_b += "英文";
                } 
                if (My.Math == Max)             
                {
                    if ( My.Chinese == Max || My.English == Max ) result_b += ", ";
                    result_b += "數學";
                }

                result_b += "= " + Max + " 分\n";


                result_b += "最低分: ";

                if (My.Chinese == Min)
                {
                    result_b += "國文";
                }

                if (My.English == Min)
                {
                    if (My.Chinese == Min) result_b += ", ";
                    result_b += "英文";
                }
                if (My.Math == Min)
                {
                    if ( My.Chinese == Min || My.English == Min ) result_b += ", ";
                    result_b += "數學";
                }

                result_b += "= " + Min + " 分\n";

                double tmp = My.Chinese + My.English + My.Math;
                My.Avg = tmp / 3;
                double rounded_avg = Math.Round(My.Avg, 2, MidpointRounding.AwayFromZero);
                result_c = "平均分 = " + rounded_avg;
            }
            else
            {
                result_a = "*請依正確格式輸入*";
                result_b = "最高 / 最低分";

                RefreshScore();
            }
        }

        private void btn02_Show_Click(object sender, EventArgs e)
        {
            RefreshScore();
        }

        private void btn03_ClearUp_Click(object sender, EventArgs e)
        {
            My.Chinese = 0;
            My.English = 0;
            My.Math = 0;

            result_a = "成績紀錄";
            result_b = "最高 / 最低分";
            result_c = "平均分";
            RefreshScore();
        }

        void RefreshScore()
        {
            label_result_data.Text = result_a;
            label_result_compared.Text = result_b;
            label_result_average.Text = result_c;
        }

        double GetMax(double num1, double num2, double num3)    //得到最大值
        {
            double Max = num1;
            if (num2 > Max)     Max = num2;
            if (num3 > Max)     Max = num3;
            return Max;
        }

        double GetMin(double num1, double num2, double num3)    //得到最大值
        {
            double Min = num1;
            if (num2 < Min)     Min = num2;
            if (num3 < Min)     Min = num3;
            return Min;
        }

    }
}
