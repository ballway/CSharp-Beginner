
namespace CSharp_Beginner
{
    partial class Frm13_1_GuessForm
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
            this.label_result_show = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.label_game_top = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_result_show
            // 
            this.label_result_show.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_result_show.AutoSize = true;
            this.label_result_show.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_result_show.Location = new System.Drawing.Point(190, 159);
            this.label_result_show.Name = "label_result_show";
            this.label_result_show.Size = new System.Drawing.Size(246, 42);
            this.label_result_show.TabIndex = 4;
            this.label_result_show.Text = "*結果顯示在這*";
            this.label_result_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(115, 251);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(153, 48);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "GUESS";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label_game_top
            // 
            this.label_game_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_game_top.AutoSize = true;
            this.label_game_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_game_top.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_game_top.Location = new System.Drawing.Point(183, 44);
            this.label_game_top.Name = "label_game_top";
            this.label_game_top.Size = new System.Drawing.Size(269, 63);
            this.label_game_top.TabIndex = 5;
            this.label_game_top.Text = "猜數字遊戲";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(367, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "SHOW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm13_GuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 352);
            this.Controls.Add(this.label_result_show);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label_game_top);
            this.Name = "Frm13_GuessForm";
            this.ShowIcon = false;
            this.Text = "猜數字遊戲";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label_game_top;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label label_result_show;
    }
}