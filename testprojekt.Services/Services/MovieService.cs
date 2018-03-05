using System;
using System.Collections.Generic;
using System.Text;
using testprojekt.Data.DbModels;
using testprojekt.Repository.Interfaces;
using testprojekt.Services.Interfaces;

namespace testprojekt.Services.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _movieRepository;
        public MovieService(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public IEnumerable<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }
    }
}
