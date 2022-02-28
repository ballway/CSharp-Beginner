
namespace CSharp_Beginner
{
    partial class Frm11_PathForm
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
            this.label_result = new System.Windows.Forms.Label();
            this.label_border = new System.Windows.Forms.Label();
            this.btn01_show_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_result.Location = new System.Drawing.Point(32, 34);
            this.label_result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(76, 18);
            this.label_result.TabIndex = 21;
            this.label_result.Text = "*結果顯示*";
            // 
            // label_border
            // 
            this.label_border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_border.Location = new System.Drawing.Point(20, 22);
            this.label_border.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_border.Name = "label_border";
            this.label_border.Size = new System.Drawing.Size(600, 122);
            this.label_border.TabIndex = 20;
            // 
            // btn01_show_result
            // 
            this.btn01_show_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn01_show_result.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn01_show_result.Location = new System.Drawing.Point(266, 197);
            this.btn01_show_result.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn01_show_result.Name = "btn01_show_result";
            this.btn01_show_result.Size = new System.Drawing.Size(109, 32);
            this.btn01_show_result.TabIndex = 22;
            this.btn01_show_result.Text = "輸出";
            this.btn01_show_result.UseVisualStyleBackColor = true;
            this.btn01_show_result.Click += new System.EventHandler(this.btn01_show_result_Click);
            // 
            // Frm11_PathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 260);
            this.Controls.Add(this.btn01_show_result);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_border);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm11_PathForm";
            this.ShowIcon = false;
            this.Text = "PathForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_border;
        private System.Windows.Forms.Button btn01_show_result;
    }
}