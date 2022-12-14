using Library_LinkQ.UserControls;
using Library_LinkQ.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library_LinkQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.dtx = new LibraryDataClassesDataContext();
            App.mainMenuVM= new MainMenuVM();
            
            App.MainGrid = MainGrid;
            var signIn = new SignInMenu();
            signIn.DataContext = new SignInMenuVM();
            MainGrid.Children.Add(signIn);

            var MainMenu = new MainMenu();
            MainMenu.DataContext = App.mainMenuVM;
            MainGrid.Children.Insert(0, MainMenu);

            
        }

        
    }
}
