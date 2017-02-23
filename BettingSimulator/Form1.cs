using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BettingSimulator
{
    public partial class lossesValue : Form
    {
        int[] winningpowerballNumbers;
        int[] yourPowerballNumbers;
        int[] horses;
        Random rand;
        int totalLosses;
        

        public lossesValue()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
            winningpowerballNumbers = new int[6] {0, 0, 0, 0, 0, 0 };
            yourPowerballNumbers = new int[6] {0, 0, 0, 0, 0, 0 };
            horses = new int[5] { 0, 0, 0, 0, 0 };
            int totalLosses = 0;
        }

        private void enterPowerball_Click(object sender, EventArgs e)
        {
            totalLosses = totalLosses - 2;
            int numReg = 0;
            bool redball = false;

            for (int i = 0; i < yourPowerballNumbers.Length; i++)
            {
                if (i == 5)
                {
                    yourPowerballNumbers[5] = rand.Next(1, 27); // 1 to 26 for red
                }
                else
                yourPowerballNumbers[i] = rand.Next(1, 60); //from 1 to 59
            }
            for (int i = 0; i < winningpowerballNumbers.Length; i++)
            {
                if (i == 5)
                {
                    winningpowerballNumbers[5] = rand.Next(1, 27); // 1 to 26 for red
                }
                else
                    winningpowerballNumbers[i] = rand.Next(1, 60); //from 1 to 59
            }
            winPower1.Text = winningpowerballNumbers[0].ToString();
            winPower2.Text = winningpowerballNumbers[1].ToString();
            winPower3.Text = winningpowerballNumbers[2].ToString();
            winPower4.Text = winningpowerballNumbers[3].ToString();
            winPower5.Text = winningpowerballNumbers[4].ToString();
            winPower6.Text = winningpowerballNumbers[5].ToString();

            power1.Text = yourPowerballNumbers[0].ToString();
            power2.Text = yourPowerballNumbers[1].ToString();
            power3.Text = yourPowerballNumbers[2].ToString();
            power4.Text = yourPowerballNumbers[3].ToString();
            power5.Text = yourPowerballNumbers[4].ToString();
            power6.Text = yourPowerballNumbers[5].ToString();

            if(yourPowerballNumbers[0] == winningpowerballNumbers[0])
            {
                numReg++;
            }
            if(yourPowerballNumbers[1] == winningpowerballNumbers[1])
            {
                numReg++;
            }
            if (yourPowerballNumbers[2] == winningpowerballNumbers[2])
            {
                numReg++;
            }
            if (yourPowerballNumbers[3] == winningpowerballNumbers[3])
            {
                numReg++;
            }
            if(yourPowerballNumbers[4] == winningpowerballNumbers[4])
            {
                numReg++;
            }
            if(yourPowerballNumbers[5] == winningpowerballNumbers[5])
            {
                redball = true;
            }
            if (redball == true)
            {
                if (numReg == 5)
                {
                    totalLosses = totalLosses + 300000000;
                }
                else if (numReg == 4)
                {
                    totalLosses = totalLosses + 50000;
                }
                else if (numReg == 3)
                {
                    totalLosses = totalLosses + 100;
                }
                else if (numReg == 2)
                {
                    totalLosses = totalLosses + 7;
                }
                else
                {
                    totalLosses = totalLosses + 4;
                }
                 
            }
            else if(numReg == 5)
            {
                totalLosses = totalLosses + 1000000;
            }
            else if (numReg == 4)
            {
                totalLosses = totalLosses + 100;
            }
            else if (numReg == 3)
            {
                totalLosses = totalLosses + 7;
            }
            lossDisplay.Text = totalLosses.ToString();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            totalLosses = totalLosses - 10;
            int winner;
            winner = horserace();
            winningHorse.Text = "Horse " + winner + " Wins!";

            if (winner == 1)
            {
                totalLosses = totalLosses + 20;
            }
            lossDisplay.Text = totalLosses.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            totalLosses = totalLosses - 10;
            int winner;
            winner = horserace();
            winningHorse.Text = "Horse " + winner + " Wins!";

            if (winner == 2)
            {
                totalLosses = totalLosses + 20;
            }
            lossDisplay.Text = totalLosses.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            totalLosses = totalLosses - 10;
            int winner;
            winner = horserace();
            winningHorse.Text = "Horse " + winner + " Wins!";

            if (winner == 3)
            {
                totalLosses = totalLosses + 20;
            }
            lossDisplay.Text = totalLosses.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            totalLosses = totalLosses - 10;
            int winner;
            winner = horserace();
            winningHorse.Text = "Horse " + winner + " Wins!";

            if (winner == 4)
            {
                totalLosses = totalLosses + 20;
            }
            lossDisplay.Text = totalLosses.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            totalLosses = totalLosses - 10;
            int winner;
            winner = horserace();
            winningHorse.Text = "Horse " + winner + " Wins!";

            if (winner == 5)
            {
                totalLosses = totalLosses + 20;
            }
            lossDisplay.Text = totalLosses.ToString();
        }
        private int horserace()
        {
            int winNum = 0;
            for (int i = 0; i < horses.Length; i++)
            {
                horses[i] = rand.Next(1, 25); // 1 to 25 for speed
            }
            for (int j = 0; j < 5; j++)
            {
                if (j != 4)
                {
                    if (horses[j] > horses[j + 1])
                    {
                        winNum = j;
                    }
                }
            }
            return winNum + 1;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
