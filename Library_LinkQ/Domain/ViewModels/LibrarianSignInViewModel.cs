using Library_LinkQ.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public LibrarianSignInViewModel()
        {
            BackCommand = new RelayCommand(o =>
            {
                App.DeleteLastView();
            });

            LoginCommand = new RelayCommand(o =>
            {
                var librarian = App.dtx.Libs.FirstOrDefault(b => b.FirstName== username);
                
                if (librarian != null)
                {
                    
                }

            });
        }
    }
}
