using System;
using System.Windows.Forms;
using OverwatchLibrary;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        // Objects for units that players choose.
        private Unit player1 = null;
        private Unit player2 = null;
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Label which opens up a new form with DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeroLabel_Click(object sender, EventArgs e)
        {
            var dataGridForm = new DataGridForm1();
            dataGridForm.ShowDialog();
            (player1, player2) = dataGridForm.TakeHeroes();
        }
        /// <summary>
        /// Label which opens up a new form with a game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameLabel_Click(object sender, EventArgs e)
        {
            var path1 = @"../../../player1.xml";
            var path2 = @"../../../player2.xml";
            if (File.Exists(path1) && File.Exists(path2))
            {
                if(MessageBox.Show("Would you like to continue the previous game?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var xml = new XmlParser();
                        player1 = xml.Deserialize(path1);
                        player2 = xml.Deserialize(path2);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Your xml file was crashed!...");
                        return;
                    }
                    var gameForm = new GameForm(player1, player2);
                    gameForm.ShowDialog();
                }
                else
                {
                    if (player1 != null && player2 != null)
                    {
                        var gameForm = new GameForm(player1, player2);
                        gameForm.ShowDialog();
                        player1 = null;
                        player2 = null;
                    }
                    else
                    {
                        MessageBox.Show("You haven't chosen your heroes yet!");
                    }
                }
            }
            else
            {
                if (player1 != null && player2 != null)
                {
                    var gameForm = new GameForm(player1, player2);
                    gameForm.ShowDialog();
                    player1 = null;
                    player2 = null;
                }
                else
                {
                    MessageBox.Show("You haven't chosen your heroes yet!");
                }
            }
        }
        /// <summary>
        /// Label which closes main form and app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }
    }
}
