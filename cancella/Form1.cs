using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Applicazione
{
    public partial class FormPrincipale : Form
    {
        private readonly string _fileStudenti = "studenti.json";
        private readonly string _fileProfessori = "professori.json";
        private List<Studente> _studenti;
        private List<Professore> _professori;

        public FormPrincipale()
        {
            InitializeComponent();
            CaricaStudenti();
            CaricaProfessori();
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

        private void CaricaProfessori()
        {
            try
            {
                if (File.Exists(_fileProfessori))
                {
                    var json = File.ReadAllText(_fileProfessori);
                    _professori = JsonConvert.DeserializeObject<List<Professore>>(json) ?? new List<Professore>();
                }
                else
                {
                    MessageBox.Show("Il file dei professori non è stato trovato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _professori = new List<Professore>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel caricamento dei professori: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _professori = new List<Professore>();
            }
        }

        private void BottoneLogin_Click(object sender, EventArgs e)
        {
            var username = testoUsername.Text;
            var password = testoPassword.Text;

            if (int.TryParse(username, out int matricola))
            {
                var studente = _studenti.FirstOrDefault(s => s.Matricola == matricola);

                if (studente != null)
                {
                    var formStudente = new FormStudente(studente);
                    formStudente.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Studente non trovato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var professore = _professori.FirstOrDefault(p => p.Username == username && p.Password == password);

                if (professore != null)
                {
                    var formProfessore = new FormProfessore(professore);
                    formProfessore.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Username o password errati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

    public class Professore
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Matricola { get; set; }
    }
}
