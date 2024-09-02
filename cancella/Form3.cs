using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Applicazione
{
    public partial class FormProfessore : Form
    {
        private List<Studente> _studenti;
        private readonly string _fileStudenti = "studenti.json";

        public FormProfessore(Professore prof)
        {
            InitializeComponent();
            CaricaStudenti();
            VisualizzaVoti();
        }

        private void CaricaStudenti()
        {
            try
            {
                if (File.Exists(_fileStudenti))
                {
                    var json = File.ReadAllText(_fileStudenti);
                    _studenti = JsonConvert.DeserializeObject<List<Studente>>(json) ?? new List<Studente>();
                }
                else
                {
                    MessageBox.Show("Il file degli studenti non è stato trovato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _studenti = new List<Studente>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel caricamento degli studenti: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _studenti = new List<Studente>();
            }
        }

        private void VisualizzaVoti()
        {
            dataGridView1.Rows.Clear();

            foreach (var studente in _studenti)
            {
                foreach (var materia in studente.Voti)
                {
                    foreach (var voto in materia.Value)
                    {
                        dataGridView1.Rows.Add(studente.Matricola, studente.Nome, materia.Key, voto);
                    }
                }
            }
        }

        private void SalvaStudenti()
        {
            try
            {
                var json = JsonConvert.SerializeObject(_studenti, Formatting.Indented);
                File.WriteAllText(_fileStudenti, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel salvataggio degli studenti: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProfessore_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Matricola";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Materia";
            dataGridView1.Columns[3].Name = "Voto";
            VisualizzaVoti();
        }

        private void btnEliminaVoto_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxMatricola.Text, out int matricola) &&
                !string.IsNullOrEmpty(textBoxMateria.Text) &&
                int.TryParse(textBoxVoto.Text, out int voto))
            {
                var studente = _studenti.FirstOrDefault(s => s.Matricola == matricola);
                if (studente != null)
                {
                    if (studente.Voti.ContainsKey(textBoxMateria.Text))
                    {
                        studente.Voti[textBoxMateria.Text].Remove(voto);

                        SalvaStudenti();
                        VisualizzaVoti();
                    }
                    else
                    {
                        MessageBox.Show("Materia non trovata.");
                    }
                }
                else
                {
                    MessageBox.Show("Studente non trovato.");
                }
            }
            else
            {
                MessageBox.Show("Inserisci dati validi.");
            }
        }

        private void btnAggiungiVoto_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxMatricola.Text, out int matricola) &&
              !string.IsNullOrEmpty(textBoxMateria.Text) &&
              int.TryParse(textBoxVoto.Text, out int voto))
            {
                var studente = _studenti.FirstOrDefault(s => s.Matricola == matricola);
                if (studente != null)
                {
                    if (!studente.Voti.ContainsKey(textBoxMateria.Text))
                    {
                        studente.Voti[textBoxMateria.Text] = new List<int>();
                    }
                    studente.Voti[textBoxMateria.Text].Add(voto);

                    SalvaStudenti();
                    VisualizzaVoti();
                }
                else
                {
                    MessageBox.Show("Studente non trovato.");
                }
            }
            else
            {
                MessageBox.Show("Inserisci dati validi.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}
