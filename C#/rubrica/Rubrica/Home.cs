using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Rubrica
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("ciao");

                System.IO.File.WriteAllText("test.txt", "ciao sono pippo");
                MessageBox.Show(System.IO.File.ReadAllText("test.txt"));
            } catch(Exception ex)
            {
                MessageBox.Show("Hai rotto tutto!!!");
            }

            
        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            new Aggiuni().Show();
        }

        private void print_Click(object sender, EventArgs e)
        {
            /*   XmlDocument doc = new XmlDocument();
               doc.Load("rubrica.xml");

               XmlNodeList nomi = doc.DocumentElement.SelectNodes("/rubrica/contatto/nome");
               XmlNodeList cognomi = doc.DocumentElement.SelectNodes("/rubrica/contatto/cognome");
               XmlNodeList telefoni = doc.DocumentElement.SelectNodes("/rubrica/contatto/numero");

               string contenuto = "";

               var i = 0;
               foreach (XmlNode node in nomi)
               {
                   contenuto += i + ") " + nomi[i].InnerText + "\t" + cognomi[i].InnerText + "\t" + telefoni[i].InnerText + "\n";
                   i++;
               }

               MessageBox.Show(contenuto);*/

            XmlDocument doc = new XmlDocument();
            doc.Load("rubrica.xml");

            XmlNodeList nomi = doc.DocumentElement.SelectNodes("/rubrica/contatto/nome");
            XmlNodeList cognomi = doc.DocumentElement.SelectNodes("/rubrica/contatto/cognome");
            XmlNodeList telefoni = doc.DocumentElement.SelectNodes("/rubrica/contatto/numero");

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Cognome";
            dataGridView1.Columns[3].Name = "Telefono";

            var cont = 0;
            foreach (XmlNode node in nomi)
            {
                var id = Convert.ToString(cont);
                string[] riga = new string[] { id, nomi[cont].InnerText, cognomi[cont].InnerText, telefoni[cont].InnerText };
                dataGridView1.Rows.Add(riga);
                cont++;
            }
        }
    }
}
