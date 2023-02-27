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

        private void Aggiuni_Load(object sender, EventArgs e)
        {

        }

        private class Contatto
        {
            public string Nome;
            public string Cognome;
            public DateTime Nascita;
            public ulong Numero;


            public XmlNode genera_contatto(XmlDocument doc)
            {
                XmlNode contatto = doc.CreateElement("contatto");   // <contatto>
                XmlNode nome = doc.CreateElement("nome");   //<nome>
                XmlNode cognome = doc.CreateElement("cognome"); // <cognome>
                XmlNode nascita = doc.CreateElement("nascita"); // <nascita>
                XmlNode numero = doc.CreateElement("numero");   // <numero>
                nome.InnerText = Nome;  // Pippo
                cognome.InnerText = Cognome;    // Pluto
                nascita.InnerText = Nascita.ToString();
                numero.InnerText = Numero.ToString();

                contatto.AppendChild(nome); // aggingo nome a contatto
                contatto.AppendChild(cognome);
                contatto.AppendChild(nascita);
                contatto.AppendChild(numero);

                return contatto;

            }

        }

        private void invio_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);   // Crea XML
                doc.AppendChild(docNode);


                Contatto contatto = new Contatto(); // Crea classe contatto

                string nome = name.Text;    // Riempiamo gli attrbuti
                string cognome = surname.Text;
                string num = phone.Text;

                Regex num_regex = new Regex("^\\s*(?:\\+?(\\d{1,3}))?[-. (]*(\\d{3})[-. )]*(\\d{3})[-. ]*(\\d{4})(?: *x(\\d+))?\\s*$");

                if (num_regex.IsMatch(num))
                {
                    contatto.Numero = Convert.ToUInt64(num);
                } else
                {
                    MessageBox.Show("ERRORE numero invalido");
                    return;
                }

                if (nome.Length > 0 && cognome.Length > 0)
                {
                    contatto.Nome = nome;
                    contatto.Cognome = cognome;
                }
                else
                {
                    MessageBox.Show("ERRORE utente non valido");
                    return;
                }

                if (!File.Exists("rubrica.xml"))
                {
                    XmlNode productsNode = doc.CreateElement("rubrica");    // Inizializzo la rubrica
                    productsNode.AppendChild(contatto.genera_contatto(doc));    // Aggiunge il contatto alla rubrica
                    doc.AppendChild(productsNode);
                    doc.Save("rubrica.xml");
                }
                else 
                {
                    doc.Load("rubrica.xml");    // Carica la rubrica
                    XmlNode node = doc.SelectSingleNode("/rubrica");    // Prende i dati da rubrica
                    node.AppendChild(contatto.genera_contatto(doc));    // Aggiunge un nuovo contatto
                    doc.Save("rubrica.xml");
                    // File.Copy("rubrica_tmp.xml", "rubrica.xml");  // Scriviamo la nuova rubrica
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