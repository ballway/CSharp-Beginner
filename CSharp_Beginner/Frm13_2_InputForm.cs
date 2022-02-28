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
    public partial class Frm13_2_InputForm : Form
    {
        public Frm13_2_InputForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        int input;
        int min = 0;
        int max = 100;

        private void button_enter_Click(object sender, EventArgs e)
        {
            bool isNum = int.TryParse(txtBox01_Input.Text, out input);
            if( isNum==true )
            {
                Guess.try_guess = input;

                if (Guess.try_guess == Guess.ans)
                {
                    //Guess.show_result = "Correct !!";
                    Guess.Main_Guess_Form.label_result_show.Text = "Correct !!";
                }
                else if (Guess.try_guess != Guess.ans)
                {
                    //Guess.show_result = "Keep trying...";
                    //Guess.Main_Guess_Form.label_result_show.Text = "Keep trying...";

                    if( min < Guess.try_guess && Guess.try_guess < Guess.ans )
                    {
                        min = input;
                        Guess.Main_Guess_Form.label_result_show.Text = "介於 "+min+ " 到 "+max+ " 之間";
                    }

                    if ( Guess.ans < Guess.try_guess  &&  Guess.try_guess < max )
                    {
                        max = input;
                        Guess.Main_Guess_Form.label_result_show.Text = "介於 " + min + " 到 " + max + " 之間";
                    }
                }
            }
            else if (isNum == false)
            {
                //MessageBox.Show("請輸入1-100的數字");
                Guess.Main_Guess_Form.label_result_show.Text = "請輸入1-100的數字";
                Guess.try_guess = 0;
            }
        }
    }
}
