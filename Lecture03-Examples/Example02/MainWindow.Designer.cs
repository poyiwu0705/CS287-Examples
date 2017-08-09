namespace Example02
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.AddProduct1Button = new System.Windows.Forms.Button();
            this.Product1Label = new System.Windows.Forms.Label();
            this.Product2Label = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AddProduct2Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProduct1Button
            // 
            this.AddProduct1Button.Location = new System.Drawing.Point(1039, 71);
            this.AddProduct1Button.Name = "AddProduct1Button";
            this.AddProduct1Button.Size = new System.Drawing.Size(423, 130);
            this.AddProduct1Button.TabIndex = 0;
            this.AddProduct1Button.Text = "加入購物車清單";
            this.AddProduct1Button.UseVisualStyleBackColor = true;
            this.AddProduct1Button.Click += new System.EventHandler(this.AddProduct1Button_Click);
            // 
            // Product1Label
            // 
            this.Product1Label.AutoSize = true;
            this.Product1Label.Location = new System.Drawing.Point(114, 113);
            this.Product1Label.Name = "Product1Label";
            this.Product1Label.Size = new System.Drawing.Size(305, 48);
            this.Product1Label.TabIndex = 1;
            this.Product1Label.Text = "Product1 Name";
            // 
            // Product2Label
            // 
            this.Product2Label.AutoSize = true;
            this.Product2Label.Location = new System.Drawing.Point(119, 248);
            this.Product2Label.Name = "Product2Label";
            this.Product2Label.Size = new System.Drawing.Size(305, 48);
            this.Product2Label.TabIndex = 2;
            this.Product2Label.Text = "Product2 Name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(78, 437);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1393, 410);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // AddProduct2Button
            // 
            this.AddProduct2Button.Location = new System.Drawing.Point(1039, 248);
            this.AddProduct2Button.Name = "AddProduct2Button";
            this.AddProduct2Button.Size = new System.Drawing.Size(423, 130);
            this.AddProduct2Button.TabIndex = 4;
            this.AddProduct2Button.Text = "加入購物車清單";
            this.AddProduct2Button.UseVisualStyleBackColor = true;
            this.AddProduct2Button.Click += new System.EventHandler(this.AddProduct2Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 964);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "總金額:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1092, 947);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 119);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 1178);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddProduct2Button);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Product2Label);
            this.Controls.Add(this.Product1Label);
            this.Controls.Add(this.AddProduct1Button);
            this.Font = new System.Drawing.Font("新細明體", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "歡迎光臨AppleStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Product2Label;
        private System.Windows.Forms.Label Product1Label;
        private System.Windows.Forms.Button AddProduct1Button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button AddProduct2Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

