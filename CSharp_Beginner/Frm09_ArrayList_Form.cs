using System;
using System.Collections;
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
    public partial class Frm09_ArrayList_Form : Form
    {
        public Frm09_ArrayList_Form()
        {
            InitializeComponent();
        }

        ArrayList List_Employee = new ArrayList();      //設成類別變數的ArrayList

        private void btn01_Input_Click(object sender, EventArgs e)
        {
            /*  實作使用struct來存資料到集合裡，索引會比較乾淨  */
            Employee input_data;
            
            input_data.name = txtBox01_zh_Name.Text;
            input_data.age = int.Parse(txtBox02_age.Text);

            List_Employee.Add( input_data );    //每按一下，新增一個Employee資料型態的資料進去ArrayList裡面

            label_result_data.Text = "";    //每次印出前都先清空字串內容

            for (int i = 0; i < List_Employee.Count; i++)
            {
                label_result_data.Text += "姓名: " + ((Employee)List_Employee[i]).name;
                label_result_data.Text += ", 年齡: " + ((Employee)List_Employee[i]).age;
                label_result_data.Text += "\n";
            }

            //////////////////////////////////////////////////////////////////////////////////

            /*  一開始的練習，不用struct來存資料到集合裡  */

            //string Name = txtBox01_zh_Name.Text;
            //int Age = int.Parse(txtBox02_age.Text);

            //List_Employee.Add(Name);
            //List_Employee.Add(Age);

            //label_result_data.Text = "";    //每次印出前都先清空字串內容


            //每次存string和int兩種資料型態，但索引會比較凌亂
            //for ( int i=0; i<List_Employee.Count; i=i+2 )
            //{
            //    label_result_data.Text += "姓名: " + (string)List_Employee[i];
            //    label_result_data.Text += ", 年齡: " + (int)List_Employee[i+1];       //不能在uboxing的時候輸出成string，原本是int
            //    label_result_data.Text += "\n";
            //}


            // 每次只存string
            //for (int i = 0; i < List_Employee.Count; i++)
            //{
            //    label_result_data.Text += "姓名: " + (string)List_Employee[i];
            //    label_result_data.Text += "\n";
            //}
        }
    }
}
