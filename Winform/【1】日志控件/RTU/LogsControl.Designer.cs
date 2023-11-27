namespace RTU
{
    partial class LogsControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AddBtn = new System.Windows.Forms.Button();
            this.LogListView = new System.Windows.Forms.ListView();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.AutoRollBtn = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.InfoBtn = new System.Windows.Forms.RadioButton();
            this.WarnBtn = new System.Windows.Forms.RadioButton();
            this.ErrorBtn = new System.Windows.Forms.RadioButton();
            this.AutoAddBtn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(476, 0);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(113, 25);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "手动添加Test";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // LogListView
            // 
            this.LogListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogListView.BackColor = System.Drawing.SystemColors.Window;
            this.LogListView.HideSelection = false;
            this.LogListView.Location = new System.Drawing.Point(0, 25);
            this.LogListView.Name = "LogListView";
            this.LogListView.Size = new System.Drawing.Size(729, 66);
            this.LogListView.TabIndex = 8;
            this.LogListView.UseCompatibleStateImageBehavior = false;
            this.LogListView.View = System.Windows.Forms.View.Details;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(683, 0);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(60, 25);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "清空";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // AutoRollBtn
            // 
            this.AutoRollBtn.AutoSize = true;
            this.AutoRollBtn.Checked = true;
            this.AutoRollBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoRollBtn.Location = new System.Drawing.Point(605, 6);
            this.AutoRollBtn.Name = "AutoRollBtn";
            this.AutoRollBtn.Size = new System.Drawing.Size(72, 16);
            this.AutoRollBtn.TabIndex = 10;
            this.AutoRollBtn.Text = "自动滚动";
            this.AutoRollBtn.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "全部";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.AutoSize = true;
            this.InfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.InfoBtn.Location = new System.Drawing.Point(67, 5);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(65, 16);
            this.InfoBtn.TabIndex = 12;
            this.InfoBtn.Text = "正常(0)";
            this.InfoBtn.UseVisualStyleBackColor = false;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // WarnBtn
            // 
            this.WarnBtn.AutoSize = true;
            this.WarnBtn.BackColor = System.Drawing.Color.Transparent;
            this.WarnBtn.ForeColor = System.Drawing.Color.Blue;
            this.WarnBtn.Location = new System.Drawing.Point(150, 5);
            this.WarnBtn.Name = "WarnBtn";
            this.WarnBtn.Size = new System.Drawing.Size(65, 16);
            this.WarnBtn.TabIndex = 13;
            this.WarnBtn.Text = "警告(0)";
            this.WarnBtn.UseVisualStyleBackColor = false;
            this.WarnBtn.Click += new System.EventHandler(this.WarnBtn_Click);
            // 
            // ErrorBtn
            // 
            this.ErrorBtn.AutoSize = true;
            this.ErrorBtn.BackColor = System.Drawing.Color.Transparent;
            this.ErrorBtn.ForeColor = System.Drawing.Color.Red;
            this.ErrorBtn.Location = new System.Drawing.Point(233, 5);
            this.ErrorBtn.Name = "ErrorBtn";
            this.ErrorBtn.Size = new System.Drawing.Size(65, 16);
            this.ErrorBtn.TabIndex = 14;
            this.ErrorBtn.Text = "报警(0)";
            this.ErrorBtn.UseVisualStyleBackColor = false;
            this.ErrorBtn.Click += new System.EventHandler(this.ErrorBtn_Click);
            // 
            // AutoAddBtn
            // 
            this.AutoAddBtn.AutoSize = true;
            this.AutoAddBtn.Location = new System.Drawing.Point(374, 5);
            this.AutoAddBtn.Name = "AutoAddBtn";
            this.AutoAddBtn.Size = new System.Drawing.Size(96, 16);
            this.AutoAddBtn.TabIndex = 15;
            this.AutoAddBtn.Text = "自动添加Test";
            this.AutoAddBtn.UseVisualStyleBackColor = true;
            // 
            // LogsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AutoAddBtn);
            this.Controls.Add(this.ErrorBtn);
            this.Controls.Add(this.WarnBtn);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.AutoRollBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.LogListView);
            this.Controls.Add(this.AddBtn);
            this.Name = "LogsControl";
            this.Size = new System.Drawing.Size(743, 131);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ListView LogListView;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.CheckBox AutoRollBtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton InfoBtn;
        private System.Windows.Forms.RadioButton WarnBtn;
        private System.Windows.Forms.RadioButton ErrorBtn;
        private System.Windows.Forms.CheckBox AutoAddBtn;
    }
}
