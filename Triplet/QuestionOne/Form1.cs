using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            output.Text = getTriplates(inputBox.Text);
        }

        public string getTriplates(string sentString)
        {
            //Get input and remove any punctuaction.
            string inputString = Regex.Replace(sentString, @"\p{P}", "");
            string outputString = "";
            //Splite text into words.
            string[] test = inputString.Split(' ');
            //Create paris string to allow for storage
            List<string> paris = new List<string>();
            //Loop through the text array and find all pairs.
            for (int i = 0; test.Length > i; i++)
            {
                for (int j = 0; test.Length > j; j++)
                {
                    //If i + 1 is the same as j, a pair of words have been found.
                    if (j == (i + 1))
                    {
                        //See if pair already exsists within the array.
                        if (!paris.Contains(test[i] + " " + test[j]))
                        {
                            //if not add to array.
                            paris.Add(test[i] + " " + test[j]);
                        }
                    };
                }
            }
            //Find triplats
            for (int g = 0; paris.Count() > g; g++)
            {
                //get the count of how many times the word occurs.
                int count = Regex.Matches(inputString, paris[g]).Count;
                if (count > 1)
                {
                    //if the count from Regex is greater than one, add to output.
                    outputString += paris[g] + ": " + count + "\n";
                }
            }
            return outputString;
        }
    }
}
