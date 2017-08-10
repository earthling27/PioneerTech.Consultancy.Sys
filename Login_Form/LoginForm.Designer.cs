namespace Login_Form
{
    partial class login_form
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
            this.UserName_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.UserName_textbox = new System.Windows.Forms.TextBox();
            this.PassWord_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName_Label
            // 
            this.UserName_Label.AutoSize = true;
            this.UserName_Label.Location = new System.Drawing.Point(12, 88);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.Size = new System.Drawing.Size(60, 13);
            this.UserName_Label.TabIndex = 0;
            this.UserName_Label.Text = "User Name";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(12, 124);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(53, 13);
            this.Password_Label.TabIndex = 1;
            this.Password_Label.Text = "Password";
            // 
            // UserName_textbox
            // 
            this.UserName_textbox.Location = new System.Drawing.Point(79, 85);
            this.UserName_textbox.Name = "UserName_textbox";
            this.UserName_textbox.Size = new System.Drawing.Size(127, 20);
            this.UserName_textbox.TabIndex = 2;
            // 
            // PassWord_textbox
            // 
            this.PassWord_textbox.Location = new System.Drawing.Point(79, 117);
            this.PassWord_textbox.Name = "PassWord_textbox";
            this.PassWord_textbox.Size = new System.Drawing.Size(127, 20);
            this.PassWord_textbox.TabIndex = 3;
            this.PassWord_textbox.TextChanged += new System.EventHandler(this.PassWord_textbox_TextChanged);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(99, 196);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Form.Properties.Resources.login_pic;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.PassWord_textbox);
            this.Controls.Add(this.UserName_textbox);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.UserName_Label);
            this.Name = "login_form";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox UserName_textbox;
        private System.Windows.Forms.TextBox PassWord_textbox;
        private System.Windows.Forms.Button login_button;
    }
}

