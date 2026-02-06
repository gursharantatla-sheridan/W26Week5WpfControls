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

namespace W26Week5WpfControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetHobbies_Click(object sender, RoutedEventArgs e)
        {
            string hobbies = "";

            if (chkSinging.IsChecked == true)
                hobbies += chkSinging.Content + "\n";

            if (chkGardening.IsChecked == true)
                hobbies += chkGardening.Content + "\n";

            if (chkTravelling.IsChecked == true)
                hobbies += chkTravelling.Content + "\n";

            if (chkRiding.IsChecked == true)
                hobbies += chkRiding.Content + "\n";

            lblMessage.Content = hobbies;

            
        }

        private void btnGetGender_Click(object sender, RoutedEventArgs e)
        {
            string gender = "";

            if (rdoFemale.IsChecked == true)
                gender = "Female";
            else if (rdoMale.IsChecked == true)
                gender = rdoMale.Content + "\n";
            else if (rdoOther.IsChecked == true)
                gender = rdoOther.Content + "\n";
            else
                gender = "Please select gender";

            lblMessage.Content = gender;
        }
    }
}