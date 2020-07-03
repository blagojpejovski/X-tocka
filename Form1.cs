using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_tocka_proekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int player = 2;//broj na igrachi
        public int turn = 0; //broj odigrani potezi
        public int neresheno = 0;
        public int pobediX = 0;
        public int pobediO = 0;//cuvanje br na pobedi na X, O i kolku neresheni rezulati
        private void allButtonClicks(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")//ako e nema ovaa proverka, so povtoren klik na kvadratceto ke se smeni X vo O i obratno
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";//player 1 pocnuva so X
                    player++;
                    turn++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turn++;
                }
                if(isDraw()==true)
                {
                    neresheno++;
                    MessageBox.Show("DRAW !");
                    newGame();

                }
                if(Winner()==true)
                {
                    if(button.Text=="X")
                    {
                        pobediX++;
                        MessageBox.Show("PLAYER 1 WINS !");
                        newGame();
                    }
                    else
                    {
                        pobediO++;
                        MessageBox.Show("PLAYER 2 WINS !");
                        newGame();
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Xwin.Text = "Player 1: " + pobediX;
            Draw.Text = "Draw: " + neresheno;
            Owin.Text = "Player 2: " + pobediO;
        }
        bool Winner()
        {
            //vertikalno
            if (btn1.Text != "" && (btn1.Text == btn2.Text) && (btn2.Text == btn3.Text))
                return true;
            else if (btn4.Text != "" && (btn4.Text == btn5.Text) && (btn5.Text == btn6.Text))
                return true;
            if (btn7.Text != "" && (btn7.Text == btn8.Text) && (btn8.Text == btn9.Text))
                return true;
            //horizontalno
            if (btn1.Text != "" && (btn1.Text == btn4.Text) && (btn4.Text == btn7.Text))
                return true;
            else if (btn2.Text != "" && (btn2.Text == btn5.Text) && (btn5.Text == btn8.Text))
                return true;
            else if (btn3.Text != "" && (btn3.Text == btn6.Text) && (btn6.Text == btn9.Text))
                return true;
            //dijagonalno
            if (btn1.Text != "" && (btn1.Text == btn5.Text) && (btn5.Text == btn9.Text))
                return true;
            else if (btn7.Text != "" && (btn7.Text == btn5.Text) && (btn5.Text == btn3.Text))
                return true;
            else
                return false;
        }
        bool isDraw()
        {
            if ((turn == 9) && Winner() == false)//klucna proverka, bidejki ako stasa do 9 potezi, i da ima pobednik ke vadi neresheno
                return true;
            else return false;
        }
        void newGame()
        {
            //cuvaj gi prethodnite rezultati
            Xwin.Text = "Player 1: " + pobediX;
            Draw.Text = "Draw: " + neresheno;
            Owin.Text = "Player 2: " + pobediO;
            btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";//gi resetirame site polinja(prazni)
            player = 2;
            turn = 0;//resetirame potezi(bitno za broenje na neresheno)

        }
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            newGame();
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            neresheno = 0;
            pobediO = 0;
            pobediX = 0;
            newGame();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {

        }
        private void Draw_Click(object sender, EventArgs e)
        {

        }
    }
}
