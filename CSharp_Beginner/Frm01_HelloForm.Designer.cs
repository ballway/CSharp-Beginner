
namespace CSharp_Beginner
{
    partial class Frm01_HelloForm
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
            this.label00_Intro = new System.Windows.Forms.Label();
            this.btn01_Input = new System.Windows.Forms.Button();
            this.label01_zh_Name = new System.Windows.Forms.Label();
            this.txtBox01_zh_Name = new System.Windows.Forms.TextBox();
            this.label02_en_Name = new System.Windows.Forms.Label();
            this.txtBox02_en_Name = new System.Windows.Forms.TextBox();
            this.label03_sex = new System.Windows.Forms.Label();
            this.txtBox03_sex = new System.Windows.Forms.TextBox();
            this.label04_age = new System.Windows.Forms.Label();
            this.txtBox04_age = new System.Windows.Forms.TextBox();
            this.btn02_ClearUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label00_Intro
            // 
            this.label00_Intro.AutoSize = true;
            this.label00_Intro.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label00_Intro.Location = new System.Drawing.Point(62, 24);
            this.label00_Intro.Name = "label00_Intro";
            this.label00_Intro.Size = new System.Drawing.Size(323, 35);
            this.label00_Intro.TabIndex = 0;
            this.label00_Intro.Text = "這是會跟你打招呼的視窗";
            // 
            // btn01_Input
            // 
            this.btn01_Input.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn01_Input.Location = new System.Drawing.Point(49, 341);
            this.btn01_Input.Name = "btn01_Input";
            this.btn01_Input.Size = new System.Drawing.Size(142, 53);
            this.btn01_Input.TabIndex = 5;
            this.btn01_Input.Text = "確認輸入";
            this.btn01_Input.UseVisualStyleBackColor = true;
            this.btn01_Input.Click += new System.EventHandler(this.btn01_Input_Click);
            // 
            // label01_zh_Name
            // 
            this.label01_zh_Name.AutoSize = true;
            this.label01_zh_Name.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label01_zh_Name.Location = new System.Drawing.Point(105, 98);
            this.label01_zh_Name.Name = "label01_zh_Name";
            this.label01_zh_Name.Size = new System.Drawing.Size(61, 30);
            this.label01_zh_Name.TabIndex = 0;
            this.label01_zh_Name.Text = "姓名";
            // 
            // txtBox01_zh_Name
            // 
            this.txtBox01_zh_Name.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox01_zh_Name.Location = new System.Drawing.Point(183, 95);
            this.txtBox01_zh_Name.Name = "txtBox01_zh_Name";
            this.txtBox01_zh_Name.Size = new System.Drawing.Size(140, 38);
            this.txtBox01_zh_Name.TabIndex = 1;
            // 
            // label02_en_Name
            // 
            this.label02_en_Name.AutoSize = true;
            this.label02_en_Name.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label02_en_Name.Location = new System.Drawing.Point(92, 151);
            this.label02_en_Name.Name = "label02_en_Name";
            this.label02_en_Name.Size = new System.Drawing.Size(85, 30);
            this.label02_en_Name.TabIndex = 0;
            this.label02_en_Name.Text = "英文名";
            this.label02_en_Name.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtBox02_en_Name
            // 
            this.txtBox02_en_Name.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox02_en_Name.Location = new System.Drawing.Point(183, 149);
            this.txtBox02_en_Name.Name = "txtBox02_en_Name";
            this.txtBox02_en_Name.Size = new System.Drawing.Size(140, 38);
            this.txtBox02_en_Name.TabIndex = 2;
            // 
            // label03_sex
            // 
            this.label03_sex.AutoSize = true;
            this.label03_sex.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label03_sex.Location = new System.Drawing.Point(105, 206);
            this.label03_sex.Name = "label03_sex";
            this.label03_sex.Size = new System.Drawing.Size(61, 30);
            this.label03_sex.TabIndex = 0;
            this.label03_sex.Text = "性別";
            // 
            // txtBox03_sex
            // 
            this.txtBox03_sex.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox03_sex.Location = new System.Drawing.Point(183, 203);
            this.txtBox03_sex.Name = "txtBox03_sex";
            this.txtBox03_sex.Size = new System.Drawing.Size(140, 38);
            this.txtBox03_sex.TabIndex = 3;
            // 
            // label04_age
            // 
            this.label04_age.AutoSize = true;
            this.label04_age.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label04_age.Location = new System.Drawing.Point(105, 260);
            this.label04_age.Name = "label04_age";
            this.label04_age.Size = new System.Drawing.Size(61, 30);
            this.label04_age.TabIndex = 0;
            this.label04_age.Text = "年齡";
            // 
            // txtBox04_age
            // 
            this.txtBox04_age.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox04_age.Location = new System.Drawing.Point(183, 257);
            this.txtBox04_age.Name = "txtBox04_age";
            this.txtBox04_age.Size = new System.Drawing.Size(140, 38);
            this.txtBox04_age.TabIndex = 4;
            // 
            // btn02_ClearUp
            // 
            this.btn02_ClearUp.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn02_ClearUp.Location = new System.Drawing.Point(243, 341);
            this.btn02_ClearUp.Name = "btn02_ClearUp";
            this.btn02_ClearUp.Size = new System.Drawing.Size(142, 53);
            this.btn02_ClearUp.TabIndex = 6;
            this.btn02_ClearUp.Text = "清空資料";
            this.btn02_ClearUp.UseVisualStyleBackColor = true;
            this.btn02_ClearUp.Click += new System.EventHandler(this.btn02_ClearUp_Click);
            // 
            // Frm01_HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 431);
            this.Controls.Add(this.txtBox04_age);
            this.Controls.Add(this.txtBox03_sex);
            this.Controls.Add(this.label04_age);
            this.Controls.Add(this.txtBox02_en_Name);
            this.Controls.Add(this.label03_sex);
            this.Controls.Add(this.txtBox01_zh_Name);
            this.Controls.Add(this.label02_en_Name);
            this.Controls.Add(this.btn02_ClearUp);
            this.Controls.Add(this.btn01_Input);
            this.Controls.Add(this.label01_zh_Name);
            this.Controls.Add(this.label00_Intro);
            this.MaximizeBox = false;
            this.Name = "Frm01_HelloForm";
            this.ShowIcon = false;
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label00_Intro;
        private System.Windows.Forms.Button btn01_Input;
        private System.Windows.Forms.Label label01_zh_Name;
        private System.Windows.Forms.TextBox txtBox01_zh_Name;
        private System.Windows.Forms.Label label02_en_Name;
        private System.Windows.Forms.TextBox txtBox02_en_Name;
        private System.Windows.Forms.Label label03_sex;
        private System.Windows.Forms.TextBox txtBox03_sex;
        private System.Windows.Forms.Label label04_age;
        private System.Windows.Forms.TextBox txtBox04_age;
        private System.Windows.Forms.Button btn02_ClearUp;
    }
}