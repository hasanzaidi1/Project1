using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj1
{
    public partial class Form2 : Form
    {

        int positive;
        int negative;
        int zero;

        public Form2()
        {
            InitializeComponent();
            Form1 f1 = (Form1)Application.OpenForms["Form1"];
            f1.Enabled = false;
        }


        public void DisplaySelectedNumbers(List<int> selectedNumbers)
        {
            labelF2RandNumList.Text = string.Join(", ", selectedNumbers);
        }


        public void Calculate(List<int> numList)
        {
            foreach (var i in numList) {
                if (i < 0)
                {
                    negative += 1;
                } else if (i > 0)
                {
                    positive += 1;
                } else { zero += 1; }
            }

            DisplayTotal(positive, negative, zero);
        }

        public void DisplayTotal(int positive, int negative, int zero)
        {
            label1.Text = positive.ToString();
            label3.Text = negative.ToString();
            label2.Text = zero.ToString();  
        }

    }
}
