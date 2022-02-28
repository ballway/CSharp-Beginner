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
    public partial class Frm12_ReadWriteForm : Form
    {
        public Frm12_ReadWriteForm()
        {
            InitializeComponent();
        }

        private void btn01_Read_Click(object sender, EventArgs e)
        {
            StreamReader strRead = new StreamReader("讀檔練習用.txt", Encoding.UTF8);
            txtbox_ReadWrite.Text = strRead.ReadToEnd();
            strRead.Close();
        }

        private void btn02_Write_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("建立檔案練習用.txt", FileMode.Create);
            
            StreamWriter strWrite = new StreamWriter(fs, Encoding.UTF8);
            strWrite.Write(txtbox_ReadWrite.Text);
            strWrite.Close();
            fs.Close();
        }
    }
}
