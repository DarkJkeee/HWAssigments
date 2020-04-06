using System;
using System.Windows.Forms;
using OverwatchLibrary;

namespace WindowsFormsApp1
{
    public partial class GameForm : Form
    {
        // Paths where located xml files with players.
        string path1 = @"../../../player1.xml";
        string path2 = @"../../../player2.xml";

        static Random random = new Random();
        private int i = 1; // Counter of rounds.

        // Fields with players choice.
        private Unit player1 = null;
        private Unit player2 = null;
        public GameForm(Unit player1, Unit player2)
        {
            // Initialize fields.
            this.player1 = player1;
            this.player2 = player2;
            InitializeComponent();
        }
        /// <summary>
        /// Method which check if units is alive and show the winner.
        /// </summary>
        private void IsAliveChecker()
        {
            if (!player2.IsAlive())
            {
                MessageBox.Show("Player 1 is winner");
                Close();
            }
            if (!player1.IsAlive())
            {
                MessageBox.Show("Player 2 is winner");
                Close();
            }
        }
        /// <summary>
        /// Method which catch out the attack from the computer.
        /// </summary>
        /// <param name="e"></param>
        private void ChoiceOfComputer(EventArgs e)
        {
            if (random.Next(0, 2) == 0)
            {
                ++i;
                player2.DefaultAttack(player1);
                labelPlayer.Text = "Player 1 shoot";
                labelRound.Text = $"Round {i}";
                HPBar1.Value = (int)player1.Health;
            }
            else
            {
                ++i;
                player2.AimAttack(player1);
                labelPlayer.Text = "Player 1 shoot";
                labelRound.Text = $"Round {i}";
                HPBar1.Value = (int)player1.Health;
            }
        }
        /// <summary>
        /// EventHandler with default attack from user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defaultAttackButtonPlayer1_Click(object sender, EventArgs e)
        {
            if (player1.IsAlive())
            {
                player1.DefaultAttack(player2);
                labelPlayer.Text = "Player 2 shoot";
                HPBar2.Value = (int)player2.Health;
                ChoiceOfComputer(e);
            }
            IsAliveChecker();
        }
        /// <summary>
        /// EventHandler with aim attack from user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aimAttackButtonPlayer1_Click(object sender, EventArgs e)
        {
            if (player1.IsAlive())
            {
                player1.AimAttack(player2);
                labelPlayer.Text = "Player 2";
                HPBar2.Value = (int)player2.Health;
                ChoiceOfComputer(e);
            }
            IsAliveChecker();
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            labelPlayer1.Text = player1.Heroes;
            labelPlayer2.Text = player2.Heroes;
            HPBar1.Maximum = (int)player1.MaxHealth;
            HPBar2.Maximum = (int)player2.MaxHealth;
            HPBar1.Value = (int)player1.Health;
            HPBar2.Value = (int)player2.Health;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var xml = new XmlParser();
            xml.SaveToXml(player1, path1);
            xml.SaveToXml(player2, path2);
            MessageBox.Show("You save your game!");
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure? All unsaved progress will be deleted!", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Dispose();
            }
        } // Exit button.
    }
}
