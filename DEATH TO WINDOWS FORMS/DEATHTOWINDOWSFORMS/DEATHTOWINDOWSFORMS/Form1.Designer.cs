namespace DEATHTOWINDOWSFORMS
{
    partial class CUBRILOXDDDDDDDDDDDDDDDD
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
            this.loginButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.meButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(197, 226);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 208);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // meButton
            // 
            this.meButton.Location = new System.Drawing.Point(116, 226);
            this.meButton.Name = "meButton";
            this.meButton.Size = new System.Drawing.Size(75, 23);
            this.meButton.TabIndex = 3;
            this.meButton.Text = "Me";
            this.meButton.UseVisualStyleBackColor = true;
            this.meButton.Click += new System.EventHandler(this.meButton_Click);
            // 
            // CUBRILOXDDDDDDDDDDDDDDDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.meButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.loginButton);
            this.Name = "CUBRILOXDDDDDDDDDDDDDDDD";
            this.Text = "CUBRILOXDDDDDDDDDDDDDDD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button meButton;
    }
}

