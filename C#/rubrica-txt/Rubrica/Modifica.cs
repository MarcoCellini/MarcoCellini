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
    public partial class Modifica : Form
    {
        public Modifica()
        {
            InitializeComponent();
        }

        private void indietro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cerca_Click(object sender, EventArgs e)
        {
            name.Text = "pippo";
        }
    }
}
