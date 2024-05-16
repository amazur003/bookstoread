using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstoread
{
    public partial class AddBookForm : Form
    {
        public string BookTitle { get; private set; }
        public string BookAuthor { get; private set; }
        public string BookGenre { get; private set; }
        public string BookPublicationDate { get; private set; }
        public AddBookForm()
        {
            InitializeComponent();
            this.textBox4.KeyPress += new KeyPressEventHandler(textBox4_KeyPress);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //textbox tytul
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) //textbox autor
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e) //textbox gatunek
        {

        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e) //textbox rokwydania
        {

        }

        private void dodajks_Click(object sender, EventArgs e) //przycisk dodaj
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Pola 'Tytuł' i 'Autor' są obowiązkowe.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BookTitle = textBox1.Text;
            BookAuthor = textBox5.Text;
            BookGenre = textBox6.Text;
            BookPublicationDate = textBox4.Text;

            this.DialogResult = DialogResult.OK; 
            this.Close(); 
        }
    }
}
