using Library_LinkQ.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_LinkQ.ViewModels
{
    public class StudentSignInViewModel:BaseViewModel
    {
        public RelayCommand BackCommand{ get; set; }
        public RelayCommand LoginCommand { get; set; }

        private string firstname;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value;OnPropertyChanged(); }
        }

        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; OnPropertyChanged(); }
        }


        public StudentSignInViewModel()
        {
            BackCommand = new RelayCommand(o =>
            {
                App.DeleteLastView();
            });
            LoginCommand = new RelayCommand(o =>
            {
                var student = App.dtx.Students.FirstOrDefault(s=>s.FirstName==Firstname);
                if (student != null)
                {
                    if (student.LastName == Lastname)
                    {
                        App.DeleteLastView();
                        //this for main menu view model current student
                        App.mainMenuVM.student=student;
                        App.mainMenuVM.RefreshWelcomeMessage();

                    }
                }
            });
        }
    }
}
