/*
 * Created by: Allison Cook
 * Created on: 12 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Alphabet Nested Loops
 * This program...
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

namespace AlphabetNestedLoopsAllison
{
    public partial class frmAlphabet : Form
    {
        public frmAlphabet()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            //variables
            int counter1, counter2;
            string letter1, letter2;

            for (counter1 = 65; counter1 <= 90; counter1 ++)
            {
                //convert to letter
                letter1 = Char.ConvertFromUtf32(counter1);

                for(counter2 = 97; counter2 <= 122; counter2++)
                {
                    //convert to letter                                                                                                                                           
                    letter2 = Char.ConvertFromUtf32(counter2);

                    //display the letters
                    lstLetters.Items.Add(letter1 + " -> " + letter2);
                }
            }
        }
    }
}
