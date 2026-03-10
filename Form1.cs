using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace The_Cat_API_in_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        static readonly HttpClient client = new HttpClient();

        private async void CatRequestButton_Click(object sender, EventArgs e)
        {
            string response = await client.GetStringAsync("https://api.thecatapi.com/v1/images/search"); // Step 1: Call API and get a link to a random image of a cat and store it in a string called "Response".
            using JsonDocument doc = JsonDocument.Parse(response); // Step 2: Parse the JSON Response.
            string CatURL = doc.RootElement[0].GetProperty("url").GetString(); // Step 3: Get a link from the now parsed JSON response and store it in a string called "CatURL".
            Stream stream = await client.GetStreamAsync(CatURL); // Step 4: Get the image from the link and store it in a stream.
            Image CatImage = Image.FromStream(stream); // Step 5: Store the image from the stream in a image variable (Not really needed but i like storing it in a variable incase i wanna do something else with ths code in the future).
            PictureBox.Image = CatImage; // Step 6: Display the now downloaded image of a cat in the piture box!
        }
    }
}
