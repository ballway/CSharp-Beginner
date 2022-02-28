
namespace CSharp_Beginner
{
    partial class HomePage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn00_Change_Color = new System.Windows.Forms.Button();
            this.label_Home_Intro = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn12_ReadWrite_Form = new System.Windows.Forms.Button();
            this.btn11_Path_Form = new System.Windows.Forms.Button();
            this.btn10_Generic_List_Form = new System.Windows.Forms.Button();
            this.btn09_ArrayList_Form = new System.Windows.Forms.Button();
            this.btn14_PictureForm = new System.Windows.Forms.Button();
            this.btn13_GuessForm = new System.Windows.Forms.Button();
            this.btn08_Student_GradeForm = new System.Windows.Forms.Button();
            this.btn07_CalculatorForm = new System.Windows.Forms.Button();
            this.btn06_ForLoopForm = new System.Windows.Forms.Button();
            this.btn05_ScreenSaver = new System.Windows.Forms.Button();
            this.btn04_MethodForm = new System.Windows.Forms.Button();
            this.btn03_POSForm = new System.Windows.Forms.Button();
            this.btn02_CompoundForm = new System.Windows.Forms.Button();
            this.btn01_HelloForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.btn00_Change_Color);
            this.splitContainer1.Panel1.Controls.Add(this.label_Home_Intro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1065, 606);
            this.splitContainer1.SplitterDistance = 74;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn00_Change_Color
            // 
            this.btn00_Change_Color.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn00_Change_Color.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn00_Change_Color.Location = new System.Drawing.Point(926, 14);
            this.btn00_Change_Color.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn00_Change_Color.Name = "btn00_Change_Color";
            this.btn00_Change_Color.Size = new System.Drawing.Size(127, 44);
            this.btn00_Change_Color.TabIndex = 3;
            this.btn00_Change_Color.Text = "按鈕換顏色";
            this.btn00_Change_Color.UseVisualStyleBackColor = true;
            this.btn00_Change_Color.Click += new System.EventHandler(this.btn00_Change_Color_Click);
            // 
            // label_Home_Intro
            // 
            this.label_Home_Intro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Home_Intro.AutoSize = true;
            this.label_Home_Intro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Home_Intro.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Home_Intro.Location = new System.Drawing.Point(31, 19);
            this.label_Home_Intro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Home_Intro.Name = "label_Home_Intro";
            this.label_Home_Intro.Size = new System.Drawing.Size(104, 35);
            this.label_Home_Intro.TabIndex = 0;
            this.label_Home_Intro.Text = "C#練習";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainer2.Panel1.Controls.Add(this.btn12_ReadWrite_Form);
            this.splitContainer2.Panel1.Controls.Add(this.btn11_Path_Form);
            this.splitContainer2.Panel1.Controls.Add(this.btn10_Generic_List_Form);
            this.splitContainer2.Panel1.Controls.Add(this.btn09_ArrayList_Form);
            this.splitContainer2.Panel1.Controls.Add(this.btn14_PictureForm);
            this.splitContainer2.Panel1.Controls.Add(this.btn13_GuessForm);
            this.splitContainer2.Panel1.Controls.Add(this.btn08_Student_GradeForm);
            this.splitContainer2.Panel1.Controls.Add(this.btn07_CalculatorForm);
            this.splitContainer2.Panel1.Controls.Add(this.btn06_ForLoopForm);
            this.splitContainer2.Panel1.Controls.Add(this.btn05_ScreenSaver);
            this.splitContainer2.Panel1.Controls.Add(this.btn04_MethodForm);
            this.splitContainer2.Panel1.Controls.Add(this.btn03_POSForm);
            this.splitContainer2.Panel1.Controls.Add(this.btn02_CompoundForm);
            this.splitContainer2.Panel1.Controls.Add(this.btn01_HelloForm);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Size = new System.Drawing.Size(1065, 529);
            this.splitContainer2.SplitterDistance = 220;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // btn12_ReadWrite_Form
            // 
            this.btn12_ReadWrite_Form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn12_ReadWrite_Form.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn12_ReadWrite_Form.Location = new System.Drawing.Point(35, 442);
            this.btn12_ReadWrite_Form.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn12_ReadWrite_Form.Name = "btn12_ReadWrite_Form";
            this.btn12_ReadWrite_Form.Size = new System.Drawing.Size(149, 24);
            this.btn12_ReadWrite_Form.TabIndex = 3;
            this.btn12_ReadWrite_Form.Text = "Read / Write";
            this.btn12_ReadWrite_Form.UseVisualStyleBackColor = true;
            this.btn12_ReadWrite_Form.Click += new System.EventHandler(this.btn12_ReadWrite_Form_Click);
            // 
            // btn11_Path_Form
            // 
            this.btn11_Path_Form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn11_Path_Form.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn11_Path_Form.Location = new System.Drawing.Point(35, 413);
            this.btn11_Path_Form.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn11_Path_Form.Name = "btn11_Path_Form";
            this.btn11_Path_Form.Size = new System.Drawing.Size(149, 24);
            this.btn11_Path_Form.TabIndex = 3;
            this.btn11_Path_Form.Text = "Path";
            this.btn11_Path_Form.UseVisualStyleBackColor = true;
            this.btn11_Path_Form.Click += new System.EventHandler(this.btn11_Path_Form_Click);
            // 
            // btn10_Generic_List_Form
            // 
            this.btn10_Generic_List_Form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn10_Generic_List_Form.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn10_Generic_List_Form.Location = new System.Drawing.Point(35, 384);
            this.btn10_Generic_List_Form.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn10_Generic_List_Form.Name = "btn10_Generic_List_Form";
            this.btn10_Generic_List_Form.Size = new System.Drawing.Size(149, 24);
            this.btn10_Generic_List_Form.TabIndex = 3;
            this.btn10_Generic_List_Form.Text = "Generic List";
            this.btn10_Generic_List_Form.UseVisualStyleBackColor = true;
            this.btn10_Generic_List_Form.Click += new System.EventHandler(this.btn10_Generic_List_Form_Click);
            // 
            // btn09_ArrayList_Form
            // 
            this.btn09_ArrayList_Form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn09_ArrayList_Form.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn09_ArrayList_Form.Location = new System.Drawing.Point(35, 355);
            this.btn09_ArrayList_Form.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn09_ArrayList_Form.Name = "btn09_ArrayList_Form";
            this.btn09_ArrayList_Form.Size = new System.Drawing.Size(149, 24);
            this.btn09_ArrayList_Form.TabIndex = 3;
            this.btn09_ArrayList_Form.Text = "Array List";
            this.btn09_ArrayList_Form.UseVisualStyleBackColor = true;
            this.btn09_ArrayList_Form.Click += new System.EventHandler(this.btn09_ArrayList_Form_Click);
            // 
            // btn14_PictureForm
            // 
            this.btn14_PictureForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn14_PictureForm.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn14_PictureForm.Location = new System.Drawing.Point(35, 226);
            this.btn14_PictureForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn14_PictureForm.Name = "btn14_PictureForm";
            this.btn14_PictureForm.Size = new System.Drawing.Size(149, 24);
            this.btn14_PictureForm.TabIndex = 3;
            this.btn14_PictureForm.Text = "Picture Viewer";
            this.btn14_PictureForm.UseVisualStyleBackColor = true;
            this.btn14_PictureForm.Click += new System.EventHandler(this.btn14_PictureForm_Click);
            // 
            // btn13_GuessForm
            // 
            this.btn13_GuessForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn13_GuessForm.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn13_GuessForm.Location = new System.Drawing.Point(35, 197);
            this.btn13_GuessForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn13_GuessForm.Name = "btn13_GuessForm";
            this.btn13_GuessForm.Size = new System.Drawing.Size(149, 24);
            this.btn13_GuessForm.TabIndex = 3;
            this.btn13_GuessForm.Text = "Guess";
            this.btn13_GuessForm.UseVisualStyleBackColor = true;
            this.btn13_GuessForm.Click += new System.EventHandler(this.btn13_GuessForm_Click);
            // 
            // btn08_Student_GradeForm
            // 
            this.btn08_Student_GradeForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn08_Student_GradeForm.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn08_Student_GradeForm.Location = new System.Drawing.Point(35, 168);
            this.btn08_Student_GradeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn08_Student_GradeForm.Name = "btn08_Student_GradeForm";
            this.btn08_Student_GradeForm.Size = new System.Drawing.Size(149, 24);
            this.btn08_Student_GradeForm.TabIndex = 3;
            this.btn08_Student_GradeForm.Text = "Student Grade";
            this.btn08_Student_GradeForm.UseVisualStyleBackColor = true;
            this.btn08_Student_GradeForm.Click += new System.EventHandler(this.btn08_Student_GradeForm_Click);
            // 
            // btn07_CalculatorForm
            // 
            this.btn07_CalculatorForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn07_CalculatorForm.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn07_CalculatorForm.Location = new System.Drawing.Point(35, 139);
            this.btn07_CalculatorForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn07_CalculatorForm.Name = "btn07_CalculatorForm";
            this.btn07_CalculatorForm.Size = new System.Drawing.Size(149, 24);
            this.btn07_CalculatorForm.TabIndex = 3;
            this.btn07_CalculatorForm.Text = "Calculator";
            this.btn07_CalculatorForm.UseVisualStyleBackColor = true;
            this.btn07_CalculatorForm.Click += new System.EventHandler(this.btn07_CalculatorForm_Click);
            // 
            // btn06_ForLoopForm
            // 
            this.btn06_ForLoopForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn06_ForLoopForm.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn06_ForLoopForm.Location = new System.Drawing.Point(35, 326);
            this.btn06_ForLoopForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn06_ForLoopForm.Name = "btn06_ForLoopForm";
            this.btn06_ForLoopForm.Size = new System.Drawing.Size(149, 24);
            this.btn06_ForLoopForm.TabIndex = 3;
            this.btn06_ForLoopForm.Text = "Loop";
            this.btn06_ForLoopForm.UseVisualStyleBackColor = true;
            this.btn06_ForLoopForm.Click += new System.EventHandler(this.btn06_ForLoopForm_Click);
            // 
            // btn05_ScreenSaver
            // 
            this.btn05_ScreenSaver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn05_ScreenSaver.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn05_ScreenSaver.Location = new System.Drawing.Point(35, 110);
            this.btn05_ScreenSaver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn05_ScreenSaver.Name = "btn05_ScreenSaver";
            this.btn05_ScreenSaver.Size = new System.Drawing.Size(149, 24);
            this.btn05_ScreenSaver.TabIndex = 3;
            this.btn05_ScreenSaver.Text = "Screen Saver";
            this.btn05_ScreenSaver.UseVisualStyleBackColor = true;
            this.btn05_ScreenSaver.Click += new System.EventHandler(this.btn05_ScreenSaver_Click);
            // 
            // btn04_MethodForm
            // 
            this.btn04_MethodForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn04_MethodForm.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn04_MethodForm.Location = new System.Drawing.Point(35, 298);
            this.btn04_MethodForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn04_MethodForm.Name = "btn04_MethodForm";
            this.btn04_MethodForm.Size = new System.Drawing.Size(149, 24);
            this.btn04_MethodForm.TabIndex = 3;
            this.btn04_MethodForm.Text = "Method";
            this.btn04_MethodForm.UseVisualStyleBackColor = true;
            this.btn04_MethodForm.Click += new System.EventHandler(this.btn04_MethodForm_Click);
            // 
            // btn03_POSForm
            // 
            this.btn03_POSForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn03_POSForm.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn03_POSForm.Location = new System.Drawing.Point(35, 82);
            this.btn03_POSForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn03_POSForm.Name = "btn03_POSForm";
            this.btn03_POSForm.Size = new System.Drawing.Size(149, 24);
            this.btn03_POSForm.TabIndex = 3;
            this.btn03_POSForm.Text = "POS";
            this.btn03_POSForm.UseVisualStyleBackColor = true;
            this.btn03_POSForm.Click += new System.EventHandler(this.btn03_POSForm_Click);
            // 
            // btn02_CompoundForm
            // 
            this.btn02_CompoundForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn02_CompoundForm.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn02_CompoundForm.Location = new System.Drawing.Point(35, 53);
            this.btn02_CompoundForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn02_CompoundForm.Name = "btn02_CompoundForm";
            this.btn02_CompoundForm.Size = new System.Drawing.Size(149, 24);
            this.btn02_CompoundForm.TabIndex = 2;
            this.btn02_CompoundForm.Text = "Compound";
            this.btn02_CompoundForm.UseVisualStyleBackColor = true;
            this.btn02_CompoundForm.Click += new System.EventHandler(this.btn02_CompoundForm_Click);
            // 
            // btn01_HelloForm
            // 
            this.btn01_HelloForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn01_HelloForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn01_HelloForm.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn01_HelloForm.Location = new System.Drawing.Point(35, 24);
            this.btn01_HelloForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn01_HelloForm.Name = "btn01_HelloForm";
            this.btn01_HelloForm.Size = new System.Drawing.Size(149, 28);
            this.btn01_HelloForm.TabIndex = 1;
            this.btn01_HelloForm.Text = "Hello";
            this.btn01_HelloForm.UseVisualStyleBackColor = true;
            this.btn01_HelloForm.Click += new System.EventHandler(this.btn01_HelloForm_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 606);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomePage";
            this.Text = "主畫面";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label_Home_Intro;
        private System.Windows.Forms.Button btn02_CompoundForm;
        private System.Windows.Forms.Button btn03_POSForm;
        private System.Windows.Forms.Button btn04_MethodForm;
        private System.Windows.Forms.Button btn00_Change_Color;
        private System.Windows.Forms.Button btn05_ScreenSaver;
        private System.Windows.Forms.Button btn06_ForLoopForm;
        private System.Windows.Forms.Button btn07_CalculatorForm;
        private System.Windows.Forms.Button btn08_Student_GradeForm;
        private System.Windows.Forms.Button btn09_ArrayList_Form;
        private System.Windows.Forms.Button btn10_Generic_List_Form;
        private System.Windows.Forms.Button btn11_Path_Form;
        private System.Windows.Forms.Button btn12_ReadWrite_Form;
        private System.Windows.Forms.Button btn01_HelloForm;
        private System.Windows.Forms.Button btn13_GuessForm;
        private System.Windows.Forms.Button btn14_PictureForm;
    }
}

