using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace Rubrica
{
    public partial class Aggiuni : Form
    {
        public Aggiuni()
        {
            InitializeComponent();
        }

        private class Contatto
        {
            public string Nome;
            public string Cognome;
            public ulong Numero;
            public string Email;
            public string Nascita;
            public string Indirizzo;
        }

        private void invio_Click(object sender, EventArgs e)
        {
            try
            {
                Contatto contatto = new Contatto(); // Crea classe contatto

                string nome = name.Text;    // Riempiamo gli attrbuti
                string cognome = surname.Text;
                string num = phone.Text;
                string mail = email.Text;
                string nato = nascita.Text;
                string casa = indirizzo.Text;

                var result_nome = Regex.IsMatch(nome, "^[A-Za-zÀ-ÖØ-öø-ÿ ']+$");
                var result_cognome = Regex.IsMatch(nome, @"^[a-z -']+$");
                var result_mail = Regex.IsMatch(mail, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                var result_casa = Regex.IsMatch(casa, "^(\\d{1,}) [a-zA-Z0-9\\s]+(\\,)? [a-zA-Z]+(\\,)? [A-Z]{2} [0-9]{5,6}$");
                Regex num_regex = new Regex("^\\s*(?:\\+?(\\d{1,3}))?[-. (]*(\\d{3})[-. )]*(\\d{3})[-. ]*(\\d{4})(?: *x(\\d+))?\\s*$");

                if (!result_nome || nome == "")
                {
                    MessageBox.Show("ERRORE nome non valido");
                    return;
                }
                else if (!result_cognome || cognome == "")
                {
                    MessageBox.Show("ERRORE cognome non valido");
                    return;
                }else if (!num_regex.IsMatch(num))
                {
                    MessageBox.Show("ERRORE telefono invalido");
                    return;
                }
                else if (!result_mail)
                {
                    MessageBox.Show("ERRORE email non valida");
                    return;
                }
                
                else if (!result_casa)
                {
                    MessageBox.Show("ERRORE indirizzo invalido\nDeve essere così:\nnumero civico via, città, provincia CAP");
                    return;
                }
                else
                {
                    contatto.Nome = nome;
                    contatto.Cognome = cognome;
                    contatto.Numero = Convert.ToUInt64(num);
                    contatto.Email = mail;
                    contatto.Nascita = nato;
                    contatto.Indirizzo = casa;
                }

                if (!File.Exists("rubrica.txt"))
                {
                    using (StreamWriter sw = File.CreateText("./rubrica.txt"))
                    {
                        sw.WriteLine(contatto.Nome + "~" + contatto.Cognome + "~" + contatto.Numero + "~" + contatto.Email + "~" + contatto.Nascita + "~" + contatto.Indirizzo);
                    }
                }
                else 
                {
                    using (StreamWriter sw = File.AppendText("./rubrica.txt"))
                    {
                        sw.WriteLine(contatto.Nome + "~" + contatto.Cognome + "~" + contatto.Numero + "~" + contatto.Email + "~" + contatto.Nascita + "~" + contatto.Indirizzo);
                    }
                }

                MessageBox.Show("Utente salvato correttamente");
                this.Close();
            } catch
            {
                MessageBox.Show("Errore 104");
            }   
        }

        private void indietro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}