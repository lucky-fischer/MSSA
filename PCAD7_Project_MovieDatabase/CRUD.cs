using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAD7_Project_MovieDatabase
{
    interface ICRUD
    {
        int GetMaxId(); //gets the current highest Rating ID
        void AddMovieRating(MovieRating rating); // Create
        ICollection<MovieRating> GetAllRecords(); // Read
        void UpdateRating(MovieRating movieRating, int newRating); // Update
        void DeleteMovieRating(MovieRating rating); // Delete
       
    }

    class MovieRatingRepository : ICRUD
    {
        MoviesEntities entities = new MoviesEntities(); // creating an instance of the DB context.

        public void AddMovieRating(MovieRating rating) // adds movie rating and saves changes.
        {
            entities.MovieRatings.Add(rating);
            entities.SaveChanges();
        }

        public void DeleteMovieRating(MovieRating rating) // deletes movie rating and saves changes.
        {
            entities.MovieRatings.Remove(rating);
            entities.SaveChanges();
        }

        public MovieRating FindRating(int id) //  finds the movie rating by ID number.
        {
            return entities.MovieRatings.Find(id);
        }

        public int GetMaxId()
        {
            return entities.MovieRatings.Max(p => p.RatingID);
        }

        public ICollection<MovieRating> GetAllRecords() // gets the list of movie ratings from the DB
        {
            return entities.MovieRatings.ToList();
        }
       
        public void UpdateRating(MovieRating movieRating, int newRating) // updates movie rating
        {
            movieRating.Rating = newRating;
        }
    }
}
