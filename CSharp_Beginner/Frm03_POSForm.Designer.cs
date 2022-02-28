
namespace CSharp_Beginner
{
    partial class Frm03_POSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm03_POSForm));
            this.label01_menuTop = new System.Windows.Forms.Label();
            this.label02_PriceTop = new System.Windows.Forms.Label();
            this.label03_ShowPrice = new System.Windows.Forms.Label();
            this.label04_PayingTop = new System.Windows.Forms.Label();
            this.btn05_Cash = new System.Windows.Forms.Button();
            this.btn06_CreditCard = new System.Windows.Forms.Button();
            this.label05_ListTop = new System.Windows.Forms.Label();
            this.label06_List_Total = new System.Windows.Forms.Label();
            this.btn07_ClearUp = new System.Windows.Forms.Button();
            this.label_menu_box = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_credit_intro = new System.Windows.Forms.Label();
            this.btn04_coffee = new System.Windows.Forms.Button();
            this.btn03_pancake = new System.Windows.Forms.Button();
            this.btn02_burger = new System.Windows.Forms.Button();
            this.btn01_bagel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label01_menuTop
            // 
            this.label01_menuTop.AutoSize = true;
            this.label01_menuTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label01_menuTop.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label01_menuTop.Location = new System.Drawing.Point(104, 23);
            this.label01_menuTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label01_menuTop.Name = "label01_menuTop";
            this.label01_menuTop.Size = new System.Drawing.Size(108, 26);
            this.label01_menuTop.TabIndex = 0;
            this.label01_menuTop.Text = "菜單 Menu";
            this.label01_menuTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label02_PriceTop
            // 
            this.label02_PriceTop.AutoSize = true;
            this.label02_PriceTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label02_PriceTop.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label02_PriceTop.Location = new System.Drawing.Point(326, 61);
            this.label02_PriceTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label02_PriceTop.Name = "label02_PriceTop";
            this.label02_PriceTop.Size = new System.Drawing.Size(167, 26);
            this.label02_PriceTop.TabIndex = 0;
            this.label02_PriceTop.Text = "總金額 Total Price";
            this.label02_PriceTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label03_ShowPrice
            // 
            this.label03_ShowPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label03_ShowPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label03_ShowPrice.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label03_ShowPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label03_ShowPrice.Location = new System.Drawing.Point(326, 110);
            this.label03_ShowPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label03_ShowPrice.Name = "label03_ShowPrice";
            this.label03_ShowPrice.Size = new System.Drawing.Size(158, 48);
            this.label03_ShowPrice.TabIndex = 0;
            this.label03_ShowPrice.Text = "$ 0";
            this.label03_ShowPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label04_PayingTop
            // 
            this.label04_PayingTop.AutoSize = true;
            this.label04_PayingTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label04_PayingTop.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label04_PayingTop.Location = new System.Drawing.Point(360, 180);
            this.label04_PayingTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label04_PayingTop.Name = "label04_PayingTop";
            this.label04_PayingTop.Size = new System.Drawing.Size(88, 26);
            this.label04_PayingTop.TabIndex = 0;
            this.label04_PayingTop.Text = "付款方式";
            this.label04_PayingTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn05_Cash
            // 
            this.btn05_Cash.BackColor = System.Drawing.SystemColors.Info;
            this.btn05_Cash.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn05_Cash.Location = new System.Drawing.Point(324, 229);
            this.btn05_Cash.Margin = new System.Windows.Forms.Padding(2);
            this.btn05_Cash.Name = "btn05_Cash";
            this.btn05_Cash.Size = new System.Drawing.Size(77, 48);
            this.btn05_Cash.TabIndex = 6;
            this.btn05_Cash.Text = "現金";
            this.btn05_Cash.UseVisualStyleBackColor = false;
            this.btn05_Cash.Click += new System.EventHandler(this.btn05_Cash_Click);
            // 
            // btn06_CreditCard
            // 
            this.btn06_CreditCard.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn06_CreditCard.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn06_CreditCard.Location = new System.Drawing.Point(406, 229);
            this.btn06_CreditCard.Margin = new System.Windows.Forms.Padding(2);
            this.btn06_CreditCard.Name = "btn06_CreditCard";
            this.btn06_CreditCard.Size = new System.Drawing.Size(77, 48);
            this.btn06_CreditCard.TabIndex = 7;
            this.btn06_CreditCard.Text = "信用卡";
            this.btn06_CreditCard.UseVisualStyleBackColor = false;
            this.btn06_CreditCard.Click += new System.EventHandler(this.btn06_CreditCard_Click);
            // 
            // label05_ListTop
            // 
            this.label05_ListTop.AutoSize = true;
            this.label05_ListTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label05_ListTop.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label05_ListTop.Location = new System.Drawing.Point(592, 23);
            this.label05_ListTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label05_ListTop.Name = "label05_ListTop";
            this.label05_ListTop.Size = new System.Drawing.Size(124, 26);
            this.label05_ListTop.TabIndex = 0;
            this.label05_ListTop.Text = "購物清單 List";
            this.label05_ListTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label06_List_Total
            // 
            this.label06_List_Total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label06_List_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label06_List_Total.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label06_List_Total.Location = new System.Drawing.Point(512, 61);
            this.label06_List_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label06_List_Total.Name = "label06_List_Total";
            this.label06_List_Total.Size = new System.Drawing.Size(261, 210);
            this.label06_List_Total.TabIndex = 0;
            this.label06_List_Total.Text = "尚未點餐\r\n\r\n\r\n";
            this.label06_List_Total.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn07_ClearUp
            // 
            this.btn07_ClearUp.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn07_ClearUp.Location = new System.Drawing.Point(658, 282);
            this.btn07_ClearUp.Margin = new System.Windows.Forms.Padding(2);
            this.btn07_ClearUp.Name = "btn07_ClearUp";
            this.btn07_ClearUp.Size = new System.Drawing.Size(106, 42);
            this.btn07_ClearUp.TabIndex = 5;
            this.btn07_ClearUp.Text = "清除清單";
            this.btn07_ClearUp.UseVisualStyleBackColor = true;
            this.btn07_ClearUp.Click += new System.EventHandler(this.btn07_ClearUp_Click);
            // 
            // label_menu_box
            // 
            this.label_menu_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_menu_box.Location = new System.Drawing.Point(9, 15);
            this.label_menu_box.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_menu_box.Name = "label_menu_box";
            this.label_menu_box.Size = new System.Drawing.Size(287, 317);
            this.label_menu_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(308, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 238);
            this.label1.TabIndex = 0;
            // 
            // label_credit_intro
            // 
            this.label_credit_intro.AutoSize = true;
            this.label_credit_intro.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_credit_intro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_credit_intro.Location = new System.Drawing.Point(380, 310);
            this.label_credit_intro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_credit_intro.Name = "label_credit_intro";
            this.label_credit_intro.Size = new System.Drawing.Size(127, 16);
            this.label_credit_intro.TabIndex = 8;
            this.label_credit_intro.Text = "*註: 信用卡享九折優惠";
            // 
            // btn04_coffee
            // 
            this.btn04_coffee.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn04_coffee.BackgroundImage = global::CSharp_Beginner.Properties.Resources._04_coffee;
            this.btn04_coffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn04_coffee.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn04_coffee.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn04_coffee.ForeColor = System.Drawing.Color.White;
            this.btn04_coffee.Location = new System.Drawing.Point(162, 205);
            this.btn04_coffee.Margin = new System.Windows.Forms.Padding(2);
            this.btn04_coffee.Name = "btn04_coffee";
            this.btn04_coffee.Size = new System.Drawing.Size(118, 120);
            this.btn04_coffee.TabIndex = 4;
            this.btn04_coffee.Text = "咖啡\r\nCoffee\r\nNTD$75";
            this.btn04_coffee.UseVisualStyleBackColor = false;
            this.btn04_coffee.Click += new System.EventHandler(this.btn04_coffee_Click);
            // 
            // btn03_pancake
            // 
            this.btn03_pancake.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn03_pancake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn03_pancake.BackgroundImage")));
            this.btn03_pancake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn03_pancake.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn03_pancake.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn03_pancake.ForeColor = System.Drawing.Color.White;
            this.btn03_pancake.Location = new System.Drawing.Point(27, 205);
            this.btn03_pancake.Margin = new System.Windows.Forms.Padding(2);
            this.btn03_pancake.Name = "btn03_pancake";
            this.btn03_pancake.Size = new System.Drawing.Size(118, 120);
            this.btn03_pancake.TabIndex = 3;
            this.btn03_pancake.Text = "鬆餅\r\nPancake\r\nNTD$69";
            this.btn03_pancake.UseVisualStyleBackColor = false;
            this.btn03_pancake.Click += new System.EventHandler(this.btn03_pancake_Click);
            // 
            // btn02_burger
            // 
            this.btn02_burger.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn02_burger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn02_burger.BackgroundImage")));
            this.btn02_burger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn02_burger.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn02_burger.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn02_burger.ForeColor = System.Drawing.Color.White;
            this.btn02_burger.Location = new System.Drawing.Point(162, 72);
            this.btn02_burger.Margin = new System.Windows.Forms.Padding(2);
            this.btn02_burger.Name = "btn02_burger";
            this.btn02_burger.Size = new System.Drawing.Size(118, 120);
            this.btn02_burger.TabIndex = 2;
            this.btn02_burger.Text = "漢堡\r\nBurger\r\nNTD$48\r\n";
            this.btn02_burger.UseVisualStyleBackColor = false;
            this.btn02_burger.Click += new System.EventHandler(this.btn02_burger_Click);
            // 
            // btn01_bagel
            // 
            this.btn01_bagel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn01_bagel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn01_bagel.BackgroundImage")));
            this.btn01_bagel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn01_bagel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn01_bagel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn01_bagel.ForeColor = System.Drawing.Color.White;
            this.btn01_bagel.Location = new System.Drawing.Point(27, 72);
            this.btn01_bagel.Margin = new System.Windows.Forms.Padding(2);
            this.btn01_bagel.Name = "btn01_bagel";
            this.btn01_bagel.Size = new System.Drawing.Size(118, 120);
            this.btn01_bagel.TabIndex = 1;
            this.btn01_bagel.Text = "現烤焙果\r\nBagel\r\nNTD$55";
            this.btn01_bagel.UseVisualStyleBackColor = false;
            this.btn01_bagel.Click += new System.EventHandler(this.btn01_bagel_Click);
            // 
            // Frm03_POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 360);
            this.Controls.Add(this.label_credit_intro);
            this.Controls.Add(this.btn07_ClearUp);
            this.Controls.Add(this.btn06_CreditCard);
            this.Controls.Add(this.btn05_Cash);
            this.Controls.Add(this.btn04_coffee);
            this.Controls.Add(this.btn03_pancake);
            this.Controls.Add(this.btn02_burger);
            this.Controls.Add(this.btn01_bagel);
            this.Controls.Add(this.label03_ShowPrice);
            this.Controls.Add(this.label06_List_Total);
            this.Controls.Add(this.label05_ListTop);
            this.Controls.Add(this.label04_PayingTop);
            this.Controls.Add(this.label02_PriceTop);
            this.Controls.Add(this.label01_menuTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_menu_box);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm03_POSForm";
            this.ShowIcon = false;
            this.Text = "POS點餐系統";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label01_menuTop;
        private System.Windows.Forms.Button btn01_bagel;
        private System.Windows.Forms.Button btn02_burger;
        private System.Windows.Forms.Button btn03_pancake;
        private System.Windows.Forms.Button btn04_coffee;
        private System.Windows.Forms.Label label02_PriceTop;
        private System.Windows.Forms.Label label03_ShowPrice;
        private System.Windows.Forms.Label label04_PayingTop;
        private System.Windows.Forms.Button btn05_Cash;
        private System.Windows.Forms.Button btn06_CreditCard;
        private System.Windows.Forms.Label label05_ListTop;
        private System.Windows.Forms.Label label06_List_Total;
        private System.Windows.Forms.Button btn07_ClearUp;
        private System.Windows.Forms.Label label_menu_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_credit_intro;
    }
}