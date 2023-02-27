using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubrica
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            string[] row = { "Nome", "Cognome", "Numero" };
            foreach (string s in row)
            {
                var ListViewItem = new ListViewItem(s);
                listView1.Items.Add(ListViewItem);
            }
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
    }
}
