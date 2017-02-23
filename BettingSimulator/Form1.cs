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
        int[] cards;
        int[] cardNum;
        int[] cardSuit;
        Image[] cardPics;
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
            cards = new int[5] { 0, 0, 0, 0, 0 };
            cardNum = new int[5] { 0, 0, 0, 0, 0 };
            cardSuit = new int[5] { 0, 0, 0, 0, 0 };


            cardPics = new Image[52];
            cardPics[0] = Properties.Resources.AC;
            cardPics[1] = Properties.Resources.AD;
            cardPics[2] = Properties.Resources.AH;
            cardPics[3] = Properties.Resources.AS;
            cardPics[4] = Properties.Resources.X2C;
            cardPics[5] = Properties.Resources.X2D;
            cardPics[6] = Properties.Resources.X2H;
            cardPics[7] = Properties.Resources.X2S;
            cardPics[8] = Properties.Resources.X3C;
            cardPics[9] = Properties.Resources.X3D;
            cardPics[10] = Properties.Resources.X3H;
            cardPics[11] = Properties.Resources.X3S;
            cardPics[12] = Properties.Resources.X4C;
            cardPics[13] = Properties.Resources.X4D;
            cardPics[14] = Properties.Resources.X4H;
            cardPics[15] = Properties.Resources.X4S;
            cardPics[16] = Properties.Resources.X5C;
            cardPics[17] = Properties.Resources.X5D;
            cardPics[18] = Properties.Resources.X5H;
            cardPics[19] = Properties.Resources.X5S;
            cardPics[20] = Properties.Resources.X6C;
            cardPics[21] = Properties.Resources.X6D;
            cardPics[22] = Properties.Resources.X6H;
            cardPics[23] = Properties.Resources.X6S;
            cardPics[24] = Properties.Resources.X7C;
            cardPics[25] = Properties.Resources.X7D;
            cardPics[26] = Properties.Resources.X7H;
            cardPics[27] = Properties.Resources.X7S;
            cardPics[28] = Properties.Resources.X8C;
            cardPics[29] = Properties.Resources.X8D;
            cardPics[30] = Properties.Resources.X8H;
            cardPics[31] = Properties.Resources.X8S;
            cardPics[32] = Properties.Resources.X9C;
            cardPics[33] = Properties.Resources.X9D;
            cardPics[34] = Properties.Resources.X9H;
            cardPics[35] = Properties.Resources.X9S;
            cardPics[36] = Properties.Resources.X10C;
            cardPics[37] = Properties.Resources.X10D;
            cardPics[38] = Properties.Resources.X10H;
            cardPics[39] = Properties.Resources.X10S;
            cardPics[40] = Properties.Resources.JC;
            cardPics[41] = Properties.Resources.JD;
            cardPics[42] = Properties.Resources.JH;
            cardPics[43] = Properties.Resources.JS;
            cardPics[44] = Properties.Resources.QC;
            cardPics[45] = Properties.Resources.QD;
            cardPics[46] = Properties.Resources.QH;
            cardPics[47] = Properties.Resources.QS;
            cardPics[48] = Properties.Resources.KC;
            cardPics[49] = Properties.Resources.KD;
            cardPics[50] = Properties.Resources.KH;
            cardPics[51] = Properties.Resources.KS;

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
        private void pokerDraw_Click(object sender, EventArgs e)
        {
            int numOfPairs = 0;
            totalLosses = totalLosses - 2;
            pokerWin.Text = " ";
            for (int i = 0; i < 5; i++ )
            {
                cards[i] = rand.Next(1, 52);
            }
            card1.Image = cardPics[cards[0]];
            card2.Image = cardPics[cards[1]];
            card3.Image = cardPics[cards[2]];
            card4.Image = cardPics[cards[3]];
            card5.Image = cardPics[cards[4]];

            for (int j = 0; j < 5; j++)
            {
                if (cards[j] <= 4)
                {
                    cardNum[j] = 1;
                    if (cards[j] == 0)
                    {
                        cardSuit[j] = 1;
                    }
                    else if (cards[j] == 1)
                    {
                        cardSuit[j] = 2;
                    }
                    else if (cards[j] == 2)
                    {
                        cardSuit[j] = 3;
                    }
                    else
                    {
                        cardSuit[j] = 4;
                    }
                }
                else if (cards[j] <= 8)
                {
                    cardNum[j] = 2;
                    if (cards[j] == 5)
                    {
                        cardSuit[j] = 1;
                    }
                    else if (cards[j] == 6)
                    {
                        cardSuit[j] = 2;
                    }
                    else if (cards[j] == 7)
                    {
                        cardSuit[j] = 3;
                    }
                    else
                    {
                        cardSuit[j] = 4;
                    }
                }
                else if (cards[j] <= 12)
                {
                    cardNum[j] = 3;
                    if (cards[j] == 9)
                    {
                        cardSuit[j] = 1;
                    }
                    else if (cards[j] == 10)
                    {
                        cardSuit[j] = 2;
                    }
                    else if (cards[j] == 11)
                    {
                        cardSuit[j] = 3;
                    }
                    else
                    {
                        cardSuit[j] = 4;
                    }
                }
                else if (cards[j] <= 16)
                {
                    cardNum[j] = 4;
                    if (cards[j] == 13)
                    {
                        cardSuit[j] = 1;
                    }
                    else if (cards[j] == 14)
                    {
                        cardSuit[j] = 2;
                    }
                    else if (cards[j] == 15)
                    {
                        cardSuit[j] = 3;
                    }
                    else
                    {
                        cardSuit[j] = 4;
                    }
                }
                else if (cards[j] <= 20)
                {
                    cardNum[j] = 5;
                    if (cards[j] == 17)
                    {
                        cardSuit[j] = 1;
                    }
                    else if (cards[j] == 18)
                    {
                        cardSuit[j] = 2;
                    }
                    else if (cards[j] == 19)
                    {
                        cardSuit[j] = 3;
                    }
                    else
                    {
                        cardSuit[j] = 4;
                    }
                }
                else if (cards[j] <= 24)
                {
                    cardNum[j] = 6;
                    if (cards[j] == 21)
                    {
                        cardSuit[j] = 1;
                    }
                    else if (cards[j] == 22)
                    {
                        cardSuit[j] = 2;
                    }
                    else if (cards[j] == 23)
                    {
                        cardSuit[j] = 3;
                    }
                    else
                    {
                        cardSuit[j] = 4;
                    }
                }
                else if (cards[j] <= 28)
                {
                    cardNum[j] = 7;
                    if (cards[j] == 25)
                    {
                        cardSuit[j] = 1;
                    }
                    else if (cards[j] == 26)
                    {
                        cardSuit[j] = 2;
                    }
                    else if (cards[j] == 27)
                    {
                        cardSuit[j] = 3;
                    }
                    else
                    {
                        cardSuit[j] = 4;
                    }
                }
                else if (cards[j] <= 32)
                {
                    cardNum[j] = 8;
                    if (cards[j] == 29)
                    {
                        cardSuit[j] = 1;
                    }
                    else if (cards[j] == 30)
                    {
                        cardSuit[j] = 2;
                    }
                    else if (cards[j] == 31)
                    {
                        cardSuit[j] = 3;
                    }
                    else
                    {
                        cardSuit[j] = 4;
                    }
                }
                else if (cards[j] <= 36)
                {
                    cardNum[j] = 9;
                    if (cards[j] == 33)
                    {
                        cardSuit[j] = 1;
                    }
                    else if (cards[j] == 34)
                    {
                        cardSuit[j] = 2;
                    }
                    else if (cards[j] == 35)
                    {
                        cardSuit[j] = 3;
                    }
                    else
                    {
                        cardSuit[j] = 4;
                    }
                }
                else if (cards[j] <= 40)
                {
                    cardNum[j] = 10;
                    if (cards[j] == 37)
                    {
                        cardSuit[j] = 1;
                    }
                    else if (cards[j] == 38)
                    {
                        cardSuit[j] = 2;
                    }
                    else if (cards[j] == 39)
                    {
                        cardSuit[j] = 3;
                    }
                    else
                    {
                        cardSuit[j] = 4;
                    }
                }
                else if (cards[j] <= 44)
                {
                    cardNum[j] = 11;
                    if (cards[j] == 41)
                    {
                        cardSuit[j] = 1;
                    }
                    else if (cards[j] == 42)
                    {
                        cardSuit[j] = 2;
                    }
                    else if (cards[j] == 43)
                    {
                        cardSuit[j] = 3;
                    }
                    else
                    {
                        cardSuit[j] = 4;
                    }
                }
                else if (cards[j] <= 48)
                {
                    cardNum[j] = 12;
                    if (cards[j] == 45)
                    {
                        cardSuit[j] = 1;
                    }
                    else if (cards[j] == 46)
                    {
                        cardSuit[j] = 2;
                    }
                    else if (cards[j] == 47)
                    {
                        cardSuit[j] = 3;
                    }
                    else
                    {
                        cardSuit[j] = 4;
                    }
                }
                else
                {
                    cardNum[j] = 13;
                    if (cards[j] == 49)
                    {
                        cardSuit[j] = 1;
                    }
                    else if (cards[j] == 50)
                    {
                        cardSuit[j] = 2;
                    }
                    else if (cards[j] == 51)
                    {
                        cardSuit[j] = 3;
                    }
                    else
                    {
                        cardSuit[j] = 4;
                    }
                }
            }
            if (cardSuit[0] == cardSuit[1] && cardSuit[0] == cardSuit[2] && cardSuit[0] == cardSuit[3] && cardSuit[0] == cardSuit[4])
            {
                pokerWin.Text = "Flush! You win $50";
                totalLosses = totalLosses + 50;
            }
            for (int k = 0; k < 5; k++)
            {
                for (int l = 1; l < 5; l++)
                {
                    if (cardNum[k] == cardNum[l])
                    {
                        numOfPairs++;
                    }
                }
            }
            if (numOfPairs > 0)
            {
                if (numOfPairs == 1)
                {
                    pokerWin.Text = "1 Pair! You win $3";
                    totalLosses = totalLosses + 3;
                }
                else
                {
                    pokerWin.Text = "2 Pair! You win $10";
                    totalLosses = totalLosses + 3;
                }

            }
                lossDisplay.Text = totalLosses.ToString();
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
