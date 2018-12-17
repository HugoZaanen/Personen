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

namespace ITVitaeOefening2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Persoon> AllePersoon = new List<Persoon>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var p = new Persoon();
            p.Voornaam = FirstName.Text;
            p.Achternaam = LastName.Text;
            p.Geboortedatum = DatePick.Text;
            p.Geslacht = (GeslachtEnum)Enum.Parse(typeof(GeslachtEnum), Gender.SelectedItem.ToString());

            MessageBox.Show($"{p.Voornaam} {p.Achternaam} {p.Geboortedatum}");
        }
    }
}
