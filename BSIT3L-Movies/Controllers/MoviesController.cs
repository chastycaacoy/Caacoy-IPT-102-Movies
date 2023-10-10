using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
            new MovieViewModel { Id = 1, Name = "Tune In For Love", Rating = "5", ReleaseYear = 2019, Genre = "Romance" },
            new MovieViewModel { Id = 2, Name = "The Beauty Inside", Rating = "4", ReleaseYear = 2015, Genre = "Romance" },
            new MovieViewModel { Id = 3, Name = "Be With You", Rating = "5", ReleaseYear = 2018, Genre = "Romance/Melodrama" },
            new MovieViewModel { Id = 4, Name = "On Your Wedding Day", Rating = "4", ReleaseYear = 2018, Genre = "Romance/Melodrama" },
            new MovieViewModel { Id = 5, Name = "Love and Leashes", Rating = "5", ReleaseYear = 2022, Genre = "Rom-Com" },
            new MovieViewModel { Id = 6, Name = "20th Century Girl", Rating = "5", ReleaseYear = 2022, Genre = "Melodrama" },
            new MovieViewModel { Id = 7, Name = "Sweet & Sour", Rating = "4", ReleaseYear = 2021, Genre = "Rom-Com" },
            new MovieViewModel { Id = 8, Name = "Kill Boksoon", Rating = "5", ReleaseYear = 2023, Genre = "Action" },
            new MovieViewModel { Id = 9, Name = "Unlocked", Rating = "5", ReleaseYear = 2023, Genre = "Thriller" },
            new MovieViewModel { Id = 10, Name = "Dream", Rating = "4", ReleaseYear = 2023, Genre = "Drama" },
            new MovieViewModel { Id = 11, Name = "Jung E", Rating = "3", ReleaseYear = 2023, Genre = "Sci-Fi" },
            new MovieViewModel { Id = 12, Name = "Parasite", Rating = "3", ReleaseYear = 2019, Genre = "Thriller" },
            new MovieViewModel { Id = 13, Name = "Seoul Vibe", Rating = "4", ReleaseYear = 2022, Genre = "Action" },
            new MovieViewModel { Id = 14, Name = "The Pirates: The Last Royal Treasure", Rating = "5", ReleaseYear = 2022, Genre = "Adventure" },
            new MovieViewModel { Id = 15, Name = "Space Sweepers", Rating = "5", ReleaseYear = 2021, Genre = "Sci-Fi" },
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

