﻿using System;
namespace UserTicketService
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> FindAll()
        {
            return null;
        }
    }

    public interface IBookRepository
    {
        IEnumerable<Book> FindAll();
    }

    public class Book
    {
        public string Title
        { get; set; }
    }
}

