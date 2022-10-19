using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCAD7_Project_MovieDatabase
{
    public partial class Form1 : Form
    {
        MovieRatingRepository movieRatingRepository = new MovieRatingRepository(); // defines an instance of the movie crud interface 

        public Form1()
        {
            InitializeComponent();
            
            // Array for genres with assigned values.
            string[] genres =
            {
                "Action",
                "Animation",
                "Comedy",
                "Crime",
                "Documentary",
                "Drama",
                "Fantasy",
                "Foreign",
                "Horror",
                "Mystery",
                "Romance",
                "Sci-fi",
                "Sports",
                "Thriller",
                "War",
                "Western"
            };
            comboGenre.Items.AddRange(genres); // Array of genres set to the comboBox 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            movieGrid.DataSource = movieRatingRepository.GetAllRecords(); // gets or sets the sql query on to the grid.
        }

        private void ClearRateMovie() // clears all fields in the Rate Movie group box
        {
            txtName.Clear();
            txtTitle.Clear();
            comboGenre.ResetText();
            btn1Star.Checked = false;
            btn2Star.Checked = false;
            btn3Star.Checked = false;
            btn4Star.Checked = false;
            btn5Star.Checked = false;
        }

        private void ClearUpdate() // clears all fields in the update rating group box
        {
            btnUpdate1Star.Checked = false;
            btnUpdate2Star.Checked = false;
            btnUpdate3Star.Checked = false;
            btnUpdate4Star.Checked = false;
            btnUpdate5Star.Checked = false;
        }

        private void Refresh()// refreshes the data in the grid by setting it to null first, then gets all the records
        {
            movieGrid.DataSource = null;
            movieGrid.DataSource = movieRatingRepository.GetAllRecords();
        }

        private void btnRateMovie_Click(object sender, EventArgs e)
        {// if txtName, txtTitle, and comboGenre are filled in , along with one of the star buttons checked,
         // it will add a new  movie rating. if it is not filled in, then a message box will show up.
            if (!string.IsNullOrEmpty(txtName.Text) && 
                !string.IsNullOrEmpty(txtTitle.Text) && 
                !string.IsNullOrEmpty(comboGenre.Text) &&  
                (btn1Star.Checked || btn2Star.Checked || btn3Star.Checked || btn4Star.Checked || btn5Star.Checked))
            {
                MovieRating movieRating = new MovieRating();
                movieRating.Name = txtName.Text;
                movieRating.Title = txtTitle.Text;
                movieRating.Genre = comboGenre.Text;

                if (btn1Star.Checked)
                {
                    movieRating.Rating = 1;
                }
                else if (btn2Star.Checked)
                {
                    movieRating.Rating = 2;
                }
                else if (btn3Star.Checked)
                {
                    movieRating.Rating = 3;
                }
                else if (btn4Star.Checked)
                {
                    movieRating.Rating = 4;
                }
                else
                {
                    movieRating.Rating = 5;
                }

                movieRating.RatingID = movieRatingRepository.GetMaxId() + 1;
                movieRatingRepository.AddMovieRating(movieRating);
                MessageBox.Show("Movie Rating Added");
                ClearRateMovie();
                Refresh();
            }
            else
            {
                MessageBox.Show("Error: Please make sure to fill in all of the fields.");
            }
        }

        private void btnDeleteRating_Click(object sender, EventArgs e)
        {
            int id = (int)movieGrid.CurrentRow.Cells["RatingID"].Value; // defines that int id gets the data from the current row cells"RatingID"
            MovieRating rating = movieRatingRepository.FindRating(id); // 
            movieRatingRepository.DeleteMovieRating(rating);
            MessageBox.Show("Movie Rating Removed");
            Refresh();
        }

        private void btnUpdateRating_Click(object sender, EventArgs e)
        {
            if (btnUpdate1Star.Checked || btnUpdate2Star.Checked || btnUpdate3Star.Checked || btnUpdate4Star.Checked || btnUpdate5Star.Checked)
            {
                int id = (int)movieGrid.CurrentRow.Cells["RatingID"].Value;
                MovieRating rating = movieRatingRepository.FindRating(id);
                int newRating;

                if (btnUpdate1Star.Checked)
                {
                    newRating = 1;
                }
                else if (btnUpdate2Star.Checked)
                {
                    newRating = 2;
                }
                else if (btnUpdate3Star.Checked)
                {
                    newRating = 3;
                }
                else if (btnUpdate4Star.Checked)
                {
                    newRating = 4;
                }
                else
                {
                    newRating = 5;
                }

                movieRatingRepository.UpdateRating(rating, newRating);
                MessageBox.Show("Movie Rating Updated");
                ClearUpdate();
                Refresh();
            }
            else
            {
                MessageBox.Show("Error: Please enter new rating to update to.");
            }
        }

        private void btnRecommendMovie_Click(object sender, EventArgs e)
        {
           
            MoviesEntities entities = new MoviesEntities(); // defines a new entities class instance
            //if (txtNameToRecommend == entities.MovieRatings. )
                var nameToRecommend = txtNameToRecommend.Text; // getting a name from the text box and making sure we dont recommend a movie from their own table.
            var query =
                from t1 in entities.MovieRatings  
                join t2 in entities.MovieRatings
                on new { t1.Title, t1.Rating } equals new { t2.Title, t2.Rating }
                where t1.Name == nameToRecommend && t2.Name != nameToRecommend
                select new
                {
                    Name = t2.Name
                };

            Random random = new Random();
            int randomPersonIndex = random.Next(0, query.Count() - 1);
            string name = query.ToList()[randomPersonIndex].Name.ToString().Trim();

            var person1Query =
                from person1 in entities.MovieRatings
                where person1.Name == name && person1.Rating > 3
                select new
                {
                    Title = person1.Title,
                    Genre = person1.Genre
                };
            var person2Query =
                from person2 in entities.MovieRatings
                where person2.Name == nameToRecommend
                select new
                {
                    Title = person2.Title
                };
            var moviesQuery =
                from person1 in person1Query
                where !(from person2 in person2Query
                        select person2.Title)
                        .Contains(person1.Title)
                select new
                {
                    Title = person1.Title,
                    Genre = person1.Genre
                };

            if (moviesQuery.Count() > 0)
            {
                StringBuilder movies = new StringBuilder();
                for (int i = 0; i < moviesQuery.Count(); i++)
                {
                    string movieTitle = moviesQuery.ToList()[i].Title.ToString().Trim();
                    string movieGenre = moviesQuery.ToList()[i].Genre.ToString().Trim();
                    movies.Append($"{movieTitle} ({movieGenre})");
                    if (i < moviesQuery.Count() - 1)
                    {
                        movies.Append(", ");
                    }
                }
            
                MessageBox.Show($"Since you and {name} have similar tastes in movies, we recommend you watch these movies: {movies}");
            }
            else
            {
                MessageBox.Show($"Sorry, we don't have any recommendations for you at this time. No one has a similar taste in movies.");
            }
        }
    }
}
