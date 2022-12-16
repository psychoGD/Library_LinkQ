using Library_LinkQ.Commands;
using Library_LinkQ.DataAccess.SqlServer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
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
        public RelayCommand SelectionChangedCommand { get; set; }

        public ObservableCollection<Book> Books { get; set; }
        public ObservableCollection<Book> RentedBooks { get; set; }

        public Book SelectedBook { get; set; }

        public Lib CurrentLibrarian { get; set; }

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
            var books = from p in App.dtx.Books
                           select p;
            Books =  new ObservableCollection<Book>(books);


            var rentedBooks = from p in App.dtx.Books
                           select p;
            RentedBooks = new ObservableCollection<Book>(rentedBooks);

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

            SelectionChangedCommand = new RelayCommand(o =>
            {

            });

            DeleteCommand = new RelayCommand(o =>
            {
                //var result = MessageBox.Show("")
                //App.dtx.Books.DeleteOnSubmit()
            });
        }
    }
}
