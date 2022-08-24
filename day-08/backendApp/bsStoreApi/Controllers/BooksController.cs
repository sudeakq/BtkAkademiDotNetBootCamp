﻿using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Concrete;

namespace bsStoreApi.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private AppDbContext _context;

        [HttpGet]
        public List<Book> GetAllBooks()
        {
            var bookList = new List<Book>()
            {
                new Book() {  Id =1, Title="Book 1", Price = 50, Summary="..."},
                new Book() {  Id =2, Title="Book 2", Price = 150, Summary="..."}
            };
            return bookList;
        }
    }
}