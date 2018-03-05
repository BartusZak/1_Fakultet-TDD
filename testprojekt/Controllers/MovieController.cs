using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testprojekt.Data.DbModels;
using testprojekt.Services.Interfaces;

namespace testprojekt.Controllers
{

    public class MovieController : Controller
    {

        private IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public List<Movie> Get()
        {
            var movies = _movieService.GetAll();

            return movies.ToList();
        }

    }
}