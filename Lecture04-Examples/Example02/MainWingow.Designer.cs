namespace Example02
{
    partial class MainWingow
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.ElsaPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ElsaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ElsaPictureBox
            // 
            this.ElsaPictureBox.Image = global::Example02.Properties.Resources._6d7454cea6644379adc7e529c5790a28078a2823;
            this.ElsaPictureBox.Location = new System.Drawing.Point(125, 87);
            this.ElsaPictureBox.Name = "ElsaPictureBox";
            this.ElsaPictureBox.Size = new System.Drawing.Size(358, 369);
            this.ElsaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ElsaPictureBox.TabIndex = 0;
            this.ElsaPictureBox.TabStop = false;
            // 
            // MainWingow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 768);
            this.Controls.Add(this.ElsaPictureBox);
            this.Name = "MainWingow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ElsaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ElsaPictureBox;
    }
}

