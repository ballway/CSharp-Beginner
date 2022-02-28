using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSharp_Beginner
{
    public partial class Frm11_PathForm : Form
    {
        public Frm11_PathForm()
        {
            InitializeComponent();
        }

        private void btn01_show_result_Click(object sender, EventArgs e)
        {
            //string strPath = "path.txt";
            string strPath = "house222.jpg";
            string result = "";

            //result = Path.GetFullPath(strPath) + "\n";
            result += Path.GetExtension(strPath);
            //result += Path.GetTempPath(strPath);
            label_result.Text = result;
        }
    }
}
