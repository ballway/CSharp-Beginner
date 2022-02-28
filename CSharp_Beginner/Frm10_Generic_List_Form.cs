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
    public partial class Frm10_Generic_List_Form : Form
    {
        public Frm10_Generic_List_Form()
        {
            InitializeComponent();
        }

        List<Employee> List_2_Employee = new List<Employee>();

        private void btn01_Input_Click(object sender, EventArgs e)
        {
            Employee input_data;

            input_data.name = txtBox01_zh_Name.Text;
            input_data.age = int.Parse(txtBox02_age.Text);

            List_2_Employee.Add(input_data);    //每按一下，新增一個Employee資料型態的資料進去ArrayList裡面

            label_result_data.Text = "";    //每次印出前都先清空字串內容

            
            //for (int i = 0; i < List_2_Employee.Count; i++)       //使用for迴圈來印出list裡的資料
            //{
            //    label_result_data.Text += "姓名" + List_2_Employee[i].name ;
            //    label_result_data.Text += ", 年齡: " + List_2_Employee[i].age;
            //    label_result_data.Text += "\n"; 
            //}

            foreach(Employee item in List_2_Employee)           //使用foreach迴圈來印出list裡的資料
            {
                label_result_data.Text += "姓名" + item.name;
                label_result_data.Text += ", 年齡: " + item.age;
                label_result_data.Text += "\n";
            }
        }
    }
}
