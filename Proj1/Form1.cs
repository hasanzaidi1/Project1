using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proj1
{
    public partial class Form1 : Form
    {
        int numEntered = 0;
        int speed = 300;
        Random rnd = new Random();
        List<int> selectedNumbers = new List<int>();


        //form2 vars
        int totalPos = 0;
        int totalNeg = 0;
        int totalZero = 0;


        public Form1()
        {
            InitializeComponent();
            radioButtonSlow.Checked = true;

        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumber.Text, out numEntered))
            {
                enterBtn.Enabled = true;
            }
            else
            {
                enterBtn.Enabled = false;
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }

        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int range = numEntered;
            int randomNumber = rnd.Next(-range, range);
            labelRandNum.Text = randomNumber.ToString();
        }



        private void radioButtonSlow_CheckedChanged(object sender, EventArgs e)
        {
            speed = 300;
            timer1.Interval = speed;
        }



        private void listBoxSelectedNums_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFast_CheckedChanged(object sender, EventArgs e)
        {
            speed = 150;
            timer1.Interval = speed;
        }


        private void labelRandNum_Click(object sender, EventArgs e)
        {

        }

        private void labelRandNum_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void labelRandNum_MouseClick_1(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            int clickedNumber;
            if (int.TryParse(labelRandNum.Text, out clickedNumber))
            {
                selectedNumbers.Add(clickedNumber);
                labelSelectedNumList.Text = string.Join(", ", selectedNumbers);

                if (selectedNumbers.Count == 5)
                {


                    DialogResult result = MessageBox.Show("You have selected all 15 numbers", "Program ends", MessageBoxButtons.OK);
                    if (result != DialogResult.OK)
                    {
                        
                        Form2 form2 = new Form2();
                        form2.Show();

                        form2.DisplaySelectedNumbers(selectedNumbers);
                        form2.Calculate(selectedNumbers);
                        
                        
                    } 



                }

            }
        }
    }
}
