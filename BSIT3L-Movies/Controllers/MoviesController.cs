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
            new MovieViewModel { 
                Id = 1, 
                Name = "Tune In For Love", 
                Rating = "5", 
                ReleaseYear = 2019, 
                Genre = "Romance", 
                Description = "During the 1990s, hardworking Mi Soo and optimistic Hyun Woo meet at a bakery and fall in love while exchanging stories on a radio station, but while their paths keep crossing, the timing never seems to work out.", 
                PosterImageUrl = "/Content/Images/TuneInForLovePoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=O2x8gaL5Omw",},
                
            new MovieViewModel { 
                Id = 2, 
                Name = "The Beauty Inside", 
                Rating = "4", 
                ReleaseYear = 2015, 
                Genre = "Romance", 
                Description ="Woo-jin, a furniture designer who wakes up in a different body every day, falls for Yi-soo, a woman he meets through his work.", 
                PosterImageUrl = "/Content/Images/TheBeautyInsidePoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=zQvPJjDRMcY",  },
            new MovieViewModel { 
                Id = 3, 
                Name = "Be With You", 
                Rating = "5", 
                ReleaseYear = 2018, 
                Genre = "Romance/Melodrama", 
                Description ="A woman dies, leaving her husband and young son, but during the rain season, she comes back to life and has no memories. The three get together and are happy again, but she has to go back when the rain season ends.", 
                PosterImageUrl = "/Content/Images/BeWithYouPoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=_6tJmGxGaK4",  },
            new MovieViewModel { 
                Id = 4, 
                Name = "On Your Wedding Day", 
                Rating = "4", 
                ReleaseYear = 2018, 
                Genre = "Romance/Melodrama", 
                Description ="A man receives a wedding invitation from his first love, whom he met in high school.", 
                PosterImageUrl = "/Content/Images/OnYourWeddingDayPoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=QJEe_JEhvw8",  },
            new MovieViewModel { 
                Id = 5, 
                Name = "Love and Leashes", 
                Rating = "5", 
                ReleaseYear = 2022, 
                Genre = "Rom-Com", 
                Description ="One day, his co-worker Ji Woo, mistakenly opens a package of Ji Hoo's, accidentally revealing for all the world to see one of his sexual fetishes.", 
                PosterImageUrl = "/Content/Images/LoveAndLeashesPoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=p1XLFGKL7gI", },
            new MovieViewModel { 
                Id = 6, 
                Name = "20th Century Girl", 
                Rating = "5", 
                ReleaseYear = 2022, 
                Genre = "Melodrama", 
                Description ="A teen girl has her eyes set on a boy for her lovesick best friend. However, things become complicated when she falls in love and is forced to choose between love and friendship.", 
                PosterImageUrl = "/Content/Images/CenturyGirlPoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=gHE1KQWiimg",  },
            new MovieViewModel { 
                Id = 7, 
                Name = "Sweet & Sour", 
                Rating = "4", 
                ReleaseYear = 2021, 
                Genre = "Rom-Com", 
                Description ="Faced with real-world opportunities and challenges, a couple endures the highs and lows of trying to make a long-distance relationship survive.", 
                PosterImageUrl = "/Content/Images/SweetAndSourPoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=hZORUEZd_pg",  },
            new MovieViewModel { 
                Id = 8, 
                Name = "Kill Boksoon", 
                Rating = "5", 
                ReleaseYear = 2023, 
                Genre = "Action", 
                Description ="Gil Bok-Soon is a single mother and merciless murderer who works for Cha Min-Kyu's M.K. Ent. Before renewing her contract, Bok-Soon engages in a kill-or-be-killed confrontation.", 
                PosterImageUrl = "/Content/Images/KillBoksoonPoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=70e5RjgkHjU",  },
            new MovieViewModel { 
                Id = 9, 
                Name = "Unlocked", 
                Rating = "5", 
                ReleaseYear = 2023, 
                Genre = "Thriller", 
                Description ="A woman's life is turned upside-down after a dangerous man gets a hold of her lost cell phone and uses it to track her every move.", 
                PosterImageUrl = "/Content/Images/UnlockedPoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=k8qGElYoAoU",  },
            new MovieViewModel { 
                Id = 10, 
                Name = "Dream", 
                Rating = "4", 
                ReleaseYear = 2023, 
                Genre = "Drama", 
                Description ="With hard work and dedication on lock, a group of homeless men trains to compete in the Homeless World Cup, despite a cranky coach.", 
                PosterImageUrl = "/Content/Images/DreamPoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=bIjRJjpeg-c",  },
            new MovieViewModel { 
                Id = 11, 
                Name = "Jung E", 
                Rating = "3", 
                ReleaseYear = 2023, 
                Genre = "Sci-Fi", 
                Description ="In a post-apocalyptic near-future, a researcher at an AI lab leads the effort to end a civil war by cloning the brain of a heroic soldier -- her mother.", 
                PosterImageUrl = "/Content/Images/JungEPoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=LCxnmfdxJ6s", },
            new MovieViewModel { 
                Id = 12, 
                Name = "Parasite", 
                Rating = "3", 
                ReleaseYear = 2019, 
                Genre = "Thriller", 
                Description ="Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.", 
                PosterImageUrl = "/Content/Images/ParasitePoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=5xH0HfJHsaY",  },
                
            new MovieViewModel { 
                Id = 13, 
                Name = "Seoul Vibe", 
                Rating = "4", 
                ReleaseYear = 2022, 
                Genre = "Action", 
                Description ="In the days leading up to the 1988 Seoul Olympics, a ragtag team of drivers and mechanics goes undercover to dismantle a massive money-laundering ring that could jeopardise the whole event.", 
                PosterImageUrl = "/Content/Images/SeoulVibePoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=H94Vfb12Hkw",  },
            new MovieViewModel { 
                Id = 14, 
                Name = "The Pirates: The Last Royal Treasure", 
                Rating = "5", 
                ReleaseYear = 2022, 
                Genre = "Adventure", 
                Description ="A gutsy crew of Joseon pirates and bandits battle stormy waters, puzzling clues and militant rivals in search of royal gold lost at sea.", 
                PosterImageUrl = "/Content/Images/ThePiratesPoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=QZx1Zr3WIG0",  },
            new MovieViewModel { 
                Id = 15, 
                Name = "Space Sweepers", 
                Rating = "5", 
                ReleaseYear = 2021, 
                Genre = "Sci-Fi", 
                Description ="After snatching a crashed space shuttle in the latest debris chase, Spaceship Victory's crew members find a 7-year-old girl inside. They realise that she's the humanlike robot wanted by UTS Space Guards, and decide to demand a ransom in exchange.", 
                PosterImageUrl = "/Content/Images/SpaceSweepersPoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=H1WYnJF1Pwo",  },
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

