using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cancella
{
    public partial class Form2 : Form
    {
        public Studente studentee;
        public Form2(Studente stu)
        {
            this.studentee = stu;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = $"Matricola: {studentee.Matricola}";
            label2.Text = $"Nome: {studentee.Nome}";
            label3.Text = $"Cognome: {studentee.Cognome}";
            label4.Text = $"Data di Nascita: {studentee.DataNascita.ToShortDateString()}";
            label6.Text = $"Classe: {studentee.Classe}";

            foreach (var materia in studentee.Voti)
            {
                string voti = string.Join(", ", materia.Value);
                listBox1.Items.Add($"{materia.Key}: {voti}");
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
