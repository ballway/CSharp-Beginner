
namespace CSharp_Beginner
{
    partial class Frm09_ArrayList_Form
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
            this.txtBox02_age = new System.Windows.Forms.TextBox();
            this.label_age = new System.Windows.Forms.Label();
            this.txtBox01_zh_Name = new System.Windows.Forms.TextBox();
            this.btn02_ClearUp = new System.Windows.Forms.Button();
            this.btn01_Input = new System.Windows.Forms.Button();
            this.label_zh_Name = new System.Windows.Forms.Label();
            this.label_Intro = new System.Windows.Forms.Label();
            this.label_result_data = new System.Windows.Forms.Label();
            this.label_border_data = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox02_age
            // 
            this.txtBox02_age.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox02_age.Location = new System.Drawing.Point(104, 165);
            this.txtBox02_age.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBox02_age.Name = "txtBox02_age";
            this.txtBox02_age.Size = new System.Drawing.Size(106, 32);
            this.txtBox02_age.TabIndex = 14;
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_age.Location = new System.Drawing.Point(49, 167);
            this.label_age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(52, 24);
            this.label_age.TabIndex = 7;
            this.label_age.Text = "年齡:";
            // 
            // txtBox01_zh_Name
            // 
            this.txtBox01_zh_Name.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox01_zh_Name.Location = new System.Drawing.Point(104, 114);
            this.txtBox01_zh_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBox01_zh_Name.Name = "txtBox01_zh_Name";
            this.txtBox01_zh_Name.Size = new System.Drawing.Size(106, 32);
            this.txtBox01_zh_Name.TabIndex = 11;
            // 
            // btn02_ClearUp
            // 
            this.btn02_ClearUp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn02_ClearUp.Location = new System.Drawing.Point(494, 287);
            this.btn02_ClearUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn02_ClearUp.Name = "btn02_ClearUp";
            this.btn02_ClearUp.Size = new System.Drawing.Size(98, 34);
            this.btn02_ClearUp.TabIndex = 16;
            this.btn02_ClearUp.Text = "清空資料";
            this.btn02_ClearUp.UseVisualStyleBackColor = true;
            // 
            // btn01_Input
            // 
            this.btn01_Input.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn01_Input.Location = new System.Drawing.Point(76, 238);
            this.btn01_Input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn01_Input.Name = "btn01_Input";
            this.btn01_Input.Size = new System.Drawing.Size(98, 34);
            this.btn01_Input.TabIndex = 15;
            this.btn01_Input.Text = "確認輸入";
            this.btn01_Input.UseVisualStyleBackColor = true;
            this.btn01_Input.Click += new System.EventHandler(this.btn01_Input_Click);
            // 
            // label_zh_Name
            // 
            this.label_zh_Name.AutoSize = true;
            this.label_zh_Name.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_zh_Name.Location = new System.Drawing.Point(49, 117);
            this.label_zh_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_zh_Name.Name = "label_zh_Name";
            this.label_zh_Name.Size = new System.Drawing.Size(52, 24);
            this.label_zh_Name.TabIndex = 10;
            this.label_zh_Name.Text = "姓名:";
            // 
            // label_Intro
            // 
            this.label_Intro.AutoSize = true;
            this.label_Intro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Intro.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Intro.Location = new System.Drawing.Point(35, 34);
            this.label_Intro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Intro.Name = "label_Intro";
            this.label_Intro.Size = new System.Drawing.Size(190, 30);
            this.label_Intro.TabIndex = 17;
            this.label_Intro.Text = "員工資料紀錄工具";
            // 
            // label_result_data
            // 
            this.label_result_data.AutoSize = true;
            this.label_result_data.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_result_data.Location = new System.Drawing.Point(274, 44);
            this.label_result_data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_result_data.Name = "label_result_data";
            this.label_result_data.Size = new System.Drawing.Size(84, 19);
            this.label_result_data.TabIndex = 21;
            this.label_result_data.Text = "請輸入資料";
            // 
            // label_border_data
            // 
            this.label_border_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_border_data.Location = new System.Drawing.Point(257, 34);
            this.label_border_data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_border_data.Name = "label_border_data";
            this.label_border_data.Size = new System.Drawing.Size(334, 240);
            this.label_border_data.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(9, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "*以傳統集合實作*";
            // 
            // Frm09_ArrayList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_result_data);
            this.Controls.Add(this.label_border_data);
            this.Controls.Add(this.label_Intro);
            this.Controls.Add(this.txtBox02_age);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.txtBox01_zh_Name);
            this.Controls.Add(this.btn02_ClearUp);
            this.Controls.Add(this.btn01_Input);
            this.Controls.Add(this.label_zh_Name);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm09_ArrayList_Form";
            this.ShowIcon = false;
            this.Text = "ArrayList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox02_age;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.TextBox txtBox01_zh_Name;
        private System.Windows.Forms.Button btn02_ClearUp;
        private System.Windows.Forms.Button btn01_Input;
        private System.Windows.Forms.Label label_zh_Name;
        private System.Windows.Forms.Label label_Intro;
        private System.Windows.Forms.Label label_result_data;
        private System.Windows.Forms.Label label_border_data;
        private System.Windows.Forms.Label label1;
    }
}