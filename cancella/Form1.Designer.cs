namespace Applicazione
{
    partial class FormPrincipale
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">True se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.etichettaUsername = new System.Windows.Forms.Label();
            this.etichettaPassword = new System.Windows.Forms.Label();
            this.testoUsername = new System.Windows.Forms.TextBox();
            this.testoPassword = new System.Windows.Forms.TextBox();
            this.bottoneLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etichettaUsername
            // 
            this.etichettaUsername.AutoSize = true;
            this.etichettaUsername.Location = new System.Drawing.Point(143, 42);
            this.etichettaUsername.Name = "etichettaUsername";
            this.etichettaUsername.Size = new System.Drawing.Size(53, 13);
            this.etichettaUsername.TabIndex = 0;
            this.etichettaUsername.Text = "Username";
            // 
            // etichettaPassword
            // 
            this.etichettaPassword.AutoSize = true;
            this.etichettaPassword.Location = new System.Drawing.Point(143, 70);
            this.etichettaPassword.Name = "etichettaPassword";
            this.etichettaPassword.Size = new System.Drawing.Size(53, 13);
            this.etichettaPassword.TabIndex = 1;
            this.etichettaPassword.Text = "Password";
            // 
            // testoUsername
            // 
            this.testoUsername.Location = new System.Drawing.Point(201, 42);
            this.testoUsername.Name = "testoUsername";
            this.testoUsername.Size = new System.Drawing.Size(100, 20);
            this.testoUsername.TabIndex = 2;
            // 
            // testoPassword
            // 
            this.testoPassword.Location = new System.Drawing.Point(201, 70);
            this.testoPassword.Name = "testoPassword";
            this.testoPassword.PasswordChar = '*';
            this.testoPassword.Size = new System.Drawing.Size(100, 20);
            this.testoPassword.TabIndex = 3;
            // 
            // bottoneLogin
            // 
            this.bottoneLogin.Location = new System.Drawing.Point(201, 97);
            this.bottoneLogin.Name = "bottoneLogin";
            this.bottoneLogin.Size = new System.Drawing.Size(75, 23);
            this.bottoneLogin.TabIndex = 4;
            this.bottoneLogin.Text = "Login";
            this.bottoneLogin.UseVisualStyleBackColor = true;
            this.bottoneLogin.Click += new System.EventHandler(this.BottoneLogin_Click);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 241);
            this.Controls.Add(this.bottoneLogin);
            this.Controls.Add(this.testoPassword);
            this.Controls.Add(this.testoUsername);
            this.Controls.Add(this.etichettaPassword);
            this.Controls.Add(this.etichettaUsername);
            this.Name = "FormPrincipale";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etichettaUsername;
        private System.Windows.Forms.Label etichettaPassword;
        private System.Windows.Forms.TextBox testoUsername;
        private System.Windows.Forms.TextBox testoPassword;
        private System.Windows.Forms.Button bottoneLogin;
    }
}
