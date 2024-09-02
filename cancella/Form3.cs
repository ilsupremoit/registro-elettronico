using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace cancella
{
    public partial class Form3 : Form
    {
        private List<Studente> studenti;
        private string jsonStu = "students.json";

        public Form3(Profe prof)
        {
            InitializeComponent();
            CaricaStudenti();
            VisualizzaVoti();
        }

        private void CaricaStudenti()
        {
            try
            {
                var json = File.ReadAllText(jsonStu);
                studenti = JsonConvert.DeserializeObject<List<Studente>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel caricamento degli studenti: {ex.Message}");
            }
        }

        private void VisualizzaVoti()
        {
            dataGridView1.Rows.Clear();

            foreach (var studente in studenti)
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
                var json = JsonConvert.SerializeObject(studenti, Formatting.Indented);
                File.WriteAllText(jsonStu, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel salvataggio degli studenti: {ex.Message}");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Matricola";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Materia";
            dataGridView1.Columns[3].Name = "Voto";

            VisualizzaVoti();
        }

        private void btnEliminaVoto_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("ciao");
            if (int.TryParse(textBox1.Text, out int matricola) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                int.TryParse(textBox3.Text, out int voto))
            {
                var studente = studenti.FirstOrDefault(s => s.Matricola == matricola);
                if (studente != null)
                {
                    if (studente.Voti.ContainsKey(textBox2.Text))
                    {
                        studente.Voti[textBox2.Text].Remove(voto);

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
            if (int.TryParse(textBox1.Text, out int matricola) &&
              !string.IsNullOrEmpty(textBox2.Text) &&
              int.TryParse(textBox3.Text, out int voto))
            {
                var studente = studenti.FirstOrDefault(s => s.Matricola == matricola);
                if (studente != null)
                {
                    if (!studente.Voti.ContainsKey(textBox2.Text))
                    {
                        studente.Voti[textBox2.Text] = new List<int>();
                    }
                    studente.Voti[textBox2.Text].Add(voto);

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
            return;
        }
    }
}
