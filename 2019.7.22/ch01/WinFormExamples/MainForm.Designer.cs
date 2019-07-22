namespace WinFormExamples
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
            this.components = new System.ComponentModel.Container();
            this.ButtonHelloWorld = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonTextBox = new System.Windows.Forms.Button();
            this.buttonCheckBox = new System.Windows.Forms.Button();
            this.buttonListBox = new System.Windows.Forms.Button();
            this.buttonError = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonHelloWorld
            // 
            this.ButtonHelloWorld.Location = new System.Drawing.Point(252, 37);
            this.ButtonHelloWorld.Name = "ButtonHelloWorld";
            this.ButtonHelloWorld.Size = new System.Drawing.Size(276, 43);
            this.ButtonHelloWorld.TabIndex = 0;
            this.ButtonHelloWorld.Text = "显示新窗体";
            this.ButtonHelloWorld.UseVisualStyleBackColor = true;
            this.ButtonHelloWorld.Click += new System.EventHandler(this.ButtonHelloWorld_Click);
            // 
            // buttonTextBox
            // 
            this.buttonTextBox.Location = new System.Drawing.Point(252, 109);
            this.buttonTextBox.Name = "buttonTextBox";
            this.buttonTextBox.Size = new System.Drawing.Size(276, 52);
            this.buttonTextBox.TabIndex = 1;
            this.buttonTextBox.Text = "TextBox示例";
            this.buttonTextBox.UseVisualStyleBackColor = true;
            // 
            // buttonCheckBox
            // 
            this.buttonCheckBox.Location = new System.Drawing.Point(252, 184);
            this.buttonCheckBox.Name = "buttonCheckBox";
            this.buttonCheckBox.Size = new System.Drawing.Size(276, 44);
            this.buttonCheckBox.TabIndex = 2;
            this.buttonCheckBox.Text = "CheckBox和RadioButton示例";
            this.buttonCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCheckBox.UseVisualStyleBackColor = true;
            this.buttonCheckBox.Click += new System.EventHandler(this.buttonCheckBox_Click);
            // 
            // buttonListBox
            // 
            this.buttonListBox.Location = new System.Drawing.Point(252, 255);
            this.buttonListBox.Name = "buttonListBox";
            this.buttonListBox.Size = new System.Drawing.Size(276, 45);
            this.buttonListBox.TabIndex = 3;
            this.buttonListBox.Text = "ListBox和ComboBox示例";
            this.buttonListBox.UseVisualStyleBackColor = true;
            this.buttonListBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonError
            // 
            this.buttonError.Location = new System.Drawing.Point(252, 332);
            this.buttonError.Name = "buttonError";
            this.buttonError.Size = new System.Drawing.Size(276, 38);
            this.buttonError.TabIndex = 4;
            this.buttonError.Text = "错误提示示例";
            this.buttonError.UseVisualStyleBackColor = true;
            this.buttonError.Click += new System.EventHandler(this.buttonError_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonError);
            this.Controls.Add(this.buttonListBox);
            this.Controls.Add(this.buttonCheckBox);
            this.Controls.Add(this.buttonTextBox);
            this.Controls.Add(this.ButtonHelloWorld);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonHelloWorld;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonTextBox;
        private System.Windows.Forms.Button buttonCheckBox;
        private System.Windows.Forms.Button buttonListBox;
        private System.Windows.Forms.Button buttonError;
    }
}

