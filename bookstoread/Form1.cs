using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstoread
{
    public partial class Form1 : Form
    {

        private List<string> interestingBooks = new List<string>
        {
          "Tytuł: Władca Pierścieni\nAutor: J.R.R. Tolkien\nGatunek: Fantasy\nRok wydania: 1954",
          "Tytuł: 1984\nAutor: George Orwell\nGatunek: Fikcja polityczna\nRok wydania: 1949",
          "Tytuł: Mały Książę\nAutor: Antoine de Saint-Exupéry\nGatunek: Literatura filozoficzna\nRok wydania: 1943",
          "Tytuł: Gra Endera\nAutor: Orson Scott Card\nGatunek: Science Fiction\nRok wydania: 1985",
          "Tytuł: Zabić drozda\nAutor: Harper Lee\nGatunek: Literatura amerykańska\nRok wydania: 1960",
          "Tytuł: Sto lat samotności\nAutor: Gabriel García Márquez\nGatunek: Realizm magiczny\nRok wydania: 1967",
          "Tytuł: Wielki Gatsby\nAutor: F. Scott Fitzgerald\nGatunek: Literatura amerykańska\nRok wydania: 1925",
          "Tytuł: Harry Potter i Kamień Filozoficzny\nAutor: J.K. Rowling\nGatunek: Fantasy\nRok wydania: 1997",
          "Tytuł: Duma i uprzedzenie\nAutor: Jane Austen\nGatunek: Powieść\nRok wydania: 1813",
          "Tytuł: Hobbit, czyli tam i z powrotem\nAutor: J.R.R. Tolkien\nGatunek: Fantasy\nRok wydania: 1937",
          "Tytuł: Frankenstein\nAutor: Mary Shelley\nGatunek: Gotycka powieść\nRok wydania: 1818",
          "Tytuł: Dracula\nAutor: Bram Stoker\nGatunek: Horror\nRok wydania: 1897",
          "Tytuł: Atlas Zbuntowany\nAutor: Ayn Rand\nGatunek: Filozoficzna fikcja\nRok wydania: 1957",
          "Tytuł: Fahrenheit 451\nAutor: Ray Bradbury\nGatunek: Dystopia\nRok wydania: 1953",
          "Tytuł: Mistrz i Małgorzata\nAutor: Michaił Bułhakow\nGatunek: Fikcja\nRok wydania: 1967",
          "Tytuł: Niewidzialny człowiek\nAutor: H.G. Wells\nGatunek: Naukowa fikcja\nRok wydania: 1897",
          "Tytuł: Imię róży\nAutor: Umberto Eco\nGatunek: Powieść historyczna\nRok wydania: 1980",
          "Tytuł: Wyspa skarbów\nAutor: Robert Louis Stevenson\nGatunek: Przygodowa\nRok wydania: 1883",
          "Tytuł: Dziennik Anny Frank\nAutor: Anna Frank\nGatunek: Pamiętnik\nRok wydania: 1947",
          "Tytuł: W pustyni i w puszczy\nAutor: Henryk Sienkiewicz\nGatunek: Przygodowa\nRok wydania: 1911",
          "Tytuł: Solaris\nAutor: Stanisław Lem\nGatunek: Science Fiction\nRok wydania: 1961",
          "Tytuł: Lalka\nAutor: Bolesław Prus\nGatunek: Powieść społeczno-obyczajowa\nRok wydania: 1890",
          "Tytuł: Czarodziejska góra\nAutor: Thomas Mann\nGatunek: Powieść filozoficzna\nRok wydania: 1924",
          "Tytuł: Opowieść podręcznej\nAutor: Margaret Atwood\nGatunek: Dystopia\nRok wydania: 1985",
          "Tytuł: Kod Leonarda da Vinci\nAutor: Dan Brown\nGatunek: Thriller\nRok wydania: 2003",
"Tytuł: Moby Dick\nAutor: Herman Melville\nGatunek: Przygodowa, Morze\nRok wydania: 1851",
"Tytuł: Wojna i pokój\nAutor: Lew Tołstoj\nGatunek: Powieść historyczna\nRok wydania: 1869",
"Tytuł: Wielkie nadzieje\nAutor: Charles Dickens\nGatunek: Literatura klasyczna\nRok wydania: 1861",
"Tytuł: Ulisses\nAutor: James Joyce\nGatunek: Modernizm\nRok wydania: 1922",
"Tytuł: Proces\nAutor: Franz Kafka\nGatunek: Fikcja prawna\nRok wydania: 1925",
"Tytuł: Lolita\nAutor: Vladimir Nabokov\nGatunek: Fikcja\nRok wydania: 1955",
"Tytuł: Sto lat samotności\nAutor: Gabriel García Márquez\nGatunek: Realizm magiczny\nRok wydania: 1967",
"Tytuł: Zbrodnia i kara\nAutor: Fiodor Dostojewski\nGatunek: Psychologiczna\nRok wydania: 1866",
"Tytuł: Madame Bovary\nAutor: Gustave Flaubert\nGatunek: Realistyczna\nRok wydania: 1856",
"Tytuł: Wuthering Heights\nAutor: Emily Brontë\nGatunek: Gotycka powieść miłosna\nRok wydania: 1847",
"Tytuł: Don Kichot\nAutor: Miguel de Cervantes\nGatunek: Powieść przygodowa\nRok wydania: 1605",
"Tytuł: Podróż do wnętrza Ziemi\nAutor: Jules Verne\nGatunek: Przygodowa, Science Fiction\nRok wydania: 1864",
"Tytuł: Przygody Sherlocka Holmesa\nAutor: Arthur Conan Doyle\nGatunek: Kryminał, Detektywistyczna\nRok wydania: 1892",
"Tytuł: Alicja w Krainie Czarów\nAutor: Lewis Carroll\nGatunek: Fantasy\nRok wydania: 1865",
"Tytuł: Dżuma\nAutor: Albert Camus\nGatunek: Filozoficzna\nRok wydania: 1947",
"Tytuł: Opowieści z Narnii\nAutor: C.S. Lewis\nGatunek: Fantasy\nRok wydania: 1950-1956",
"Tytuł: Szczur w koronie\nAutor: Andrzej Pilipiuk\nGatunek: Fantasy, Przygodowa\nRok wydania: 2002",
"Tytuł: Winnetou\nAutor: Karl May\nGatunek: Przygodowa, Western\nRok wydania: 1893",
"Tytuł: Pięć osób, które spotkamy w niebie\nAutor: Mitch Albom\nGatunek: Fikcja\nRok wydania: 2003",
"Tytuł: Kroniki marsjańskie\nAutor: Ray Bradbury\nGatunek: Science Fiction\nRok wydania: 1950",
"Tytuł: Gdzie śpiewają raki\nAutor: Delia Owens\nGatunek: Fikcja literacka\nRok wydania: 2018",
"Tytuł: Złodziejka książek\nAutor: Markus Zusak\nGatunek: Fikcja historyczna\nRok wydania: 2005",
"Tytuł: Bieguni\nAutor: Olga Tokarczuk\nGatunek: Fikcja literacka\nRok wydania: 2007",
"Tytuł: Małe życie\nAutor: Hanya Yanagihara\nGatunek: Fikcja literacka\nRok wydania: 2015",
"Tytuł: Chłopi\nAutor: Władysław Reymont\nGatunek: Powieść społeczno-obyczajowa\nRok wydania: 1904"


        };

        private List<string> quotesList = new List<string>
        {
"Cytat: 'Lepiej zaliczać się do niektórych, niż do wszystkich.'\nKsiążka: Krew elfów\nAutor książki: Andrzej Sapkowski",
"Cytat: 'Życie jest jak pudełko czekoladek - nigdy nie wiesz, co ci się trafi.'\nKsiążka: Forrest Gump\nAutor książki: Winston Groom",
"Cytat: 'Kiedy łamiesz zasady, łam je mocno i na dobre.'\nKsiążka: Trzy wiedźmy\nAutor książki: Terry Pratchett",
"Cytat: 'Jeżeli zabałaganione biurko jest oznaką zabałaganionego umysłu, oznaką czego jest puste biurko?'\nAutor: Albert Einstein",
"Cytat: 'Zwierzęta w ogrodzie patrzyły to na świnię, to na człowieka, potem znów na świnię i na człowieka, ale nikt już nie mógł się połapać, kto jest kim.'\nKsiążka: Folwark zwierzęcy\nAutor książki: George Orwell",
"Cytat: 'Tylko dwie rzeczy są nieskończone: wszechświat oraz ludzka głupota, choć nie jestem pewien co do tej pierwszej.'\nAutor: Albert Einstein",
"Cytat: 'Ludzie nie wiedzą czego chcą, dopóki się im tego nie pokaże.\nAutor: Steve Jobs",
"Cytat: 'Kto szuka, ten najczęściej coś znajduje, niestety czasem zgoła nie to, czego mu potrzeba.'\nKsiążka: Hobbit, czyli tam i z powrotem\nAutor książki: J.R.R. Tolkien",


        };

        public Form1()
        {
            InitializeComponent();
            LoadBooks();
            InitializeDataGridView();
            textBox1.ReadOnly = true;
            textBox1.Enabled = false;
        }

        

        private void button1_Click(object sender, EventArgs e) // DODAJ
        {
            AddBookForm addBookForm = new AddBookForm();

            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(addBookForm.BookTitle, addBookForm.BookAuthor, addBookForm.BookGenre, addBookForm.BookPublicationDate);
                SaveBooks();
                dataGridView1.ClearSelection();
            }
        }

        private void button2_Click(object sender, EventArgs e) // USUN
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            SaveBooks();
        }

        private void button3_Click(object sender, EventArgs e) // LOSOWA KSIAZKA
        {
            Random random = new Random();
            int index = random.Next(interestingBooks.Count);
            string selectedBook = interestingBooks[index];
            string displayText = selectedBook.Replace("\n", Environment.NewLine);
            textBox1.Text = displayText;
        }

        private void button4_Click(object sender, EventArgs e) // CIEKAWE CYTATY
        {
            Random random = new Random();
            int index = random.Next(quotesList.Count);
            string selectedQuote = quotesList[index];
            string displayText = selectedQuote.Replace("\n", Environment.NewLine);
            textBox1.Text = displayText;
        }

        private void button5_Click(object sender, EventArgs e) // CIEKAWE KSIAZKI
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.taniaksiazka.pl/t/100-ksiazek-ktore-trzeba-przeczytac");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie można otworzyć strony internetowej. Szczegóły błędu: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // textbox losowa ksiazka
        {
            
        }
        private void InitializeDataGridView()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ClearSelection();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bool isSelected = dataGridView1.Rows[e.RowIndex].Selected;
                dataGridView1.ClearSelection();
                if (!isSelected)
                {
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void LoadBooks()
        {
            string filePath = Path.Combine(Application.StartupPath, "booksList.txt");
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length == 4) 
                    {
                        dataGridView1.Rows.Add(parts);
                    }
                }
            }
        }

        private void SaveBooks()
        {
            string filePath = Path.Combine(Application.StartupPath, "booksList.txt");
            using (var sw = new StreamWriter(filePath))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var title = row.Cells[0].Value?.ToString() ?? "";
                        var author = row.Cells[1].Value?.ToString() ?? "";
                        var genre = row.Cells[2].Value?.ToString() ?? "";
                        var publicationDate = row.Cells[3].Value?.ToString() ?? "";
                        var line = $"{title};{author};{genre};{publicationDate}";
                        sw.WriteLine(line);
                    }
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SaveBooks(); 
        }

 
    }
}
