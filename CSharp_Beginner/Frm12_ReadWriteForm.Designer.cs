
namespace CSharp_Beginner
{
    partial class Frm12_ReadWriteForm
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
            this.txtbox_ReadWrite = new System.Windows.Forms.TextBox();
            this.btn01_Read = new System.Windows.Forms.Button();
            this.btn02_Write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_ReadWrite
            // 
            this.txtbox_ReadWrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_ReadWrite.Location = new System.Drawing.Point(167, 10);
            this.txtbox_ReadWrite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_ReadWrite.Multiline = true;
            this.txtbox_ReadWrite.Name = "txtbox_ReadWrite";
            this.txtbox_ReadWrite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_ReadWrite.Size = new System.Drawing.Size(298, 324);
            this.txtbox_ReadWrite.TabIndex = 0;
            // 
            // btn01_Read
            // 
            this.btn01_Read.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn01_Read.Location = new System.Drawing.Point(39, 43);
            this.btn01_Read.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn01_Read.Name = "btn01_Read";
            this.btn01_Read.Size = new System.Drawing.Size(87, 34);
            this.btn01_Read.TabIndex = 1;
            this.btn01_Read.Text = "讀取";
            this.btn01_Read.UseVisualStyleBackColor = true;
            this.btn01_Read.Click += new System.EventHandler(this.btn01_Read_Click);
            // 
            // btn02_Write
            // 
            this.btn02_Write.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn02_Write.Location = new System.Drawing.Point(39, 98);
            this.btn02_Write.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn02_Write.Name = "btn02_Write";
            this.btn02_Write.Size = new System.Drawing.Size(87, 34);
            this.btn02_Write.TabIndex = 1;
            this.btn02_Write.Text = "寫入";
            this.btn02_Write.UseVisualStyleBackColor = true;
            this.btn02_Write.Click += new System.EventHandler(this.btn02_Write_Click);
            // 
            // Frm12_ReadWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 351);
            this.Controls.Add(this.btn02_Write);
            this.Controls.Add(this.btn01_Read);
            this.Controls.Add(this.txtbox_ReadWrite);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm12_ReadWriteForm";
            this.ShowIcon = false;
            this.Text = "Frm12_ReadWriteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_ReadWrite;
        private System.Windows.Forms.Button btn01_Read;
        private System.Windows.Forms.Button btn02_Write;
    }
}