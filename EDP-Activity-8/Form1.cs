using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EDP_Activity_8
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiUrl = "http://localhost/library_api";

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            await FetchBooks();
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            await AddBook();
        }

        private async Task FetchBooks()
        {
            try
            {
                var response = await client.GetStringAsync($"{apiUrl}/books");
                var books = JsonConvert.DeserializeObject<Book[]>(response);
                dgvBooks.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching books: {ex.Message}");
            }
        }

        private async Task AddBook()
        {
            var book = new Book
            {
                Title = txtTitle.Text,
                ISBN = txtISBN.Text,
                PublisherID = int.Parse(txtPublisherID.Text),
                PublicationYear = int.Parse(txtPublicationYear.Text),
                CategoryID = int.Parse(txtCategoryID.Text)
            };

            var json = JsonConvert.SerializeObject(book);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync($"{apiUrl}/books", content);
                response.EnsureSuccessStatusCode();
                MessageBox.Show("Book added successfully!");
                await FetchBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}");
            }
        }
    }

    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int PublisherID { get; set; }
        public int PublicationYear { get; set; }
        public int CategoryID { get; set; }
    }
}
