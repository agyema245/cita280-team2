namespace expense_tracker
{
    partial class UserForm
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
            this.LNameTxt = new System.Windows.Forms.TextBox();
            this.FNameTxt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.signupbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LNameTxt
            // 
            this.LNameTxt.Location = new System.Drawing.Point(316, 64);
            this.LNameTxt.Name = "LNameTxt";
            this.LNameTxt.Size = new System.Drawing.Size(171, 26);
            this.LNameTxt.TabIndex = 0;
            // 
            // FNameTxt
            // 
            this.FNameTxt.Location = new System.Drawing.Point(110, 64);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.Size = new System.Drawing.Size(154, 26);
            this.FNameTxt.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 26);
            this.textBox3.TabIndex = 2;
            // 
            // signupbtn
            // 
            this.signupbtn.Location = new System.Drawing.Point(316, 321);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(136, 48);
            this.signupbtn.TabIndex = 3;
            this.signupbtn.Text = "button1";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.FNameTxt);
            this.Controls.Add(this.LNameTxt);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LNameTxt;
        private System.Windows.Forms.TextBox FNameTxt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button signupbtn;
    }
}