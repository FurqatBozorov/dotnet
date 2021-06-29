using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id) 
        {
            return DataSource().Where(x => x.id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook( string title, string author) 
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        private List<BookModel> DataSource() 
        {
            return new List<BookModel>()
           {
             new BookModel(){ id=1, Title="MVC", Author="Nitish", Description="This is for description of MVC", Category="Programming", Language="English", TotalPages=256 },
             new BookModel(){ id=2, Title="Java", Author="Furqat", Description="This is for description of Java", Category="Programming", Language="English", TotalPages=300 },
             new BookModel(){ id=3, Title="JavScript", Author="Farrux",  Description="This is for description of JavaScript", Category="Programming", Language="English", TotalPages=700 },
             new BookModel(){ id=4, Title="Python", Author="Jamshed",  Description="This is for description of Python", Category="Programming", Language="English", TotalPages=540 },
             new BookModel(){ id=5, Title="React.js", Author="Furqat", Description="This is for description of React.js", Category="Framework", Language="English", TotalPages=630 },
             new BookModel(){ id=6, Title="Vue.js", Author="Furqat", Description="This is for description of Vue.js", Category="Framework", Language="English", TotalPages=582 },
             new BookModel(){ id=7, Title="Django", Author="Nilufar", Description="This is for description of Django", Category="Framework", Language="English", TotalPages=234 },
             new BookModel(){ id=8, Title="C#", Author="Maftuna", Description="This is for description of C#", Category="Programming", Language="English", TotalPages=196 },
           };
        
        }
    }
}
