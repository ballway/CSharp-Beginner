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
    public partial class Frm03_POSForm : Form
    {
        public Frm03_POSForm()
        {
            InitializeComponent();
        }

        // POS_FOOD Food_1 = new POS_FOOD();   //ERROR: 類別不能在類別底下，應該用struct來存比較好

        int cnt_Food_Bagel = 0;
        int cnt_Food_Burger = 0;
        int cnt_Food_PanCake = 0;
        int cnt_Food_Coffee = 0;

        int sum_bagel = 0;
        int sum_burger = 0;
        int sum_pancake = 0;
        int sum_coffee = 0;

        int sum_all_food = 0;

        public void btn01_bagel_Click(object sender, EventArgs e)
        {
            cnt_Food_Bagel = cnt_Food_Bagel + 1;
            sum_bagel = cnt_Food_Bagel * 55;
            update_order();
        }

        private void btn02_burger_Click(object sender, EventArgs e)
        {
            cnt_Food_Burger = cnt_Food_Burger + 1;
            sum_burger = cnt_Food_Burger * 48;
            update_order();
        }

        private void btn03_pancake_Click(object sender, EventArgs e)
        {
            cnt_Food_PanCake = cnt_Food_PanCake + 1;
            sum_pancake= cnt_Food_PanCake * 69;
            update_order();
        }

        private void btn04_coffee_Click(object sender, EventArgs e)
        {
            cnt_Food_Coffee = cnt_Food_Coffee + 1;
            sum_coffee = cnt_Food_Coffee * 75;
            update_order();
        }

        void update_order()
        {
            string string_bagel="";
            string string_burger = "";
            string string_pancake = "";
            string string_coffee = "";

            if (cnt_Food_Bagel!=0)
            {
                string_bagel = "現烤焙果Bagel x"+cnt_Food_Bagel+",共NT$ "+sum_bagel+"元\n";
            }

            if (cnt_Food_Burger != 0)
            {
                string_burger = "漢堡Burger x" + cnt_Food_Burger + ",共NT$ " + sum_burger + "元\n";
            }

            if(cnt_Food_PanCake != 0)
            {
                string_pancake = "鬆餅Pancake x" + cnt_Food_PanCake + ",共NT$ " + sum_pancake + "元\n";
            }

            if (cnt_Food_Coffee != 0)
            {
                string_coffee = "咖啡Coffee x" + cnt_Food_Coffee + ",共NT$ " + sum_coffee + "元\n";
            }

            if(cnt_Food_Bagel==0 && cnt_Food_Burger==0 && cnt_Food_PanCake==0 && cnt_Food_Coffee==0)
            {
                label06_List_Total.Text = "尚未點餐";
            }
            else
            {
                //全部字串串接
                label06_List_Total.Text = string_bagel + string_burger + string_pancake + string_coffee;
            }

            sum_all_food = sum_bagel + sum_burger + sum_pancake + sum_coffee;
            label03_ShowPrice.Text = "$ " + sum_all_food;

        }

        private void btn07_ClearUp_Click(object sender, EventArgs e)
        {
            cnt_Food_Bagel = 0;
            cnt_Food_Burger = 0;
            cnt_Food_PanCake = 0;
            cnt_Food_Coffee = 0;

            sum_bagel = 0;
            sum_burger = 0;
            sum_pancake = 0;
            sum_coffee = 0;

            update_order();
        }

        private void btn05_Cash_Click(object sender, EventArgs e)
        {
            if(sum_all_food==0)
            {
                MessageBox.Show("尚未點餐 !", "POS 系統提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //MessageBox.Show("尚未點餐!");
            }
            else if(sum_all_food!=0)
            {
                MessageBox.Show("一共是 $" + sum_all_food + " 元");
            }
            
        }

        private void btn06_CreditCard_Click(object sender, EventArgs e)
        {
            double discount_sum = sum_all_food * 0.9;
            int credit_result = (int)Math.Round(discount_sum);
            
            if (sum_all_food == 0)
            {
                MessageBox.Show("尚未點餐 !", "POS 系統提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sum_all_food != 0)
            {
                //TODO 需再加上Double小數點進位實作
                MessageBox.Show("打折後一共是 $" + credit_result + " 元");
            }
        }
    }

}
