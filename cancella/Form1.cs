using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace cancella
{
    public partial class Form1 : Form
    {
        public string jsonStu = "students.json";
        public string jsonProf = "prof.json";
        private List<Studente> studenti;
        private List<Profe> prof;

        public Form1()
        {
            InitializeComponent();
            CaricaStudenti();
            CaricaProf();
        }

        public void CaricaStudenti()
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

        public void CaricaProf()
        {
            try
            {
                var json = File.ReadAllText(jsonProf);
                prof = JsonConvert.DeserializeObject<List<Profe>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel caricamento dei professori: {ex.Message}");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = nome.Text;
            string password = password1.Text;

            if (int.TryParse(username, out int matricola))
            {



                var studente = studenti.FirstOrDefault(s => s.Matricola == matricola);

                if (studente != null)
                {
                    Form2 studentForm = new Form2(studente);
                    studentForm.Show();
                    this.Hide();
                    return;
                }
            }
            else
            {



                var professore = prof.FirstOrDefault(p => p.Username == username && p.Password == password);

                if (professore != null)
                {
                    Form3 profForm = new Form3(professore);
                    profForm.Show();
                    this.Hide();
                    return;
                }

                MessageBox.Show("Username o password errati.");
            }
        }
    }

    public class Studente
    {
        public int Matricola { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string LuogoNascita { get; set; }
        public string Classe { get; set; }
        public Dictionary<string, List<int>> Voti { get; set; }
    }

    public class Profe
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Matricola { get; set; }
    }
}
