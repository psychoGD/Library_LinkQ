using Library_LinkQ.DataAccess.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_LinkQ.ViewModels
{
    public class BookUCVM
    {
        public Book book { get; set; }
        public BookUCVM()
        {
            //book= new Book();
            //book.Name = "The Double";
            //book.YearPress = 2001;
            //book.Author = new Author
            //{
            //    FirstName = "Dostyevski",
            //    LastName = "Fyodor",
            //    Id= 1
            //};
            
            //book.Category = new Category
            //{
            //    Id = 1,
            //    Name = "Classic"
            //};
            
        }
    }
}
