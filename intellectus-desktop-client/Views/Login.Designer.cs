namespace intellectus_desktop_client.Views
{
    partial class Login
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
            this.requiredText = new System.Windows.Forms.Label();
            this.username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // requiredText
            // 
            this.requiredText.AutoSize = true;
            this.requiredText.BackColor = System.Drawing.Color.Transparent;
            this.requiredText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.requiredText.Location = new System.Drawing.Point(268, 292);
            this.requiredText.Name = "requiredText";
            this.requiredText.Size = new System.Drawing.Size(156, 13);
            this.requiredText.TabIndex = 3;
            this.requiredText.Text = "*Usuario/Contraseña incorrecta";
            this.requiredText.Visible = false;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.White;
            this.username.Depth = 0;
            this.username.ForeColor = System.Drawing.Color.LightCoral;
            this.username.Hint = "Usuario";
            this.username.Location = new System.Drawing.Point(255, 137);
            this.username.MouseState = MaterialSkin.MouseState.HOVER;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.Size = new System.Drawing.Size(191, 23);
            this.username.TabIndex = 6;
            this.username.UseSystemPasswordChar = false;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.Depth = 0;
            this.password.Hint = "Contraseña";
            this.password.Location = new System.Drawing.Point(255, 183);
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(191, 23);
            this.password.TabIndex = 7;
            this.password.UseSystemPasswordChar = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(316, 235);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.requiredText);
            this.Name = "Login";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label requiredText;
        private MaterialSkin.Controls.MaterialSingleLineTextField username;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
    }
}