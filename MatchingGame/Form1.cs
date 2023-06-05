
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Сильянов Ярослав
namespace Пара
{
    public partial class Form1 : Form
    {
        // firstClicked points to the first Label control 
        // that the player clicks, but it will be null 
        // if the player hasn't clicked a label yet
        Label firstClicked = null;

        // secondClicked points to the second Label control 
        // that the player clicks
        Label secondClicked = null;



        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();

        }



        // Use this Random object to choose random icons for the squares
        Random random = new Random();

        List<string> icons = new List<string>()
        {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
        };
        /// <summary>
        /// Assign each icon from the list of icons to a random square
        /// </summary>
        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                
                iconLabel.ForeColor = iconLabel.BackColor;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];

                    icons.RemoveAt(randomNumber);
                }
            }
        }

        /// <summary>
        /// Every label's Click event is handled by this event handler
        /// </summary>
        /// <param name="sender">The label that was clicked</param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            // The timer is only on after two non-matching 
            // icons have been shown to the player, 
            // so ignore any clicks if the timer is running
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            // Go through all of the labels in the TableLayoutPanel, 
            // checking each one to see if its icon is matched
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            // If the loop didn’t return, it didn't find
            // any unmatched icons
            // That means the user won. Show a message and close the form
            MessageBox.Show("You matched all the icons!", "Congratulations");
            Close();
        }


        private void зановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //firstClicked = null;
            //secondClicked = null;
            //timer1.Stop();
            //foreach (Control control in tableLayoutPanel1.Controls)
            //{
            //    Label iconLabel = control as Label;
            //    List<string> icons = new List<string>()
            //    {
            //    "!", "!", "N", "N", ",", ",", "k", "k",
            //    "b", "b", "v", "v", "w", "w", "z", "z"
            //    };

            //   
            //    iconLabel.ForeColor = iconLabel.BackColor;
            //    if (iconLabel != null)
            //    {

            //        int randomNumber = random.Next(icons.Count);
            //        iconLabel.Text = icons[randomNumber];
            //    }
            //}
            this.Hide();
            Form Form1 = new Form1();
            Form1.Show();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }    
}

