namespace RTU
{
    partial class MainForm
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
            this.ReadRegistersButton = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.StartAddressTextBox = new System.Windows.Forms.TextBox();
            this.RegistersListBox = new System.Windows.Forms.ListBox();
            this.NumRegistersTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ReadRegistersButton
            // 
            this.ReadRegistersButton.Location = new System.Drawing.Point(594, 150);
            this.ReadRegistersButton.Name = "ReadRegistersButton";
            this.ReadRegistersButton.Size = new System.Drawing.Size(75, 23);
            this.ReadRegistersButton.TabIndex = 0;
            this.ReadRegistersButton.Text = "读取";
            this.ReadRegistersButton.UseVisualStyleBackColor = true;
            this.ReadRegistersButton.Click += new System.EventHandler(this.ReadRegisters_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(529, 63);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "关闭";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // StartAddressTextBox
            // 
            this.StartAddressTextBox.Location = new System.Drawing.Point(414, 101);
            this.StartAddressTextBox.Name = "StartAddressTextBox";
            this.StartAddressTextBox.Size = new System.Drawing.Size(100, 21);
            this.StartAddressTextBox.TabIndex = 2;
            this.StartAddressTextBox.Text = "起始地址";
            this.StartAddressTextBox.TextChanged += new System.EventHandler(this.StartAddressTextBox_TextChanged);
            // 
            // RegistersListBox
            // 
            this.RegistersListBox.FormattingEnabled = true;
            this.RegistersListBox.ItemHeight = 12;
            this.RegistersListBox.Items.AddRange(new object[] {
            "寄存器列表"});
            this.RegistersListBox.Location = new System.Drawing.Point(456, 150);
            this.RegistersListBox.Name = "RegistersListBox";
            this.RegistersListBox.Size = new System.Drawing.Size(120, 88);
            this.RegistersListBox.TabIndex = 3;
            // 
            // NumRegistersTextBox
            // 
            this.NumRegistersTextBox.Location = new System.Drawing.Point(569, 101);
            this.NumRegistersTextBox.Name = "NumRegistersTextBox";
            this.NumRegistersTextBox.Size = new System.Drawing.Size(100, 21);
            this.NumRegistersTextBox.TabIndex = 4;
            this.NumRegistersTextBox.Text = "寄存器数量";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumRegistersTextBox);
            this.Controls.Add(this.RegistersListBox);
            this.Controls.Add(this.StartAddressTextBox);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.ReadRegistersButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadRegistersButton;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox StartAddressTextBox;
        private System.Windows.Forms.ListBox RegistersListBox;
        private System.Windows.Forms.TextBox NumRegistersTextBox;
    }
}

