using System.Security.Cryptography.X509Certificates;
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

namespace ticTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Player CurrentPlayer = Player.O;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        public enum Player { X, O}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null && clickedButton.Content == null)
            {
                CurrentPlayer = (CurrentPlayer == Player.X) ? Player.O : Player.X;
                clickedButton.Content = CurrentPlayer;
                if (CheckWin(CurrentPlayer))
                {
                    MessageBox.Show($"Gracz {CurrentPlayer} wygrywa!");
                }
            }
        }

        private bool CheckWin(Player CurrentPlayer)
        {
            string symbol = CurrentPlayer == Player.X ? "X" : "O";
            if ((button1.Content?.ToString() == symbol && button2.Content?.ToString() == symbol && button3.Content?.ToString() == symbol)||(button4.Content?.ToString() == symbol && button5.Content?.ToString() == symbol && button6.Content?.ToString() == symbol)||(button7.Content?.ToString() == symbol && button8.Content?.ToString() == symbol && button9.Content?.ToString() == symbol))
            {
                return true;
            }
            if ((button1.Content?.ToString() == symbol && button4.Content?.ToString() == symbol && button7.Content?.ToString() == symbol) || (button2.Content?.ToString() == symbol && button5.Content?.ToString() == symbol && button8.Content?.ToString() == symbol) || (button3.Content?.ToString() == symbol && button6.Content?.ToString() == symbol && button9.Content?.ToString() == symbol))
            {
                return true;
            }
            if ((button1.Content?.ToString() == symbol && button5.Content?.ToString() == symbol && button9.Content?.ToString() == symbol) || (button3.Content?.ToString() == symbol && button5.Content?.ToString() == symbol && button7.Content?.ToString() == symbol))
            {
                return true;
            }
            return false;
        }
            private void Start_Button(object sender, RoutedEventArgs e)
        {
            button1.Content = null;
            button2.Content = null;
            button3.Content = null;
            button4.Content = null;
            button5.Content = null;
            button6.Content = null;
            button7.Content = null;
            button8.Content = null;
            button9.Content = null;
        }
    }
}