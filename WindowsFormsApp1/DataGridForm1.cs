using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OverwatchLibrary;
using CsvParser;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class DataGridForm1 : Form
    {
        static Random random = new Random();
        // Fields that contains a full group of units and filtered.
        private BindingList<Unit> team1 = new BindingList<Unit>();
        private BindingList<Unit> filtered = null;
        // Fields with a choice of players.
        private Unit player1 = null;
        private Unit player2 = null;
        // Some fields for filter.
        private string dps, life, headDps;
        // Some properties for fields.
        string Dps
        {
            get => dps;
            set {
                if (double.TryParse(value, out _))
                {
                    dps = value;
                }
                else if (value == "")
                {
                    dps = "0";
                }
                else
                {
                    MessageBox.Show("Неверный формат данных!");
                    dps = "0";
                }
            }
        }
        string Life
        {
            get => life;
            set {
                if (double.TryParse(value, out _))
                {
                    life = value;
                }
                else if (value == "")
                {
                    life = "0";
                }
                else
                {
                    MessageBox.Show("Неверный формат данных!");
                    life = "0";
                }
            }
        }
        string HeadDps
        {
            get => headDps;
            set {
                if (double.TryParse(value, out _))
                {
                    headDps = value;
                }
                else if (value == "")
                {
                    headDps = "0";
                }
                else
                {
                    MessageBox.Show("Неверный формат данных!");
                    headDps = "0";
                }
            }
        }
        public DataGridForm1()
        {
            InitializeComponent();
            // Call method with bindings.
            SetBindings();
        }
        public (Unit, Unit) TakeHeroes() => (player1, player2); // Lambda function which returns choosing units.
        /// <summary>
        /// Method that read and check information from csv file. Create a list of units and set it into a datasource of DataGridView.
        /// </summary>
        void SetBindings()
        {
            string[][] data = null;
            try
            {
                var csv = new CsvReader();
                data = Parser.CsvParser(csv.ReadLines("../../../Overwatch.csv"));
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("We can't find a csv file!");
                return;
            }

            for (int i = 1; i < data.Length; ++i)
            {
                team1.Add(new Unit(data[i][0], double.Parse(data[i][1]),
                    double.Parse(data[i][2]), double.Parse(data[i][3]),
                    double.Parse(data[i][4]), data[i][5]));
            }
            dataGridView1.DataSource = team1;
        }
        /// <summary>
        /// EventHandler which give an opportunity of choice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "ChoiceColumn" && e.RowIndex != -1)
            {
                if (MessageBox.Show("Are you sure with your choice?", "Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    player1 = dataGridView1.Rows[e.RowIndex].DataBoundItem as Unit;
                    label6.Text = player1.Heroes;
                    label6.ForeColor = Color.White;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                    var index = random.Next(0, dataGridView1.Rows.Count);

                    if (dataGridView1.Rows.Count > 1)
                    {
                        player2 = dataGridView1.Rows[index].DataBoundItem as Unit;
                        label7.Text = player2.Heroes;
                        label7.ForeColor = Color.White;
                        dataGridView1.Rows.Remove(dataGridView1.Rows[index]);
                        MessageBox.Show($"Your opponent takes {player2.Heroes}\nYou can start the game now!", "Choice");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("The computer couldn't make any choice! Try it again!");
                        Close();
                    }
                }
            }
        }
        /// <summary>
        /// EventHandler which catch out a filter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Filter(object sender, EventArgs e)
        {
            Dps = textBox1.Text;
            Life = textBox2.Text;
            HeadDps = textBox3.Text;

            filtered = new BindingList<Unit>(team1.Where(x =>
            x.DamagePS >= double.Parse(Dps) && x.HeadDPS >= double.Parse(HeadDps) && x.Health >= double.Parse(Life)).ToList());
            dataGridView1.DataSource = filtered;
        }
        /// <summary>
        /// EventHandler if the user write wrong data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных!");
        }
    }
}
