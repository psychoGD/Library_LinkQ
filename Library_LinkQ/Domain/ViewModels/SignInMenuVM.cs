using Library_LinkQ.Commands;
using Library_LinkQ.UserControls;
using Library_LinkQ.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library_LinkQ
{
    public class SignInMenuVM:BaseViewModel
    {
        public RelayCommand GuestCommand { get; set; }

        public RelayCommand LibrarianMouseEnter { get; set; }
        public RelayCommand LibrarianMouseLeave { get; set; }

        public RelayCommand StudentMouseEnter { get; set; }
        public RelayCommand StudentMouseLeave { get; set; }

        //Sign in Commands
        public RelayCommand StudentCommand { get; set; }
        public RelayCommand LibrarianCommand { get; set; }


        private string imageSource = App.PLibraryPhoto;

        public string ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; OnPropertyChanged(); }
        }




        public SignInMenuVM()
        {
            GuestCommand = new RelayCommand(o =>
            {
                App.MainGrid.Children.RemoveAt(App.MainGrid.Children.Count - 1);
            });

            LibrarianMouseEnter = new RelayCommand(o =>
            {
                ImageSource = App.PLibrarianPhoto;
            });
            LibrarianMouseLeave = new RelayCommand(o =>
            {
                ImageSource = App.PLibraryPhoto;
            });
            StudentMouseEnter = new RelayCommand(o =>
            {
                ImageSource=App.PStudentLibrary;
            });
            StudentMouseLeave = new RelayCommand(o =>
            {
                ImageSource = App.PLibraryPhoto;
            });

            StudentCommand = new RelayCommand(o =>
            {
                App.DeleteLastView();
                var view = new StudentSignInUC();
                var vm = new StudentSignInViewModel();
                view.DataContext= vm;
                App.MainGrid.Children.Add(view);

            });

            LibrarianCommand = new RelayCommand(o =>
            {
                App.DeleteLastView();
                var view = new LibrarianSignInUC();
                var vm = new LibrarianSignInViewModel();
                view.DataContext= vm;
                App.MainGrid.Children.Add(view);
            });
        }
    }
}
