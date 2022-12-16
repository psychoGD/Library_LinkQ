using Library_LinkQ.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library_LinkQ.ViewModels
{
    public class LibrarianMenuViewModel:BaseViewModel
    {
        //Relay Commands
        public RelayCommand BackCommand { get; set; }
        public RelayCommand AddBookCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }


        public List<Book> Books { get; set; }
        public List<Book> RentedBooks { get; set; }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value;OnPropertyChanged(); }
        }

        private int pages;

        public int Pages
        {
            get { return pages; }
            set { pages = value;OnPropertyChanged(); }
        }
        private int yearPress;

        public int YearPress
        {
            get { return yearPress; }
            set { yearPress = value;OnPropertyChanged(); }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value;OnPropertyChanged(); }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value;OnPropertyChanged(); }
        }


        public LibrarianMenuViewModel()
        {
            BackCommand = new RelayCommand(o =>
            {
                App.DeleteLastView();
            });
            AddBookCommand  = new RelayCommand(o =>
            {
                var book = new Book();
                book.Name= Name;
                book.Comment= Comment;
                book.Quantity= Quantity;
                book.YearPress = YearPress;
                book.Pages = Pages;
                App.dtx.Books.InsertOnSubmit(book);
                App.dtx.SubmitChanges();
            });

            DeleteCommand = new RelayCommand(o =>
            {
                //var result = MessageBox.Show("")

            });
        }
    }
}
