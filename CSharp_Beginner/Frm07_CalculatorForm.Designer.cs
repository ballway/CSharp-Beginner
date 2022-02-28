
namespace CSharp_Beginner
{
    partial class Frm07_CalculatorForm
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
            this.label_Result = new System.Windows.Forms.Label();
            this.label_previous_record = new System.Windows.Forms.Label();
            this.btn_function_remainder = new System.Windows.Forms.Button();
            this.btn_clearup = new System.Windows.Forms.Button();
            this.btn_function_divide = new System.Windows.Forms.Button();
            this.btn_function_multiply = new System.Windows.Forms.Button();
            this.btn_num_9 = new System.Windows.Forms.Button();
            this.btn_num_8 = new System.Windows.Forms.Button();
            this.btn_num_7 = new System.Windows.Forms.Button();
            this.btn_num_6 = new System.Windows.Forms.Button();
            this.btn_num_5 = new System.Windows.Forms.Button();
            this.btn_num_4 = new System.Windows.Forms.Button();
            this.btn_function_substract = new System.Windows.Forms.Button();
            this.btn_num_3 = new System.Windows.Forms.Button();
            this.btn_num_2 = new System.Windows.Forms.Button();
            this.btn_num_1 = new System.Windows.Forms.Button();
            this.btn_function_plus = new System.Windows.Forms.Button();
            this.btn_num_0 = new System.Windows.Forms.Button();
            this.btn_function_equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Result
            // 
            this.label_Result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Result.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Result.Location = new System.Drawing.Point(29, 75);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(354, 76);
            this.label_Result.TabIndex = 0;
            this.label_Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_previous_record
            // 
            this.label_previous_record.BackColor = System.Drawing.SystemColors.Control;
            this.label_previous_record.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_previous_record.Location = new System.Drawing.Point(37, 18);
            this.label_previous_record.Name = "label_previous_record";
            this.label_previous_record.Size = new System.Drawing.Size(354, 44);
            this.label_previous_record.TabIndex = 0;
            this.label_previous_record.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_function_remainder
            // 
            this.btn_function_remainder.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_function_remainder.Location = new System.Drawing.Point(30, 170);
            this.btn_function_remainder.Name = "btn_function_remainder";
            this.btn_function_remainder.Size = new System.Drawing.Size(77, 72);
            this.btn_function_remainder.TabIndex = 1;
            this.btn_function_remainder.Text = "%";
            this.btn_function_remainder.UseVisualStyleBackColor = true;
            this.btn_function_remainder.Click += new System.EventHandler(this.btn_function_remainder_Click);
            // 
            // btn_clearup
            // 
            this.btn_clearup.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clearup.Location = new System.Drawing.Point(214, 170);
            this.btn_clearup.Name = "btn_clearup";
            this.btn_clearup.Size = new System.Drawing.Size(77, 72);
            this.btn_clearup.TabIndex = 1;
            this.btn_clearup.Text = "C";
            this.btn_clearup.UseVisualStyleBackColor = true;
            this.btn_clearup.Click += new System.EventHandler(this.btn_clearup_Click);
            // 
            // btn_function_divide
            // 
            this.btn_function_divide.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_function_divide.Location = new System.Drawing.Point(306, 170);
            this.btn_function_divide.Name = "btn_function_divide";
            this.btn_function_divide.Size = new System.Drawing.Size(77, 72);
            this.btn_function_divide.TabIndex = 1;
            this.btn_function_divide.Text = "÷";
            this.btn_function_divide.UseVisualStyleBackColor = true;
            this.btn_function_divide.Click += new System.EventHandler(this.btn_function_divide_Click);
            // 
            // btn_function_multiply
            // 
            this.btn_function_multiply.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_function_multiply.Location = new System.Drawing.Point(306, 257);
            this.btn_function_multiply.Name = "btn_function_multiply";
            this.btn_function_multiply.Size = new System.Drawing.Size(77, 72);
            this.btn_function_multiply.TabIndex = 1;
            this.btn_function_multiply.Text = "x";
            this.btn_function_multiply.UseVisualStyleBackColor = true;
            this.btn_function_multiply.Click += new System.EventHandler(this.btn_function_multiply_Click);
            // 
            // btn_num_9
            // 
            this.btn_num_9.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num_9.Location = new System.Drawing.Point(214, 257);
            this.btn_num_9.Name = "btn_num_9";
            this.btn_num_9.Size = new System.Drawing.Size(77, 72);
            this.btn_num_9.TabIndex = 1;
            this.btn_num_9.Text = "9";
            this.btn_num_9.UseVisualStyleBackColor = true;
            this.btn_num_9.Click += new System.EventHandler(this.btn_num_9_Click);
            // 
            // btn_num_8
            // 
            this.btn_num_8.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num_8.Location = new System.Drawing.Point(122, 257);
            this.btn_num_8.Name = "btn_num_8";
            this.btn_num_8.Size = new System.Drawing.Size(77, 72);
            this.btn_num_8.TabIndex = 1;
            this.btn_num_8.Text = "8";
            this.btn_num_8.UseVisualStyleBackColor = true;
            this.btn_num_8.Click += new System.EventHandler(this.btn_num_8_Click);
            // 
            // btn_num_7
            // 
            this.btn_num_7.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num_7.Location = new System.Drawing.Point(30, 257);
            this.btn_num_7.Name = "btn_num_7";
            this.btn_num_7.Size = new System.Drawing.Size(77, 72);
            this.btn_num_7.TabIndex = 1;
            this.btn_num_7.Text = "7";
            this.btn_num_7.UseVisualStyleBackColor = true;
            this.btn_num_7.Click += new System.EventHandler(this.btn_num_7_Click);
            // 
            // btn_num_6
            // 
            this.btn_num_6.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num_6.Location = new System.Drawing.Point(214, 344);
            this.btn_num_6.Name = "btn_num_6";
            this.btn_num_6.Size = new System.Drawing.Size(77, 72);
            this.btn_num_6.TabIndex = 1;
            this.btn_num_6.Text = "6";
            this.btn_num_6.UseVisualStyleBackColor = true;
            this.btn_num_6.Click += new System.EventHandler(this.btn_num_6_Click);
            // 
            // btn_num_5
            // 
            this.btn_num_5.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num_5.Location = new System.Drawing.Point(122, 344);
            this.btn_num_5.Name = "btn_num_5";
            this.btn_num_5.Size = new System.Drawing.Size(77, 72);
            this.btn_num_5.TabIndex = 1;
            this.btn_num_5.Text = "5";
            this.btn_num_5.UseVisualStyleBackColor = true;
            this.btn_num_5.Click += new System.EventHandler(this.btn_num_5_Click);
            // 
            // btn_num_4
            // 
            this.btn_num_4.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num_4.Location = new System.Drawing.Point(30, 344);
            this.btn_num_4.Name = "btn_num_4";
            this.btn_num_4.Size = new System.Drawing.Size(77, 72);
            this.btn_num_4.TabIndex = 1;
            this.btn_num_4.Text = "4";
            this.btn_num_4.UseVisualStyleBackColor = true;
            this.btn_num_4.Click += new System.EventHandler(this.btn_num_4_Click);
            // 
            // btn_function_substract
            // 
            this.btn_function_substract.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_function_substract.Location = new System.Drawing.Point(306, 344);
            this.btn_function_substract.Name = "btn_function_substract";
            this.btn_function_substract.Size = new System.Drawing.Size(77, 72);
            this.btn_function_substract.TabIndex = 1;
            this.btn_function_substract.Text = "-";
            this.btn_function_substract.UseVisualStyleBackColor = true;
            this.btn_function_substract.Click += new System.EventHandler(this.btn_function_substract_Click);
            // 
            // btn_num_3
            // 
            this.btn_num_3.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num_3.Location = new System.Drawing.Point(214, 432);
            this.btn_num_3.Name = "btn_num_3";
            this.btn_num_3.Size = new System.Drawing.Size(77, 72);
            this.btn_num_3.TabIndex = 1;
            this.btn_num_3.Text = "3";
            this.btn_num_3.UseVisualStyleBackColor = true;
            this.btn_num_3.Click += new System.EventHandler(this.btn_num_3_Click);
            // 
            // btn_num_2
            // 
            this.btn_num_2.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num_2.Location = new System.Drawing.Point(122, 432);
            this.btn_num_2.Name = "btn_num_2";
            this.btn_num_2.Size = new System.Drawing.Size(77, 72);
            this.btn_num_2.TabIndex = 1;
            this.btn_num_2.Text = "2";
            this.btn_num_2.UseVisualStyleBackColor = true;
            this.btn_num_2.Click += new System.EventHandler(this.btn_num_2_Click);
            // 
            // btn_num_1
            // 
            this.btn_num_1.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num_1.Location = new System.Drawing.Point(30, 432);
            this.btn_num_1.Name = "btn_num_1";
            this.btn_num_1.Size = new System.Drawing.Size(77, 72);
            this.btn_num_1.TabIndex = 1;
            this.btn_num_1.Text = "1";
            this.btn_num_1.UseVisualStyleBackColor = true;
            this.btn_num_1.Click += new System.EventHandler(this.btn_num_1_Click);
            // 
            // btn_function_plus
            // 
            this.btn_function_plus.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_function_plus.Location = new System.Drawing.Point(306, 432);
            this.btn_function_plus.Name = "btn_function_plus";
            this.btn_function_plus.Size = new System.Drawing.Size(77, 72);
            this.btn_function_plus.TabIndex = 1;
            this.btn_function_plus.Text = "+";
            this.btn_function_plus.UseVisualStyleBackColor = true;
            this.btn_function_plus.Click += new System.EventHandler(this.btn_function_plus_Click);
            // 
            // btn_num_0
            // 
            this.btn_num_0.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num_0.Location = new System.Drawing.Point(122, 519);
            this.btn_num_0.Name = "btn_num_0";
            this.btn_num_0.Size = new System.Drawing.Size(77, 72);
            this.btn_num_0.TabIndex = 1;
            this.btn_num_0.Text = "0";
            this.btn_num_0.UseVisualStyleBackColor = true;
            this.btn_num_0.Click += new System.EventHandler(this.btn_num_0_Click);
            // 
            // btn_function_equal
            // 
            this.btn_function_equal.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_function_equal.Location = new System.Drawing.Point(306, 519);
            this.btn_function_equal.Name = "btn_function_equal";
            this.btn_function_equal.Size = new System.Drawing.Size(77, 72);
            this.btn_function_equal.TabIndex = 1;
            this.btn_function_equal.Text = "=";
            this.btn_function_equal.UseVisualStyleBackColor = true;
            this.btn_function_equal.Click += new System.EventHandler(this.btn_function_equal_Click);
            // 
            // Frm07_CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 620);
            this.Controls.Add(this.btn_function_divide);
            this.Controls.Add(this.btn_function_equal);
            this.Controls.Add(this.btn_function_plus);
            this.Controls.Add(this.btn_function_substract);
            this.Controls.Add(this.btn_function_multiply);
            this.Controls.Add(this.btn_num_1);
            this.Controls.Add(this.btn_num_0);
            this.Controls.Add(this.btn_num_2);
            this.Controls.Add(this.btn_num_4);
            this.Controls.Add(this.btn_num_5);
            this.Controls.Add(this.btn_num_3);
            this.Controls.Add(this.btn_num_7);
            this.Controls.Add(this.btn_num_6);
            this.Controls.Add(this.btn_num_8);
            this.Controls.Add(this.btn_num_9);
            this.Controls.Add(this.btn_clearup);
            this.Controls.Add(this.btn_function_remainder);
            this.Controls.Add(this.label_previous_record);
            this.Controls.Add(this.label_Result);
            this.Name = "Frm07_CalculatorForm";
            this.ShowIcon = false;
            this.Text = "Simple 計算器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Label label_previous_record;
        private System.Windows.Forms.Button btn_function_remainder;
        private System.Windows.Forms.Button btn_clearup;
        private System.Windows.Forms.Button btn_function_divide;
        private System.Windows.Forms.Button btn_function_multiply;
        private System.Windows.Forms.Button btn_num_9;
        private System.Windows.Forms.Button btn_num_8;
        private System.Windows.Forms.Button btn_num_7;
        private System.Windows.Forms.Button btn_num_6;
        private System.Windows.Forms.Button btn_num_5;
        private System.Windows.Forms.Button btn_num_4;
        private System.Windows.Forms.Button btn_function_substract;
        private System.Windows.Forms.Button btn_num_3;
        private System.Windows.Forms.Button btn_num_2;
        private System.Windows.Forms.Button btn_num_1;
        private System.Windows.Forms.Button btn_function_plus;
        private System.Windows.Forms.Button btn_num_0;
        private System.Windows.Forms.Button btn_function_equal;
    }
}