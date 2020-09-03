using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doddsinator_3000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Instance Variables
        Boolean generated = false;
        int index, totalCount;
        Boolean formulas = false;

        // Arrays of solutions
        List<string> lhopSolutions = new List<string> { "1/6", "1/4", "ln3/ln2", "1", "ln2", "e^3", "e^(1/2)", "0", "infinity", "1/4", "0", "e^(e/2)", "3/2", "1", "e^(-1/2)", "-ln2", "1/3", "e^3", "3/2", "1", "1", "1/(e^2)", "0", "0", "2/3", "1/3", "cos(1)/2", "0", "1/(1+π)", "1/4" };
        List<string> defSolutions = new List<string> { "-1/4 ln(cos(4x+2)) + C", "1/7 (lnx)^7 + C", "(1/2) sec(2t+1) + C", "1/2 ln(x^2+1) + C", "-1/3 ln(cos3x) + C", "14/3", "-1/2", "10/3", "-ln2", "y=arctan(t) + 2^t + 2 | (-π/2, π/2)", "y = 5^x + arctan(x) + C","y=ln|x| + 1/x + C","y = 1/x + 1/(x^3) + 12x - 11", "v = 4sec(t) + e^t + 3t^2 | (π/2, -π/2)", "y=x^2 - x^3 + 4x + 1", "-cos(2x)/2 - cos^3(2x)/6 + C", "x - sin2x/2 + C", "1/5 (sinx)^5 + C","y=6e^(x^2/2 + 2x) - 5, valid for ℝ", "y=x, valid for (0, inf)"," y=-ln(2-e^sinx), Domain: \n x<arcsin(ln2)", "y=1/(x^2+3) Domain: ℝ", "90 years", "y=2e^(0.458t)", "585 kg", "0.585 days", "6658 years", "3.15 years","(4 sqrt(2)) /3" };
        List<string> appSolutions = new List<string> { "b) 3 \n c) 20", "b) 3 \n c) 2e - (e/2)", "b) 3 \n c) 245", "b) c \n c) 20/3", "4π/3", "22/15", "64/3", "8", "8/3", "8", "sqrt(2) - 1" };
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sets generated to false
            generated = false;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            
            // Only functions if problem hasn't been generated yet
            if(lessons.SelectedIndex != -1)
            {
                //temp variable
                totalCount = getCount();
                if (!generated)
                {
                    // Activate Buttons and labels
                    btnRight.Visible = true;
                    btnWrong.Visible = true;
                    btnReveal.Visible = true;

                    generateProblem();

                    // Sets generate boolean true
                    generated = true;
                }
                else
                {
                    MessageBox.Show("Use the Right or Wrong buttons to generate the next problem!");
                }

            }
            else
            {
                MessageBox.Show("Select a lesson first");
            }
        }

        private void PicProblem_Click(object sender, EventArgs e)
        {

        }

        private void BtnReveal_Click(object sender, EventArgs e)
        {
            
        }
        
        // Wrong button
        private void Button2_Click(object sender, EventArgs e)
        {
            // Generates Next problem
            generateProblem();
            //lbProblems.Text = "Problems Left: " + (lhopSolutions.Count) + "/" + totalCount;


        }
       
        // Right Button
        private void Button1_Click(object sender, EventArgs e)
        {
            if(lessons.SelectedIndex == 0)
            {
                if (lhopSolutions.Count > 1)
                {
                    // Remove problem solution from list
                    lhopSolutions.RemoveAt(index);
                    imageListLhop.Images.RemoveAt(index);
                    generateProblem();
                }
                else
                {
                    MessageBox.Show("You've reached the end of the problem set");
                }
            } 
            else if(lessons.SelectedIndex == 1)
            {
                if (defSolutions.Count > 1)
                {
                    // Remove problem solution from list
                    defSolutions.RemoveAt(index);
                    imageListDef.Images.RemoveAt(index);
                    generateProblem();
                }
                else
                {
                    MessageBox.Show("You've reached the end of the problem set, make sure to study slope fields since they weren't in the program!");
                }
            }
            else if(lessons.SelectedIndex == 2)
            {
                if(appSolutions.Count > 1)
                {
                    appSolutions.RemoveAt(index);
                    imageListApp.Images.RemoveAt(index);
                    generateProblem();
                }
                else
                {
                    MessageBox.Show("You've reached the end of the problem set!");
                }
            }



        }

        // Generates Problems
        public void generateProblem()
        {
            int image = 0;
            // If L'Hopital's rule is selected
            if (lessons.SelectedIndex == 0)
            {
                
                // Picks random number
                Random generate = new Random();
                image = generate.Next(0, imageListLhop.Images.Count);

                picProblem.Image = imageListLhop.Images[image];
                
                // Display
                lbProblems.Text = "Problems Left: " + lhopSolutions.Count + "/" + totalCount;
            }
            else if(lessons.SelectedIndex == 1)
            {
                Random generate = new Random();
                image = generate.Next(0, imageListDef.Images.Count);

                picProblem.Image = imageListDef.Images[image];

                // Display
                lbProblems.Text = "Problems Left: " + defSolutions.Count + "/" + totalCount;
            }
            else if(lessons.SelectedIndex == 2)
            {
                Random generate = new Random();
                image = generate.Next(0, imageListApp.Images.Count);

                picProblem.Image = imageListApp.Images[image];

                // Display
                lbProblems.Text = "Problems Left: " + appSolutions.Count + "/" + totalCount;
            }

            // Returns index
            index = image;

        }

        // Shows Solutions to designated probme
        public void showSolution(int index)
        {
            if(lessons.SelectedIndex == 0)
            {
                btnReveal.Text = lhopSolutions[index];
            }
            else if(lessons.SelectedIndex == 1)
            {
                btnReveal.Text = defSolutions[index];
            }
            else if(lessons.SelectedIndex == 2)
            {
                btnReveal.Text = appSolutions[index];
            }
        }
        private void BtnReveal_MouseHover(object sender, EventArgs e)
        {
            // Change font color
            btnReveal.ForeColor = Color.Red;
            
            // Display Solution
            showSolution(index);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new System.Drawing.Size(386, 626);


        }

        private void BtnReveal_MouseLeave(object sender, EventArgs e)
        {
            // Revert Button
            btnReveal.ForeColor = Color.White;
            btnReveal.Text = "Reveal Answer";
        }

        private void btnFormulas_Click(object sender, EventArgs e)
        {
            if(!formulas)
            {
                this.MaximumSize = new System.Drawing.Size(723, 626);
                this.MinimumSize = new System.Drawing.Size(723, 626);
                btnFormulas.Text = "Close Formula Sheet";
                formulas = true;
            }
            else if(formulas)
            {
                this.MaximumSize = new System.Drawing.Size(386, 626);
                this.MinimumSize = new System.Drawing.Size(386, 626);
                btnFormulas.Text = "Open Formula Sheet";
                formulas = false;
            }
        }

        public int getCount()
        {
            if(lessons.SelectedIndex == 0)
            {
                return lhopSolutions.Count;
            } else if(lessons.SelectedIndex == 1)
            {
                return defSolutions.Count;
            } else if(lessons.SelectedIndex == 2)
            {
                return appSolutions.Count;
            }
            else
            {
                return 0;
            }
        }
    }
}


