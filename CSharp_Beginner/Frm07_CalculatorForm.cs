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
    public partial class Frm07_CalculatorForm : Form
    {
        public Frm07_CalculatorForm()
        {
            InitializeComponent();
        }

        //  類別變數  //
        double num_1, num_2=1;      // 測試階段，num_2暫時先設1
        double result;
        int zero_not_first=0;
        string tmp;

        //  使用enum來辨認功能，初始先設為清空狀態
        Calculaor_Action Current_Action = Calculaor_Action.ClearUp;
        

        /*  以下是功能鍵  */

        private void btn_clearup_Click(object sender, EventArgs e)
        {
            //num_1 = 0;
            //num_2 = 0;
            //label_previous_record.Text = "";
            //tmp = "";
            //result = 0;
            //Current_Action = Calculaor_Action.ClearUp;
            //zero_not_first = 0;

            //RefreshLabel();
            ClearUp();
        }


        private void btn_function_plus_Click(object sender, EventArgs e)
        {
            if( Current_Action == Calculaor_Action.Equal )
            {
                tmp = "" + result;
            }

            Current_Action = Calculaor_Action.Operator_Add;    // 加的狀態

            //MessageBox.Show("加一下");
            if ( label_Result.Text != "" )      //要新增固定num_1的功能
            {
                SaveNum_1();
            }

            RefreshLabel(); //

        }

        private void btn_function_substract_Click(object sender, EventArgs e)
        {
            if (Current_Action == Calculaor_Action.Equal)
            {
                tmp = "" + result;
            }

            Current_Action = Calculaor_Action.Operator_Substract;    // 減的狀態

            //MessageBox.Show("減一下");
            if ( label_Result.Text != "" )
            {
                SaveNum_1();
            }
        }

        private void btn_function_multiply_Click(object sender, EventArgs e)
        {
            if (Current_Action == Calculaor_Action.Equal)
            {
                tmp = "" + result;
            }

            Current_Action = Calculaor_Action.Operator_Multiply;    // 乘的狀態

            //MessageBox.Show("乘一下");
            if (label_Result.Text != "")
            {
                SaveNum_1();
            }
        }

        private void btn_function_divide_Click(object sender, EventArgs e)
        {
            if (Current_Action == Calculaor_Action.Equal)
            {
                tmp = "" + result;
            }

            Current_Action = Calculaor_Action.Operator_Divide;    // 除的狀態

            //MessageBox.Show("除一下");
            if (label_Result.Text != "")
            {
                SaveNum_1();
            }
        }

        private void btn_function_remainder_Click(object sender, EventArgs e)
        {
            if (Current_Action == Calculaor_Action.Equal)
            {
                tmp = "" + result;
            }

            Current_Action = Calculaor_Action.Operator_Remainder;    // 餘的狀態

            //MessageBox.Show("餘一下");
            if (label_Result.Text != "")
            {
                SaveNum_1();
            }
        }


        private void btn_function_equal_Click(object sender, EventArgs e)
        {
            SaveNum_2();

            switch (Current_Action)
            {
                case Calculaor_Action.Operator_Add:
                    result = num_1 + num_2;
                    break;

                case Calculaor_Action.Operator_Substract:
                    result = num_1 - num_2;
                    break;

                case Calculaor_Action.Operator_Multiply:
                    result = num_1 * num_2;
                    break;

                case Calculaor_Action.Operator_Divide:
                    result = num_1 / num_2;
                    break;

                case Calculaor_Action.Operator_Remainder:
                    result = num_1 % num_2;
                    break;
            }

            num_2 = 0;

            // label_previous_record.Text = "" + num_1+ " # " + num_2 + " = ";
            //MessageBox.Show(""+result);
            label_Result.Text = "" + result;

            Current_Action = Calculaor_Action.Equal;    //  等於的狀態
        }

        /*  以下是數字鍵  */

        private void btn_num_0_Click(object sender, EventArgs e)
        {
            if (Current_Action == Calculaor_Action.Equal)
            {
                ClearUp();
            }

            //  TODO 判斷0是不是第一個輸入的數字
            if ( zero_not_first==1 )     //  如果零不是第一個輸入的字，則可以直接加在字串後面
            {
                tmp += "0";
                RefreshLabel();
            }
            else if( zero_not_first==0 )    //  如果零是第一個輸入的字，則避免重複接零在尾數
            {
                tmp = "0";
                RefreshLabel();
            }
        }

        private void btn_num_1_Click(object sender, EventArgs e)
        {
            // 要新增怎麼處理現有數字的方法
            //if( Current_Action == Calculaor_Action.Equal )
            //{
            //    ClearUp();
            //}

            Put_Num_to_Label(1);
        }

        private void btn_num_2_Click(object sender, EventArgs e)
        {
            //if (Current_Action == Calculaor_Action.Equal)
            //{
            //    ClearUp();
            //}

            Put_Num_to_Label(2);
        }

        private void btn_num_3_Click(object sender, EventArgs e)
        {
            //if (Current_Action == Calculaor_Action.Equal)
            //{
            //    ClearUp();
            //}

            Put_Num_to_Label(3);
        }

        private void btn_num_4_Click(object sender, EventArgs e)
        {
            //if (Current_Action == Calculaor_Action.Equal)
            //{
            //    ClearUp();
            //}

            Put_Num_to_Label(4);
        }

        private void btn_num_5_Click(object sender, EventArgs e)
        {
            //if (Current_Action == Calculaor_Action.Equal)
            //{
            //    ClearUp();
            //}

            Put_Num_to_Label(5);
        }

        private void btn_num_6_Click(object sender, EventArgs e)
        {
            //if (Current_Action == Calculaor_Action.Equal)
            //{
            //    ClearUp();
            //}

            Put_Num_to_Label(6);
        }

        private void btn_num_7_Click(object sender, EventArgs e)
        {
            //if (Current_Action == Calculaor_Action.Equal)
            //{
            //    ClearUp();
            //}

            Put_Num_to_Label(7);
        }

        private void btn_num_8_Click(object sender, EventArgs e)
        {
            //if (Current_Action == Calculaor_Action.Equal)
            //{
            //    ClearUp();
            //}

            Put_Num_to_Label(8);
        }

        private void btn_num_9_Click(object sender, EventArgs e)
        {
            //if (Current_Action == Calculaor_Action.Equal)
            //{
            //    ClearUp();
            //}

            Put_Num_to_Label(9);
        }



        ///  方法們  ///

        void SaveNum_1()
        {
            bool isNum = double.TryParse(tmp, out num_1);     //  從字串提取數字1
            label_previous_record.Text = "" + tmp;
            tmp = "";   //清空輸入欄

            switch( Current_Action )
            {
                case Calculaor_Action.Operator_Add:
                    label_previous_record.Text += " + ";
                    break;

                case Calculaor_Action.Operator_Substract:
                    label_previous_record.Text += " - ";
                    break;

                case Calculaor_Action.Operator_Multiply:
                    label_previous_record.Text += " x ";
                    break;

                case Calculaor_Action.Operator_Divide:
                    label_previous_record.Text += " ÷ ";
                    break;

                case Calculaor_Action.Operator_Remainder:
                    label_previous_record.Text += " % ";
                    break;
            }
            RefreshLabel();
        }


        void SaveNum_2()
        {
            bool isNum = double.TryParse(tmp, out num_2);     //  從字串提取數字1
            label_previous_record.Text += "" + tmp;
            //label_previous_record.Text += " =";

            tmp = "";   //清空輸入欄

            RefreshLabel();
        }



        void RefreshLabel()
        {
            label_Result.Text = "" + tmp;
        }

        void Put_Num_to_Label(int num_index)
        {
            if (Current_Action == Calculaor_Action.Equal)
            {
                ClearUp();
            }

            if (tmp == "0")     //若輸入欄位只有0，直接覆蓋
            {
                zero_not_first = 1;

                tmp = ""+num_index;
                RefreshLabel();
            }
            else  // 預設情況
            {
                zero_not_first = 1;

                tmp += ""+num_index;
                RefreshLabel();
            }
        }

        void ClearUp()
        {
            num_1 = 0;
            num_2 = 0;
            label_previous_record.Text = "";
            tmp = "";
            result = 0;
            Current_Action = Calculaor_Action.ClearUp;
            zero_not_first = 0;

            RefreshLabel();
        }
    }
}

/*

    150+8
   if(no_more_input==false)
    {
            ""+1+5+0;
    }

    ""+8
    double num_1 double.parse()
    num_2
    result= num_1
    
    if(string.Length==9)
    {
        bool no_more_input==true;
    }
    
*/