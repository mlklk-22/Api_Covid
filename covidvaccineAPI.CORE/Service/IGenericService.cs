using System;
using System.Collections.Generic;

namespace covidvaccineAPI.CORE.Service
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        List<T> Search(String name);



    }
}
