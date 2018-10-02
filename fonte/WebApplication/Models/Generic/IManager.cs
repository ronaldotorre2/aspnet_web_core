﻿using System.Collections.Generic;

namespace WebApplication.model.Generic
{ 
    public interface IManager<E> where E : class
    {
        bool Insert(E entity);
        bool Update(E entity);
        bool Delete(E entity);
        E GetById(int id);
        E GetByName(string name);
        List<E> GetAll();
    }

}