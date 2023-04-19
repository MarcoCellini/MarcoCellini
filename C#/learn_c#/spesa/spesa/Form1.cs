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

namespace spesa
{
    public partial class Form1 : Form
    {
        class prodotto
        {
            public string nome { get; set; }
            public int prezzo { get; set; }

            public prodotto(string n, int p)
            {
                nome = n;
                prezzo = p;
            }
        }

        private void new_obj()
        {
            string text;
            using (var sw = new StreamReader("./prodotti.txt", Encoding.UTF8))
            { text = sw.ReadToEnd(); }

            string[] articoli = text.Split('\n');
            List<prodotto> prodottos = new List<prodotto>();
            string[] info;
            foreach (var i in articoli)
            {
                if (i == "")
                    break;
                info = i.Split(';');
                prodottos.Add(new prodotto(info[0], Convert.ToInt16(info[1])));
            }

            foreach (var x in prodottos)
            {
                string[] line = new string[] { "false", x.nome, x.prezzo.ToString() + "€", "0" };
                data.Rows.Add(line);
            }
        }

        public Form1()
        {
            InitializeComponent();
            new_obj();
        }

        private void invio_Click(object sender, EventArgs e)
        {
            double tot = 0;
            foreach (DataGridViewRow check in data.Rows)
            {
                var cella = check.Cells[0] as DataGridViewCheckBoxCell;
                if (cella.Value as bool? == true)
                    tot += Convert.ToDouble(check.Cells[2].Value.ToString().Split('€')[0]) * Convert.ToDouble(check.Cells[3].Value.ToString());
            }
            risultato.Text = tot.ToString() + " €";
        }

        private void erase_Click(object sender, EventArgs e)
        {
            data.Rows.Clear();
            new_obj();
            risultato.Text = "0 €";
        }
    }
}
