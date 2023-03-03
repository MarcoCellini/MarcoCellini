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
using System.Xml.Linq;
using System.Xml;
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

                var result_nome = Regex.IsMatch(nome, @"^[a-z -']+$");
                var result_cognome = Regex.IsMatch(nome, @"^[a-z -']+$");
                var result_mail = Regex.IsMatch(mail, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                Regex num_regex = new Regex("^\\s*(?:\\+?(\\d{1,3}))?[-. (]*(\\d{3})[-. )]*(\\d{3})[-. ]*(\\d{4})(?: *x(\\d+))?\\s*$");

                if (!result_nome)
                {
                    MessageBox.Show("ERRORE nome non valido");
                    return;
                } else if (!result_cognome)
                {
                    MessageBox.Show("ERRORE cognome non valido");
                    return;
                }
                else if (!result_mail)
                {
                    MessageBox.Show("ERRORE email non valida");
                    return;
                } else if (!num_regex.IsMatch(num))
                {
                    MessageBox.Show("ERRORE telefono invalido");
                    return;
                } else
                {
                    contatto.Numero = Convert.ToUInt64(num);
                }


                if (!File.Exists("rubrica.txt"))
                {
                    using (StreamWriter sw = File.CreateText("./rubrica.txt"))
                    {
                        sw.WriteLine(nome + "_" + cognome + "_" + num + "_" + mail);
                    }
                }
                else 
                {
                    using (StreamWriter sw = File.AppendText("./rubrica.txt"))
                    {
                        sw.WriteLine(nome + "_" + cognome + "_" + num + "_" + mail);
                    }
                }

                MessageBox.Show("Utente salvato correttamente");
                this.Close();
            } catch
            {
                MessageBox.Show("Errore 104");
            }   
        }
    }
}