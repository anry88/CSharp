using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Main : Form
    {
        private int computerNumber;
        private int userNumber;
        private int counter;
        public Main()
        {
            InitializeComponent();

            GenerateNumber();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEnter_TextChanged(object sender, EventArgs e)
        {
            if(textBoxEnter.Text.Length > 1)
            {
                if (textBoxEnter.Text[textBoxEnter.Text.Length - 1] == '\n')
                {
                    buttonEnter_Click(sender, e);
                }
            }
            
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            CheckCorrectInput();
        }
        private void GenerateNumber()
        {
            computerNumber = new Random().Next(100);
        }

        private void ShowError()
        {
            MessageBox.Show("Введите корректное число от 0 до 99", "Угадай число",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CheckCorrectInput()
        {
            if (!int.TryParse(textBoxEnter.Text, out userNumber))
            {
                ShowError();
            }
            else if (userNumber < 0 || userNumber > 99)
            {
                ShowError();
            }
            else
            {
                CheckWin();
            }

            textBoxEnter.Clear();
        }

        private void CheckWin()
        {
            counter++;

            if (userNumber < computerNumber)
            {
                labelinfo2.Text = "Ваше число меньше загаданного";
            }else if (userNumber > computerNumber)
            {
                labelinfo2.Text = "Ваше число больше загаданного";
            }
            else
            {
                labelinfo2.Text = $"Вы выиграли за {counter} ходов!";

                GameOver();
            }
        }

        private void GameOver()
        {
            if (MessageBox.Show("Желаете сыграть еще раз?", "Угадай число", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                userNumber = 0;
                counter = 0;
                GenerateNumber();
                labelinfo2.Text = "Введите предполагаемое число";
            }
            else
            {
                Close();
            }
        }
    }
}
