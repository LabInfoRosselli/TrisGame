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

namespace Tris.WPF
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

        private void GameAction_Click(object sender, RoutedEventArgs e)
        {
            // Make move

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed for C# course at IIS Rosselli-Rasetti"
                + Environment.NewLine
                + Environment.NewLine
                + "Student1" + Environment.NewLine
                + "Student2" + Environment.NewLine
                + "Student3", "About");
        }

        private void OnRestartButton_Click(object sender, EventArgs e)
        {
            // Restart the game
            // Activate all buttons and reset their texts
        }

        private void GameModeComboBox_Click(object sender, SelectionChangedEventArgs e)
        {
            // Get clicked item
            int selection = gameModeComboBox.SelectedIndex;
        }

        private void disableGame()
        {
            // End game
        }

    }
}
