using System;
using System.Linq;
using System.Windows.Forms;

namespace Applicazione
{
    public partial class FormStudente : Form
    {
        private readonly Studente _studente;

        public FormStudente(Studente studente)
        {
            _studente = studente;
            InitializeComponent();
        }

        private void FormStudente_Load(object sender, EventArgs e)
        {
            etichettaMatricola.Text = $"Matricola: {_studente.Matricola}";
            etichettaNome.Text = $"Nome: {_studente.Nome}";
            etichettaCognome.Text = $"Cognome: {_studente.Cognome}";
            etichettaDataNascita.Text = $"Data di Nascita: {_studente.DataNascita.ToShortDateString()}";
            etichettaClasse.Text = $"Classe: {_studente.Classe}";

            foreach (var materia in _studente.Voti)
            {
                string voti = string.Join(", ", materia.Value);
                listaVoti.Items.Add($"{materia.Key}: {voti}");
            }
        }

        private void BottoneLogout_Click(object sender, EventArgs e)
        {
            var formPrincipale = new FormPrincipale();
            formPrincipale.Show();
            Hide();
        }
    }
}
