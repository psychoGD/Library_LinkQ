using Library_LinkQ.Commands;
using Library_LinkQ.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Library_LinkQ.ViewModels
{
    public class LibrarianSignInViewModel:BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }

        public RelayCommand LoginCommand { get; set; }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value;OnPropertyChanged(); }
        }

        private string lastname;

        public string Lastname
        { 
            get { return lastname; }
            set { lastname = value; OnPropertyChanged(); }
        }

        public LibrarianSignInViewModel()
        {
            BackCommand = new RelayCommand(o =>
            {
                App.DeleteLastView();
            });

            LoginCommand = new RelayCommand(o =>
            {
                var librarianList = from l in App.dtx.Libs
                                where l.FirstName == Username && l.LastName == Lastname
                                select l;
                var librarian = App.dtx.Libs.ToList();
                if(librarian != null)
                {
                    App.DeleteLastView();
                    var view = new LibrarianMenuUC();
                    var vm = new LibrarianMenuViewModel();
                    view.DataContext = vm;
                    App.MainGrid.Children.Add(view);
                }
                else
                {
                    MessageBox.Show($"This Username Isnt Exist: {username}");
                }

            });
        }
    }
}
