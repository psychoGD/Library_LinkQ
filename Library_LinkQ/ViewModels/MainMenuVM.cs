using Library_LinkQ.Commands;
using Library_LinkQ.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Library_LinkQ.ViewModels
{
    public class MainMenuVM:BaseViewModel
    {
        public ObservableCollection<BookUC> Books { get; set; }

        public Student student { get; set; }

        public string BaseMessage { get; set; } = "Welcome ";


        private string welcomeMessage;

        public string WelcomeMessage
        {
            get { return welcomeMessage; }
            set { welcomeMessage = value;OnPropertyChanged(); }
        }

        public RelayCommand ProfileCommand { get; set; }

        public void WelcomeMessageFunc()
        {
            //TEST------------------------------
            //try
            //{
            //    MessageBox.Show(student.FirstName);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
                
            //}
            
            if (student == null)
            {
                WelcomeMessage = BaseMessage + "Guest";
            }
            else
            {
                WelcomeMessage = BaseMessage + student.FirstName;
            }
        }

        public void RefreshWelcomeMessage()
        {
            WelcomeMessageFunc();
        }
        public MainMenuVM()
        {
            WelcomeMessageFunc();
            Books= new ObservableCollection<BookUC>();
            var bookArr = App.dtx.Books.ToList();
            for (int i = 0; i < App.dtx.Books.Count(); i++)
            {
                var book = new BookUC();
                var bookVM = new BookUCVM();
                bookVM.book = bookArr[i];
                book.DataContext = bookVM; 
                Books.Add(book);
            }

            ProfileCommand = new RelayCommand(o =>
            {
                if (student == null)
                {
                    var view = new SignInMenu();
                    var vm = new SignInMenuVM();
                    view.DataContext= vm;
                    App.MainGrid.Children.Add(view);
                }
            });


            //for (int i = 0; i < 15; i++)
            //{
            //    //var button = new Button();
            //    //button.Width= 140;
            //    //button.Height= 190;
            //    //button.Margin = new Thickness(20);
            //    //button.Background = Brushes.Brown;
            //    //button.Content = "10$";
            //    //button.Foreground= Brushes.White;
            //    //Books.Add(button);

            //    var book = new BookUC();
            //    book.DataContext = new BookUCVM();

            //    Books.Add(book);
            //    //< Button Width = "120" Height = "170" Margin = "20" Background = "#2C1910"
            //    //        FontSize = "20" Content = "10$" Foreground = "White" ></ Button >
            //}
        }
    }
}
