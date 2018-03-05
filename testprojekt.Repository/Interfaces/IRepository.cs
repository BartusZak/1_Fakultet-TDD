using System;
using System.Collections.Generic;
using System.Text;
using testprojekt.Data.DbModels;

namespace testprojekt.Repository.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
    }
}
