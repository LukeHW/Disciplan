/* Form1.cs
 * Author: Luke Wahlmeier
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Disciplan
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Setting up the GUI
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for starting button
        /// </summary>
        /// <param name="sender">generic type</param>
        /// <param name="e">generic type</param>
        private void uxStartButton_Click(object sender, EventArgs e)
        {
            uxPages.SelectedIndex = 1;
        }
        /// <summary>
        /// User's name is entered, when enter is pressed name is saved (look to revise)
        /// </summary>
        /// <param name="sender">generic type</param>
        /// <param name="e">generic type</param>
        private void uxName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //if user doesn't enter a name
                if(uxName.Text == "")
                {
                    MessageBox.Show("We can't call you nothing! Please enter the name you would like us to call you.", "Help!");
                }

                //user enters text, either confirm name, or reload page
                else if (MessageBox.Show("Are you sure this is what you want to be called?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    uxPages.SelectedIndex = 2;
                    string name = uxName.Text;
                    //not correct, but will fix
                    uxIntro.Text = ("Hello " + name + "! What would you like to work on?");
                }
                else
                {
                    uxPages.SelectedIndex = 1;
                    uxName.Clear();
                }
            }
        }
    }
}
