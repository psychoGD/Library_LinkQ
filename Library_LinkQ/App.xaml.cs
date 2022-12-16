using Library_LinkQ.DataAccess.SqlServer;
using Library_LinkQ.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Library_LinkQ
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string PLibrarianPhoto { get; set; } = @"..\Images\librarian.jpg";
        public static string PLibraryPhoto { get; set; } = @"..\Images\Library.jpg";
        public static string PStudentLibrary { get; set; } = @"..\Images\StudentLibrary.jpg";
        public static Grid MainGrid { get; set; }
        public static LibraryDataClassesDataContext dtx { get; set; }
        public static MainMenuVM mainMenuVM { get; set; }
        public static void DeleteLastView()
        {
            MainGrid.Children.RemoveAt(MainGrid.Children.Count - 1);
        }
    }
}
