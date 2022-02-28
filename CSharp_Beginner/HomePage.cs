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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn01_HelloForm_Click(object sender, EventArgs e)
        {
            //Frm01_HelloForm frm01 = new Frm01_HelloForm();
            //frm01.Show();

            this.splitContainer2.Panel2.Controls.Clear();
            Frm01_HelloForm frm01 = new Frm01_HelloForm();
            frm01.TopLevel = false;
            frm01.Show();
            this.splitContainer2.Panel2.Controls.Add(frm01);

            /*
            MyClass mc = new MyClass();     //練習使用自己建的類別Myclass裡寫的方法(Method)
            mc.Method_01_SayHello();
            */
        }

        private void btn02_CompoundForm_Click(object sender, EventArgs e)
        {
            //Frm02_Compound_CalcForm frm02 = new Frm02_Compound_CalcForm();
            //frm02.Show();

            this.splitContainer2.Panel2.Controls.Clear();
            Frm02_1_Compound_CalcForm frm02 = new Frm02_1_Compound_CalcForm();
            frm02.TopLevel = false;
            frm02.Show();
            this.splitContainer2.Panel2.Controls.Add(frm02);
        }

        private void btn03_POSForm_Click(object sender, EventArgs e)
        {
            //Frm03_POSForm frm03 = new Frm03_POSForm();
            //frm03.Show();

            this.splitContainer2.Panel2.Controls.Clear();
            Frm03_POSForm frm03 = new Frm03_POSForm();
            frm03.TopLevel = false;
            frm03.Show();
            this.splitContainer2.Panel2.Controls.Add(frm03);
        }

        private void btn04_MethodForm_Click(object sender, EventArgs e)
        {
            //Frm04_MethodForm frm04 = new Frm04_MethodForm();
            //frm04.Show();

            this.splitContainer2.Panel2.Controls.Clear();
            Frm04_MethodForm frm04 = new Frm04_MethodForm();
            frm04.TopLevel = false;
            frm04.Show();
            this.splitContainer2.Panel2.Controls.Add(frm04);
        }


        private void btn05_ScreenSaver_Click(object sender, EventArgs e)
        {
            //Frm05_ScreenSaverForm frm05 = new Frm05_ScreenSaverForm();
            //frm05.Show();

            this.splitContainer2.Panel2.Controls.Clear();
            Frm05_ScreenSaverForm frm05 = new Frm05_ScreenSaverForm();
            frm05.Show();
        }

        private void btn06_ForLoopForm_Click(object sender, EventArgs e)
        {
            //Frm06_LoopForm frm06 = new Frm06_LoopForm();
            //frm06.Show();

            this.splitContainer2.Panel2.Controls.Clear();
            Frm06_LoopForm frm06 = new Frm06_LoopForm();
            frm06.TopLevel = false;
            frm06.Show();
            this.splitContainer2.Panel2.Controls.Add(frm06);
        }

        private void btn07_CalculatorForm_Click(object sender, EventArgs e)
        {
            //Frm07_CalculatorForm frm07 = new Frm07_CalculatorForm();
            //frm07.Show();

            this.splitContainer2.Panel2.Controls.Clear();
            Frm07_CalculatorForm frm07 = new Frm07_CalculatorForm();
            frm07.TopLevel = false;
            frm07.Show();
            this.splitContainer2.Panel2.Controls.Add(frm07);
        }

        private void btn08_Student_GradeForm_Click(object sender, EventArgs e)
        {
            //Frm08_Student_GradeForm frm08 = new Frm08_Student_GradeForm();
            //frm08.Show();

            this.splitContainer2.Panel2.Controls.Clear();
            Frm08_Student_GradeForm frm08 = new Frm08_Student_GradeForm();
            frm08.TopLevel = false;
            frm08.Show();
            this.splitContainer2.Panel2.Controls.Add(frm08);
        }

        private void btn09_ArrayList_Form_Click(object sender, EventArgs e)
        {
            //Frm09_ArrayList_Form frm09 = new Frm09_ArrayList_Form();
            //frm09.Show();

            this.splitContainer2.Panel2.Controls.Clear();
            Frm09_ArrayList_Form frm09 = new Frm09_ArrayList_Form();
            frm09.TopLevel = false;
            frm09.Show();
            this.splitContainer2.Panel2.Controls.Add(frm09);
        }

        private void btn10_Generic_List_Form_Click(object sender, EventArgs e)
        {
            //Frm10_Generic_List_Form frm10 = new Frm10_Generic_List_Form();
            //frm10.Show();

            this.splitContainer2.Panel2.Controls.Clear();
            Frm10_Generic_List_Form frm10 = new Frm10_Generic_List_Form();
            frm10.TopLevel = false;
            frm10.Show();
            this.splitContainer2.Panel2.Controls.Add(frm10);
        }


        bool change_color_flag = true;
        private void btn00_Change_Color_Click(object sender, EventArgs e)
        {
            btn00_Change_Color.BackColor = change_color_flag? Color.White : Color.SkyBlue;
            change_color_flag = !change_color_flag;
        }

        private void btn11_Path_Form_Click(object sender, EventArgs e)
        {
            //Frm11_PathForm frm11 = new Frm11_PathForm();
            //frm11.Show();

            this.splitContainer2.Panel2.Controls.Clear();
            Frm11_PathForm frm11 = new Frm11_PathForm();
            frm11.TopLevel = false;
            frm11.Show();
            this.splitContainer2.Panel2.Controls.Add(frm11);
        }

        private void btn12_ReadWrite_Form_Click(object sender, EventArgs e)
        {
            //Frm12_ReadWriteForm frm12 = new Frm12_ReadWriteForm();
            //frm12.Show();

            this.splitContainer2.Panel2.Controls.Clear();
            Frm12_ReadWriteForm frm12 = new Frm12_ReadWriteForm();
            frm12.TopLevel = false;
            frm12.Show();
            this.splitContainer2.Panel2.Controls.Add(frm12);
        }

        private void btn13_GuessForm_Click(object sender, EventArgs e)
        {
            //Frm13_GuessForm frm13 = new Frm13_GuessForm();
            //frm13.Show();

            this.splitContainer2.Panel2.Controls.Clear();
            Frm13_1_GuessForm frm13 = new Frm13_1_GuessForm();
            frm13.TopLevel = false;
            frm13.Show();
            this.splitContainer2.Panel2.Controls.Add(frm13);
        }

        private void btn14_PictureForm_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            Frm14_PictureForm frm14 = new Frm14_PictureForm();
            frm14.TopLevel = false;
            frm14.Show();
            this.splitContainer2.Panel2.Controls.Add(frm14);
        }



        /*
        void ShowHelloForm()    //練習建的方法，用來打開HelloForm
        {
            Frm01_HelloForm frm01 = new Frm01_HelloForm();
            frm01.Show();
            //this.splitContainer2.Panel2.Controls.Add();   //把form歸類到splicantainer的指定panel，方便清除之類的控制
        }
        */

    }
}
