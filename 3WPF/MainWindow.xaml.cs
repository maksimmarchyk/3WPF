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

namespace _3WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Style[ ] Styles;
        private uint CurrentStyle = 0;

        public MainWindow()
        {
            InitializeComponent();
            string[ ] stylesName = new string[ ] {
                "Style1",
                "Style2",
            };
            Styles = new Style[stylesName.Length];
            for (uint i = 0; i < stylesName.Length; i++) {
                Styles[i] = Resources[stylesName[i]] as Style;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            CurrentStyle = (uint)((CurrentStyle + 1) % Styles.Length);
            (sender as Button).Style = Styles[CurrentStyle];
        }
    }
}
