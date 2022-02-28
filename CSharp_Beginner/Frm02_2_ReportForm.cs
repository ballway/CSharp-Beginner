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
    public partial class Frm02_2_ReportForm : Form
    {
        public Frm02_2_ReportForm()
        {
            InitializeComponent();
            this.CenterToScreen();

            txtBox01_start_money.Text = Compound.start_money;
            txtBox02_rate.Text = Compound.rate;
            txtBox03_times.Text = Compound.times;
            txtBox04__total_return.Text = Compound.total_return;
        }

        
    }
}
