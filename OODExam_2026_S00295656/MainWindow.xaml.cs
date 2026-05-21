using OODExam_2026_S00295656.Database;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OODExam_2026_S00295656
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ClubData _db;
        public MainWindow()
        {
            InitializeComponent();
            _db = new ClubData();

            CreateDb.DbCreate();
            LoadMembers();
        }
        private void LoadMembers()
        {
            var members = _db.Members
                              .OrderBy(p => p.Surname)
                              .ThenBy(p => p.FirstName)
                              .ToList();

            MembersListBox.ItemsSource = members;
        }

    }
}