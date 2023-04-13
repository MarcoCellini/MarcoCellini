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

namespace prenotazioni
{
    public partial class Form1 : Form
    {
        public class info
        {
            public string data { get; set; }
            public string ora { get; set; }
            public info(string d, string o)
            {
                data = d;
                ora = o;
            }
        }

        string filePath = null;

        public Form1()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            data.MinDate = today;
            var day = (int)today.DayOfWeek;
            data.MaxDate = today.AddDays((7 - day - 1));
        }

        private void get_path()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "./";
                openFileDialog.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    filePath = openFileDialog.FileName;
                openFileDialog.Dispose();
            }
        }

        private List<info> take_hours()
        {
            string text;
            using (var sw = new StreamReader(filePath, Encoding.UTF8))
            {
                text = sw.ReadToEnd();
            }
            string[] prenotazioni = text.Split('\n'), line;
            List<info> infos = new List<info>();
            foreach (var x in prenotazioni)
            {
                if (x == "")
                    break;
                line = x.Split(';');
                infos.Add(new info((line[2].Split(' '))[0], (line[2].Split(' '))[1]));
            }

            return infos;
        }

        private bool control(string giorno)
        {
            List<info> infos = take_hours();
            if (filePath != null)
            {
                foreach (var x in infos)
                    if ((x.data + " " + x.ora) == giorno)
                        return false;
            } else
                MessageBox.Show("error");
            return true;
        }

        private void add_file(string text)
        {
            MessageBox.Show(filePath);
            if (filePath == null)
                using (StreamWriter sw = File.CreateText("./prenotazioni.txt"))
                {
                    sw.WriteLine(text);
                }
            else
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine(text);
                }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            get_path();
            var ora = data.Value.Hour;
            var min = data.Value.Minute;
            if (min > 30)
            {
                ora++;
                min = 00;
            } else if (min > 15)
                min = 30;
            else
                min = 00;

            if (ora < 8 || (ora == 8 && min == 0) || ora > 19 || (ora == 19 && min == 30))
                MessageBox.Show("barbiere chiuso");
            else
            {
                if (control(data.Value.Day.ToString() + "/" + data.Value.Month.ToString() + " " + ora + ":" + min))
                {
                    add_file(cognome.Text + ';' + telefono.Text + ';' + (data.Value.Day.ToString() + "/" + data.Value.Month.ToString() + " " + ora + ":" + min));
                    return;
                }
            }
        }
    }
}
