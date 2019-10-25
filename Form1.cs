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

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hobbilista.Items.Add("Úszás");
            hobbilista.Items.Add("Futás");
            hobbilista.Items.Add("Olvasás");
            string no = "nő";
            string ferfi = "férfi";
            string nem=" ";
            string hobbi = " ";
            


            saveFileDialog1.FileOk += (senderFile, eFile) =>
            {
                try
                {
                    string fileName = saveFileDialog1.FileName;
                    StreamWriter writer = new StreamWriter(fileName);
                    if (radioFerfi.Checked)
                    {
                        writer.WriteLine(textNev.Text + ", " + textSzul.Text+"," +ferfi+
                            ", kedvenc hobbi: "+ hobbilista.SelectedItem);
                    }
                    else if(radioNo.Checked)
                    {
                        writer.WriteLine(textNev.Text + ", " + textSzul.Text + "," + no+
                            ", kedvenc hobbi, "+hobbilista.SelectedItem);
                    }
                    writer.Close();
                }
                catch (IOException)
                {

                    MessageBox.Show("Hiba! Nem sikerült a kiírás");
                }
            };
            openFileDialog1.FileOk += (senderFile, eFile) =>
            {
                try
                {
                    string fileName = openFileDialog1.FileName;
                    StreamReader reader = new StreamReader(fileName);
                    string sor = reader.ReadLine();
                    string[] reszek = sor.Split(',');
                    textNev.Text = reszek[0];
                    textSzul.Text = reszek[1];
                    nem = reszek[2];
                    if (nem.Contains(no))
                    {
                        radioNo.Checked=true;
                    }
                    else
                    {
                        radioFerfi.Checked = true;
                    }
                    //hobbi = reszek[3];
                    //hobbilista.SelectedItem = hobbi;
                    reader.Close();

                }
                catch (IOException)
                {

                    MessageBox.Show("Hiba! Nem sikerült a betöltés");
                }
            };
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonMentes_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonHozzaad_Click(object sender, EventArgs e)
        {
            hobbilista.Items.Add(textHobbi.Text);

        }

        private void ButtonBetolt_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
