using System;
using System.Collections.Generic;
using System.Text;
using testprojekt.Data.DbModels;

namespace testprojekt.Services.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAll();
    }
}
