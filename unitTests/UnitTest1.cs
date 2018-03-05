using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using testprojekt.Controllers;
using testprojekt.Data.DbModels;
using testprojekt.Repository.Interfaces;
using testprojekt.Services.Services;
using Xunit;

namespace unitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void ShouldReturnListOfMovies()
        {
            var movies = new List<Movie>() { new Movie(), new Movie() };
            var movieRepository = new Mock<IRepository<Movie>>();
            movieRepository.Setup(x => x.GetAll()).Returns(movies);
            var movieService = new MovieService(movieRepository.Object);
            var movieController = new MovieController(movieService);

            var result = movieController.Get();

            Assert.Equal(movies, result);
        }




    }


    

   

    
    

    
}
