namespace CashDinero
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.PasswordtextBox);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Location = new System.Drawing.Point(285, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 649);
            this.panel1.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(45, 193);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(414, 26);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(40, 311);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(414, 26);
            this.PasswordtextBox.TabIndex = 1;
            this.PasswordtextBox.TextChanged += new System.EventHandler(this.PasswordtextBox_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(45, 440);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(409, 34);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1112, 1025);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}

