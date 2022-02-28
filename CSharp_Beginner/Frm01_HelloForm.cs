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
    public partial class Frm01_HelloForm : Form
    {
        public Frm01_HelloForm()
        {
            InitializeComponent();
        }

        private void btn01_Input_Click(object sender, EventArgs e)
        {
            string zh_Name = txtBox01_zh_Name.Text;
            string en_Name = txtBox02_en_Name.Text;
            string sex = txtBox03_sex.Text;
            string age = txtBox04_age.Text;

            string result = "你好，" + zh_Name + "\n" + "Hello, " +
                en_Name + "\n你的性別是：" + sex + "\n" + "你今年" + age + "歲";
            
            if(zh_Name!="" && en_Name != "" && sex != "" && age != "")
            {
                MessageBox.Show(result);
            }
            else if(zh_Name == "" || en_Name == "" || sex == "" || age == "")
            {
                MessageBox.Show("請填入完整資料");
            }
            
        }

        private void btn02_ClearUp_Click(object sender, EventArgs e)
        {
            txtBox01_zh_Name.Text = "";
            txtBox02_en_Name.Text = "";
            txtBox03_sex.Text = "";
            txtBox04_age.Text = "";
        }
    }
}
