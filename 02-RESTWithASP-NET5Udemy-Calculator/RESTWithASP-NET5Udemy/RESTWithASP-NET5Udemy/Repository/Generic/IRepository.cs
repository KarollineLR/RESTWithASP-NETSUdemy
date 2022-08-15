﻿using RESTWithASP_NET5Udemy.Model;
using RESTWithASP_NET5Udemy.Model.Base;

namespace RESTWithASP_NET5Udemy.Repository

  
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);
        List<T> FindWithPagedSearch(string query);
        int GetCount(string query);

    }
}