namespace Applicazione
{
    partial class FormStudente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.etichettaMatricola = new System.Windows.Forms.Label();
            this.etichettaNome = new System.Windows.Forms.Label();
            this.etichettaCognome = new System.Windows.Forms.Label();
            this.etichettaDataNascita = new System.Windows.Forms.Label();
            this.etichettaClasse = new System.Windows.Forms.Label();
            this.listaVoti = new System.Windows.Forms.ListBox();
            this.bottoneLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etichettaMatricola
            // 
            this.etichettaMatricola.AutoSize = true;
            this.etichettaMatricola.Location = new System.Drawing.Point(12, 9);
            this.etichettaMatricola.Name = "etichettaMatricola";
            this.etichettaMatricola.Size = new System.Drawing.Size(53, 13);
            this.etichettaMatricola.TabIndex = 0;
            this.etichettaMatricola.Text = "Matricola:";
            // 
            // etichettaNome
            // 
            this.etichettaNome.AutoSize = true;
            this.etichettaNome.Location = new System.Drawing.Point(12, 32);
            this.etichettaNome.Name = "etichettaNome";
            this.etichettaNome.Size = new System.Drawing.Size(38, 13);
            this.etichettaNome.TabIndex = 1;
            this.etichettaNome.Text = "Nome:";
            // 
            // etichettaCognome
            // 
            this.etichettaCognome.AutoSize = true;
            this.etichettaCognome.Location = new System.Drawing.Point(12, 55);
            this.etichettaCognome.Name = "etichettaCognome";
            this.etichettaCognome.Size = new System.Drawing.Size(55, 13);
            this.etichettaCognome.TabIndex = 2;
            this.etichettaCognome.Text = "Cognome:";
            // 
            // etichettaDataNascita
            // 
            this.etichettaDataNascita.AutoSize = true;
            this.etichettaDataNascita.Location = new System.Drawing.Point(12, 78);
            this.etichettaDataNascita.Name = "etichettaDataNascita";
            this.etichettaDataNascita.Size = new System.Drawing.Size(82, 13);
            this.etichettaDataNascita.TabIndex = 3;
            this.etichettaDataNascita.Text = "Data di Nascita:";
            // 
            // etichettaClasse
            // 
            this.etichettaClasse.AutoSize = true;
            this.etichettaClasse.Location = new System.Drawing.Point(12, 101);
            this.etichettaClasse.Name = "etichettaClasse";
            this.etichettaClasse.Size = new System.Drawing.Size(39, 13);
            this.etichettaClasse.TabIndex = 4;
            this.etichettaClasse.Text = "Classe:";
            // 
            // listaVoti
            // 
            this.listaVoti.FormattingEnabled = true;
            this.listaVoti.Location = new System.Drawing.Point(15, 127);
            this.listaVoti.Name = "listaVoti";
            this.listaVoti.Size = new System.Drawing.Size(257, 95);
            this.listaVoti.TabIndex = 5;
            // 
            // bottoneLogout
            // 
            this.bottoneLogout.Location = new System.Drawing.Point(197, 228);
            this.bottoneLogout.Name = "bottoneLogout";
            this.bottoneLogout.Size = new System.Drawing.Size(75, 23);
            this.bottoneLogout.TabIndex = 6;
            this.bottoneLogout.Text = "Logout";
            this.bottoneLogout.UseVisualStyleBackColor = true;
            this.bottoneLogout.Click += new System.EventHandler(this.BottoneLogout_Click);
            // 
            // FormStudente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bottoneLogout);
            this.Controls.Add(this.listaVoti);
            this.Controls.Add(this.etichettaClasse);
            this.Controls.Add(this.etichettaDataNascita);
            this.Controls.Add(this.etichettaCognome);
            this.Controls.Add(this.etichettaNome);
            this.Controls.Add(this.etichettaMatricola);
            this.Name = "FormStudente";
            this.Text = "Dettagli Studente";
            this.Load += new System.EventHandler(this.FormStudente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label etichettaMatricola;
        private System.Windows.Forms.Label etichettaNome;
        private System.Windows.Forms.Label etichettaCognome;
        private System.Windows.Forms.Label etichettaDataNascita;
        private System.Windows.Forms.Label etichettaClasse;
        private System.Windows.Forms.ListBox listaVoti;
        private System.Windows.Forms.Button bottoneLogout;
    }
}
