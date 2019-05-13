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
using System.IO;

namespace RockPaperScissorsandSpock_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Picks inputPlayer;
        private Picks inputComputer;
        private int playerScore, computerScore;

        Random rng = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e) //Paper
        {
            inputComputer = (Picks) rng.Next(1, 5);
            inputPlayer = (Picks) 2;
            if (inputComputer == inputPlayer)
            {
                MessageBox.Show("It's a draw!");
            }
            else if (inputComputer == (Picks) 1)
            {
                MessageBox.Show("Player wins, paper covers the rock!");
                playerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 3)
            {
                MessageBox.Show("Scissors cuts paper, computer wins!");
                computerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 4)
            {
                MessageBox.Show("Lizard eats paper, computer wins!");
                computerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 5)
            {
                MessageBox.Show("Paper disproves spock, player wins!");
                playerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //Scissors
        {
            inputComputer = (Picks) rng.Next(1, 5);
            inputPlayer = (Picks) 3;
            if (inputComputer == inputPlayer)
            {

                MessageBox.Show("It's a draw!");
            }
            else if (inputComputer == (Picks) 2)
            {

                MessageBox.Show("Scissors cuts paper, player wins!");
                playerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 1)
            {
                MessageBox.Show("Rock crushes scissors, computer wins!");
                computerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 4)
            {
                MessageBox.Show("Scissors decapitates lizard, player wins!");
                playerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 5)
            {
                MessageBox.Show("Spock smashes scissors, computer wins!");
                computerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //Spock
        {
            inputComputer = (Picks) rng.Next(1, 5);
            inputPlayer = (Picks) 5;
            if (inputComputer == inputPlayer)
            {
                MessageBox.Show("It's a draw!");
            }
            else if (inputComputer == (Picks) 1)
            {
                MessageBox.Show("Spock vaporizes rock, player wins!");
                playerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 2)
            {
                MessageBox.Show("Paper disproves spock, computer wins!");
                computerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 3)
            {
                MessageBox.Show("Spock smashes scissors, player wins!");
                playerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 4)
            {
                MessageBox.Show("Lizard poisons spock, computer wins!");
                computerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) //Rock
        {
            inputComputer = (Picks) rng.Next(1, 5);
            inputPlayer = (Picks) 1;
            if (inputComputer == inputPlayer)
            {
                MessageBox.Show("It's a draw!");
            }
            else if (inputComputer == (Picks) 2)
            {
                MessageBox.Show("Computer wins, paper covers the rock!");
                computerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 3)
            {
                MessageBox.Show("Rock crushes scissors, player wins!");
                playerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 4)
            {
                MessageBox.Show("Rock crushes lizard, player wins!");
                playerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 5)
            {
                MessageBox.Show("Spock vaporizes rock, computer wins!");
                computerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) //Lizard
        {

            inputComputer = (Picks) rng.Next(1, 5);
            inputPlayer = (Picks) 4;
            if (inputComputer == inputPlayer)
            {
                MessageBox.Show("It's a draw!");
            }
            else if (inputComputer == (Picks) 1)
            {
                MessageBox.Show("Rocks crushes lizard, computer wins!");
                computerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 2)
            {
                MessageBox.Show("Lizard eats paper, computer wins!");
                computerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 3)
            {
                MessageBox.Show("Scissors decapitates lizard, computer wins!");
                computerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
            }
            else if (inputComputer == (Picks) 5)
            {
                MessageBox.Show("Lizard poisons spock, player wins!");
                playerScore++;
                Score.Text = $"{computerScore} || {playerScore}";
                if(playerScore == 5)
                {
                    MessageBox.Show("PLAYER IS A WINNER!");
                }
                else if (computerScore == 5)
                {
                    MessageBox.Show("COMPUTER IS A WINNER!");
                }
            }
        }


       
    }

   
}
