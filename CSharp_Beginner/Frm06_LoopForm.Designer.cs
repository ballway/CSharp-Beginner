
namespace CSharp_Beginner
{
    partial class Frm06_LoopForm
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
            this.label_Border_Result = new System.Windows.Forms.Label();
            this.btn02_for_table = new System.Windows.Forms.Button();
            this.label_Result = new System.Windows.Forms.Label();
            this.btn01_for_star = new System.Windows.Forms.Button();
            this.btn00_clear_up = new System.Windows.Forms.Button();
            this.txtBox01_Input = new System.Windows.Forms.TextBox();
            this.label_Input = new System.Windows.Forms.Label();
            this.btn00_add = new System.Windows.Forms.Button();
            this.btn00_minus = new System.Windows.Forms.Button();
            this.label_for_border = new System.Windows.Forms.Label();
            this.label_for_top = new System.Windows.Forms.Label();
            this.label_while_border = new System.Windows.Forms.Label();
            this.btn04_while_table = new System.Windows.Forms.Button();
            this.btn03_while_number = new System.Windows.Forms.Button();
            this.label_while_top = new System.Windows.Forms.Label();
            this.label_do_border = new System.Windows.Forms.Label();
            this.btn06_do_table = new System.Windows.Forms.Button();
            this.btn05_do_star = new System.Windows.Forms.Button();
            this.label_do_top = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Border_Result
            // 
            this.label_Border_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Border_Result.Location = new System.Drawing.Point(33, 214);
            this.label_Border_Result.Name = "label_Border_Result";
            this.label_Border_Result.Size = new System.Drawing.Size(785, 297);
            this.label_Border_Result.TabIndex = 0;
            // 
            // btn02_for_table
            // 
            this.btn02_for_table.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn02_for_table.Location = new System.Drawing.Point(112, 157);
            this.btn02_for_table.Name = "btn02_for_table";
            this.btn02_for_table.Size = new System.Drawing.Size(148, 35);
            this.btn02_for_table.TabIndex = 1;
            this.btn02_for_table.Text = "九九乘法表";
            this.btn02_for_table.UseVisualStyleBackColor = true;
            this.btn02_for_table.Click += new System.EventHandler(this.btn01_multiplication_table_Click);
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.BackColor = System.Drawing.SystemColors.Control;
            this.label_Result.Font = new System.Drawing.Font("微軟正黑體", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Result.Location = new System.Drawing.Point(60, 235);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(92, 18);
            this.label_Result.TabIndex = 2;
            this.label_Result.Text = "請按任意按鈕";
            // 
            // btn01_for_star
            // 
            this.btn01_for_star.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn01_for_star.Location = new System.Drawing.Point(112, 116);
            this.btn01_for_star.Name = "btn01_for_star";
            this.btn01_for_star.Size = new System.Drawing.Size(148, 35);
            this.btn01_for_star.TabIndex = 1;
            this.btn01_for_star.Text = "依輸入印星號";
            this.btn01_for_star.UseVisualStyleBackColor = true;
            this.btn01_for_star.Click += new System.EventHandler(this.btn02_print_star_Click);
            // 
            // btn00_clear_up
            // 
            this.btn00_clear_up.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn00_clear_up.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn00_clear_up.Location = new System.Drawing.Point(722, 23);
            this.btn00_clear_up.Name = "btn00_clear_up";
            this.btn00_clear_up.Size = new System.Drawing.Size(96, 35);
            this.btn00_clear_up.TabIndex = 1;
            this.btn00_clear_up.Text = "清空";
            this.btn00_clear_up.UseVisualStyleBackColor = false;
            this.btn00_clear_up.Click += new System.EventHandler(this.btn00_clear_up_Click);
            // 
            // txtBox01_Input
            // 
            this.txtBox01_Input.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox01_Input.Location = new System.Drawing.Point(160, 30);
            this.txtBox01_Input.Name = "txtBox01_Input";
            this.txtBox01_Input.Size = new System.Drawing.Size(145, 34);
            this.txtBox01_Input.TabIndex = 3;
            this.txtBox01_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Input
            // 
            this.label_Input.AutoSize = true;
            this.label_Input.BackColor = System.Drawing.SystemColors.Control;
            this.label_Input.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Input.Location = new System.Drawing.Point(32, 33);
            this.label_Input.Name = "label_Input";
            this.label_Input.Size = new System.Drawing.Size(122, 25);
            this.label_Input.TabIndex = 2;
            this.label_Input.Text = "請輸入數值 :";
            // 
            // btn00_add
            // 
            this.btn00_add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn00_add.Location = new System.Drawing.Point(332, 11);
            this.btn00_add.Name = "btn00_add";
            this.btn00_add.Size = new System.Drawing.Size(66, 34);
            this.btn00_add.TabIndex = 1;
            this.btn00_add.Text = "+1";
            this.btn00_add.UseVisualStyleBackColor = true;
            this.btn00_add.Click += new System.EventHandler(this.btn00_add_Click);
            // 
            // btn00_minus
            // 
            this.btn00_minus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn00_minus.Location = new System.Drawing.Point(332, 51);
            this.btn00_minus.Name = "btn00_minus";
            this.btn00_minus.Size = new System.Drawing.Size(66, 34);
            this.btn00_minus.TabIndex = 1;
            this.btn00_minus.Text = "-1";
            this.btn00_minus.UseVisualStyleBackColor = true;
            this.btn00_minus.Click += new System.EventHandler(this.btn00_minus_Click);
            // 
            // label_for_border
            // 
            this.label_for_border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_for_border.Location = new System.Drawing.Point(33, 106);
            this.label_for_border.Name = "label_for_border";
            this.label_for_border.Size = new System.Drawing.Size(240, 95);
            this.label_for_border.TabIndex = 4;
            // 
            // label_for_top
            // 
            this.label_for_top.AutoSize = true;
            this.label_for_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_for_top.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_for_top.Location = new System.Drawing.Point(50, 140);
            this.label_for_top.Name = "label_for_top";
            this.label_for_top.Size = new System.Drawing.Size(38, 24);
            this.label_for_top.TabIndex = 5;
            this.label_for_top.Text = "For";
            this.label_for_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_while_border
            // 
            this.label_while_border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_while_border.Location = new System.Drawing.Point(297, 106);
            this.label_while_border.Name = "label_while_border";
            this.label_while_border.Size = new System.Drawing.Size(255, 95);
            this.label_while_border.TabIndex = 4;
            // 
            // btn04_while_table
            // 
            this.btn04_while_table.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn04_while_table.Location = new System.Drawing.Point(390, 157);
            this.btn04_while_table.Name = "btn04_while_table";
            this.btn04_while_table.Size = new System.Drawing.Size(148, 35);
            this.btn04_while_table.TabIndex = 1;
            this.btn04_while_table.Text = "九九乘法表";
            this.btn04_while_table.UseVisualStyleBackColor = true;
            // 
            // btn03_while_number
            // 
            this.btn03_while_number.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn03_while_number.Location = new System.Drawing.Point(390, 116);
            this.btn03_while_number.Name = "btn03_while_number";
            this.btn03_while_number.Size = new System.Drawing.Size(148, 35);
            this.btn03_while_number.TabIndex = 1;
            this.btn03_while_number.Text = "依輸入印星號";
            this.btn03_while_number.UseVisualStyleBackColor = true;
            this.btn03_while_number.Click += new System.EventHandler(this.btn03_while_number_Click);
            // 
            // label_while_top
            // 
            this.label_while_top.AutoSize = true;
            this.label_while_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_while_top.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_while_top.Location = new System.Drawing.Point(318, 140);
            this.label_while_top.Name = "label_while_top";
            this.label_while_top.Size = new System.Drawing.Size(57, 24);
            this.label_while_top.TabIndex = 5;
            this.label_while_top.Text = "While";
            this.label_while_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_do_border
            // 
            this.label_do_border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_do_border.Location = new System.Drawing.Point(578, 106);
            this.label_do_border.Name = "label_do_border";
            this.label_do_border.Size = new System.Drawing.Size(240, 95);
            this.label_do_border.TabIndex = 4;
            // 
            // btn06_do_table
            // 
            this.btn06_do_table.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn06_do_table.Location = new System.Drawing.Point(657, 157);
            this.btn06_do_table.Name = "btn06_do_table";
            this.btn06_do_table.Size = new System.Drawing.Size(148, 35);
            this.btn06_do_table.TabIndex = 1;
            this.btn06_do_table.Text = "九九乘法表";
            this.btn06_do_table.UseVisualStyleBackColor = true;
            // 
            // btn05_do_star
            // 
            this.btn05_do_star.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn05_do_star.Location = new System.Drawing.Point(657, 116);
            this.btn05_do_star.Name = "btn05_do_star";
            this.btn05_do_star.Size = new System.Drawing.Size(148, 35);
            this.btn05_do_star.TabIndex = 1;
            this.btn05_do_star.Text = "依輸入印星號";
            this.btn05_do_star.UseVisualStyleBackColor = true;
            // 
            // label_do_top
            // 
            this.label_do_top.AutoSize = true;
            this.label_do_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_do_top.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_do_top.Location = new System.Drawing.Point(598, 140);
            this.label_do_top.Name = "label_do_top";
            this.label_do_top.Size = new System.Drawing.Size(36, 24);
            this.label_do_top.TabIndex = 5;
            this.label_do_top.Text = "Do";
            this.label_do_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm06_LoopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 538);
            this.Controls.Add(this.label_while_top);
            this.Controls.Add(this.label_do_top);
            this.Controls.Add(this.label_for_top);
            this.Controls.Add(this.txtBox01_Input);
            this.Controls.Add(this.label_Input);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.btn00_minus);
            this.Controls.Add(this.btn00_add);
            this.Controls.Add(this.btn03_while_number);
            this.Controls.Add(this.btn05_do_star);
            this.Controls.Add(this.btn01_for_star);
            this.Controls.Add(this.btn00_clear_up);
            this.Controls.Add(this.btn04_while_table);
            this.Controls.Add(this.btn06_do_table);
            this.Controls.Add(this.btn02_for_table);
            this.Controls.Add(this.label_Border_Result);
            this.Controls.Add(this.label_do_border);
            this.Controls.Add(this.label_while_border);
            this.Controls.Add(this.label_for_border);
            this.Name = "Frm06_LoopForm";
            this.ShowIcon = false;
            this.Text = "迴圈練習";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Border_Result;
        private System.Windows.Forms.Button btn02_for_table;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Button btn01_for_star;
        private System.Windows.Forms.Button btn00_clear_up;
        private System.Windows.Forms.TextBox txtBox01_Input;
        private System.Windows.Forms.Label label_Input;
        private System.Windows.Forms.Button btn00_add;
        private System.Windows.Forms.Button btn00_minus;
        private System.Windows.Forms.Label label_for_border;
        private System.Windows.Forms.Label label_for_top;
        private System.Windows.Forms.Label label_while_border;
        private System.Windows.Forms.Button btn04_while_table;
        private System.Windows.Forms.Button btn03_while_number;
        private System.Windows.Forms.Label label_while_top;
        private System.Windows.Forms.Label label_do_border;
        private System.Windows.Forms.Button btn06_do_table;
        private System.Windows.Forms.Button btn05_do_star;
        private System.Windows.Forms.Label label_do_top;
    }
}