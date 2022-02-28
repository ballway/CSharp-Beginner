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
    public partial class Frm13_1_GuessForm : Form
    {
        public Frm13_1_GuessForm()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            label_result_show.Text = "介於 " + 0 + " 到 " + 100 + " 之間"; 


            Random r = new Random();
            Guess.ans = r.Next(1, 100);

            Guess.Main_Guess_Form = this;

            Frm13_2_InputForm s = new Frm13_2_InputForm();
            s.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + Guess.ans);
        }
    }
}
