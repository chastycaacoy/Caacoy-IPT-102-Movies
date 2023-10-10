using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

