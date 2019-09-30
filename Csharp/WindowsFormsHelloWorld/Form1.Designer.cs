namespace WindowsFormsHelloWorld
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.textBoxshowhello = new System.Windows.Forms.TextBox();
            this.buttonsayhello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // textBoxshowhello
            // 
            this.textBoxshowhello.Location = new System.Drawing.Point(252, 12);
            this.textBoxshowhello.Name = "textBoxshowhello";
            this.textBoxshowhello.Size = new System.Drawing.Size(278, 21);
            this.textBoxshowhello.TabIndex = 0;
            // 
            // buttonsayhello
            // 
            this.buttonsayhello.Location = new System.Drawing.Point(252, 49);
            this.buttonsayhello.Name = "buttonsayhello";
            this.buttonsayhello.Size = new System.Drawing.Size(278, 23);
            this.buttonsayhello.TabIndex = 1;
            this.buttonsayhello.Text = "click me";
            this.buttonsayhello.UseVisualStyleBackColor = true;
            this.buttonsayhello.Click += new System.EventHandler(this.buttonsayhello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsayhello);
            this.Controls.Add(this.textBoxshowhello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox textBoxshowhello;
        private System.Windows.Forms.Button buttonsayhello;
    }
}

