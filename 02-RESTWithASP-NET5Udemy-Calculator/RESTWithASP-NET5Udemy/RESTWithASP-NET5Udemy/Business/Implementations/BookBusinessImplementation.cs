﻿using RESTWithASP_NET5Udemy.Model;
using RESTWithASP_NET5Udemy.Model.Context;
using RESTWithASP_NET5Udemy.Repository;

namespace RESTWithASP_NET5Udemy.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IBookRepository _repository;

        public BookBusinessImplementation(IBookRepository repository)
        {
            _repository = repository;
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindByID(long id)
        {
            return _repository.FindByID(id);

        }
        public Book Create(Book book)
        {
            
            return _repository.Create(book);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);

        }
        public void Delete(long id)
        {
            _repository.Delete(id);

        }
    }
}
