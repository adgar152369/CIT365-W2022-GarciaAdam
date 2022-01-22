using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            comboBox1.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            int Number;

            if (int.TryParse(textBox1.Text, out Number))
            {
                if (!(Number < 97) || !(Number > 24))
                {
                    warningWidth.ForeColor = Color.Red;
                    warningWidth.Text = "X";
                }
                else
                {
                    warningWidth.ForeColor = Color.Green;
                    warningWidth.Text = "✓";
                }
            }

            else if (textBox1.Text == "")
            {
                warningWidth.Text = "";
            }
            else
            {
                warningWidth.ForeColor = Color.Red;
                warningWidth.Text = "x";
            }
        }

        private void calculateOrderButton_Click(object sender, EventArgs e)
        {
            DeskQuote deskQuote = new DeskQuote();
            deskQuote.calculateQuote();
        }

    }
}
