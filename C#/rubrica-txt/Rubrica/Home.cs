using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Rubrica
{
    public partial class Home : Form
    {
        private class Contatto
        {
            private string Nome;
            private string Cognome;
            private ulong Numero;
            private string Email;
            private string Nascita;
            private string Indirizzo;

            public Contatto(string n, string c, ulong num, string mail, string nato, string casa)
            {
                Nome = n;
                Cognome = c;
                Numero = num;
                Email = mail;
                Nascita = nato;
                Indirizzo = casa;
            }

            public string nome
            {
                get { return Nome; }
                set { Nome = value; }
            }
            public string cognome
            {
                get { return Cognome; }
                set { Cognome = value; }
            }
            public ulong numero
            {
                get { return Numero; }
                set { Numero = value; }
            }
            public string email
            {
                get { return Email; }
                set { Email = value; }
            }
            public string nascita
            {
                get { return Nascita; }
                set { Nascita = value; }
            }
            public string indirizzo
            {
                get { return Indirizzo; }
                set { Indirizzo = value; }
            }
        }

        public Home()
        {
            InitializeComponent();

            string text;
            using (var sw = new StreamReader("./rubrica.txt", Encoding.UTF8))
            {
                text = sw.ReadToEnd();
            }

            string[] utenti = text.Split('\n');

            //Contatto contatto = new Contatto();
            List<Contatto> contatti = new List<Contatto>();
            string[] info;
            foreach (var i in utenti)
            {
                if (i == "")
                {
                    break;
                }
                info = i.Split('~');
                contatti.Add(new Contatto(info[0], info[1], Convert.ToUInt64(info[2]), info[3], info[4], info[5]));
            }

            var cont = 0;
            foreach (var x in contatti)
            {
                var id = Convert.ToString(cont);
                string[] riga = new string[] { id, x.nome, x.cognome, Convert.ToString(x.numero), x.email, x.nascita, x.indirizzo};
                tabella.Rows.Add(riga);
                cont++;
            }
        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            new Aggiuni().Show();
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            new Modifica().Show();
        }
    }
}
