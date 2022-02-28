
namespace CSharp_Beginner
{
    partial class Frm13_2_InputForm
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
            this.txtBox01_Input = new System.Windows.Forms.TextBox();
            this.label_Input = new System.Windows.Forms.Label();
            this.button_enter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox01_Input
            // 
            this.txtBox01_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox01_Input.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox01_Input.Location = new System.Drawing.Point(12, 110);
            this.txtBox01_Input.Name = "txtBox01_Input";
            this.txtBox01_Input.Size = new System.Drawing.Size(421, 34);
            this.txtBox01_Input.TabIndex = 5;
            this.txtBox01_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Input
            // 
            this.label_Input.AutoSize = true;
            this.label_Input.BackColor = System.Drawing.SystemColors.Control;
            this.label_Input.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Input.Location = new System.Drawing.Point(12, 39);
            this.label_Input.Name = "label_Input";
            this.label_Input.Size = new System.Drawing.Size(285, 31);
            this.label_Input.TabIndex = 4;
            this.label_Input.Text = "Please input a number :";
            // 
            // button_enter
            // 
            this.button_enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_enter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_enter.Location = new System.Drawing.Point(331, 12);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(102, 32);
            this.button_enter.TabIndex = 6;
            this.button_enter.Text = "Enter";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(331, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Frm13_1_InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 156);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.txtBox01_Input);
            this.Controls.Add(this.label_Input);
            this.MaximizeBox = false;
            this.Name = "Frm13_1_InputForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox01_Input;
        private System.Windows.Forms.Label label_Input;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Button button2;
    }
}