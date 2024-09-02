namespace Applicazione
{
    partial class FormProfessore
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxMatricola = new System.Windows.Forms.TextBox();
            this.textBoxMateria = new System.Windows.Forms.TextBox();
            this.textBoxVoto = new System.Windows.Forms.TextBox();
            this.btnAggiungiVoto = new System.Windows.Forms.Button();
            this.btnEliminaVoto = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxMatricola
            // 
            this.textBoxMatricola.Location = new System.Drawing.Point(12, 184);
            this.textBoxMatricola.Name = "textBoxMatricola";
            this.textBoxMatricola.Size = new System.Drawing.Size(120, 20);
            this.textBoxMatricola.TabIndex = 1;
            this.textBoxMatricola.BackColor = System.Drawing.Color.LightYellow;
            // 
            // textBoxMateria
            // 
            this.textBoxMateria.Location = new System.Drawing.Point(138, 184);
            this.textBoxMateria.Name = "textBoxMateria";
            this.textBoxMateria.Size = new System.Drawing.Size(120, 20);
            this.textBoxMateria.TabIndex = 2;
            this.textBoxMateria.BackColor = System.Drawing.Color.LightYellow;
            // 
            // textBoxVoto
            // 
            this.textBoxVoto.Location = new System.Drawing.Point(264, 184);
            this.textBoxVoto.Name = "textBoxVoto";
            this.textBoxVoto.Size = new System.Drawing.Size(120, 20);
            this.textBoxVoto.TabIndex = 3;
            this.textBoxVoto.BackColor = System.Drawing.Color.LightYellow;
            // 
            // btnAggiungiVoto
            // 
            this.btnAggiungiVoto.BackColor = System.Drawing.Color.LightGreen;
            this.btnAggiungiVoto.Location = new System.Drawing.Point(390, 182);
            this.btnAggiungiVoto.Name = "btnAggiungiVoto";
            this.btnAggiungiVoto.Size = new System.Drawing.Size(90, 25);
            this.btnAggiungiVoto.TabIndex = 4;
            this.btnAggiungiVoto.Text = "Aggiungi Voto";
            this.btnAggiungiVoto.UseVisualStyleBackColor = false;
            this.btnAggiungiVoto.Click += new System.EventHandler(this.btnAggiungiVoto_Click);
            // 
            // btnEliminaVoto
            // 
            this.btnEliminaVoto.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminaVoto.Location = new System.Drawing.Point(486, 182);
            this.btnEliminaVoto.Name = "btnEliminaVoto";
            this.btnEliminaVoto.Size = new System.Drawing.Size(90, 25);
            this.btnEliminaVoto.TabIndex = 5;
            this.btnEliminaVoto.Text = "Elimina Voto";
            this.btnEliminaVoto.UseVisualStyleBackColor = false;
            this.btnEliminaVoto.Click += new System.EventHandler(this.btnEliminaVoto_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.Location = new System.Drawing.Point(486, 213);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 25);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormProfessore
            // 
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEliminaVoto);
            this.Controls.Add(this.btnAggiungiVoto);
            this.Controls.Add(this.textBoxVoto);
            this.Controls.Add(this.textBoxMateria);
            this.Controls.Add(this.textBoxMatricola);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormProfessore";
            this.Text = "Gestione Voti Studenti";
            this.Load += new System.EventHandler(this.FormProfessore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxMatricola;
        private System.Windows.Forms.TextBox textBoxMateria;
        private System.Windows.Forms.TextBox textBoxVoto;
        private System.Windows.Forms.Button btnAggiungiVoto;
        private System.Windows.Forms.Button btnEliminaVoto;
        private System.Windows.Forms.Button btnLogout;
    }
}
