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
        public Home()
        {
            InitializeComponent();
        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            new Aggiuni().Show();
        }

        private void visualizza_Click(object sender, EventArgs e)
        {
            string text;
            using (var sw = new StreamReader("./rubrica.txt", Encoding.ASCII))
            {
                text = sw.ReadToEnd();
            }
            MessageBox.Show(text);
        }
    }
}
