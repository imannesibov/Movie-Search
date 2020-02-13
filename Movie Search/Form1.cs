using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace Movie_Search
{
    public partial class MovieSearch : Form
    {
        List<Movie> movies = null;
        int count = 0;
        bool iSearched = false;
        public MovieSearch()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Go_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(searchbox.Text) && !searchbox.Text.Contains("Search Movie"))
            {
                count = 0;

                HttpClient http = new HttpClient();

                try
                {
                    var response = http.GetAsync($"http://www.omdbapi.com/?apikey=fc7d48c5&plot=full&s={searchbox.Text}").Result;
                    var str = response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<Result>(str);

                    try
                    {

                        movies = new List<Movie>();

                        foreach (var item in data.Search)
                        {
                            var respons = http.GetAsync($"http://www.omdbapi.com/?apikey=fc7d48c5&plot=full&t={item.Title}").Result;
                            var str2 = respons.Content.ReadAsStringAsync().Result;
                            var movie = JsonConvert.DeserializeObject<Movie>(str2);
                            movies.Add(movie);
                            posterimg.ImageLocation = movies[count].Poster;

                            try
                            {
                                titletext.Text = movies[count].Title;
                                genretext.Text = movies[count].Genre;
                                year.Text = movies[count].Year;
                                runtime.Text = movies[count].Runtime;
                            }
                            catch (ArgumentOutOfRangeException)
                            {


                            }
                            iSearched = true;
                        }
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("This Movie Doesn't Exist");
                    }
                }
                catch (System.AggregateException)
                {

                    MessageBox.Show("No Internet Connection");
                }


            }
            else
            {
                MessageBox.Show("Firstly Enter Movie Name");
            }

        }

        private void SearchBox_OnValueChanged(object sender, EventArgs e)
        {
            if (searchbox.Text.Contains("Search Movie"))
            {
                searchbox.ForeColor = Color.White;
                searchbox.Text = "";
            }

        }







        private void prev_Click(object sender, EventArgs e)
        {
            if (0 <= count - 1)
            {
                count--;
                titletext.Text = movies[count].Title;
                genretext.Text = movies[count].Genre;
                year.Text = movies[count].Year;
                runtime.Text = movies[count].Runtime;
                posterimg.ImageLocation = movies[count].Poster;

            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (movies.Count - 1 >= count + 1)
            {
                count++;
                titletext.Text = movies[count].Title;
                genretext.Text = movies[count].Genre;
                year.Text = movies[count].Year;
                runtime.Text = movies[count].Runtime;
                posterimg.ImageLocation = movies[count].Poster;
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();

            of.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";

            if (of.ShowDialog() == DialogResult.OK)
            {
                var str = File.ReadAllText($"{of.FileName}");
                var movie = JsonConvert.DeserializeObject<List<Movie>>(str);


                movies = new List<Movie>();
                movies.AddRange(movie);

                titletext.Text = movies[0].Title;
                genretext.Text = movies[0].Genre;
                year.Text = movies[0].Year;
                runtime.Text = movies[0].Runtime;
                posterimg.ImageLocation = movies[0].Poster;
            }
            else
            {
                MessageBox.Show("Firstly Search Movie Name");
            }

        }
        private void savebtn_Click(object sender, EventArgs e)
        {

            if (iSearched)
            {
                SaveFileDialog sf = new SaveFileDialog();

                sf.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";

                if (sf.ShowDialog() == DialogResult.OK)
                {
                    var json = JsonConvert.SerializeObject(movies, Formatting.Indented);
                    File.WriteAllText($"{sf.FileName}.json", json);
                }
            }
            else
            {
                MessageBox.Show("Firstly Search Movie Name");
            }
        }



    }
}