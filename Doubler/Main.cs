using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{
    public partial class Main : Form
    {
        private Random random = new Random();
        private int computerNumber;
        private int userNumber;
        private int countActions;
        private Stack<int> actions = new Stack<int>();

        public Main()
        {
            InitializeComponent();

            UpdateGameState(userNumber, random.Next(20), countActions);

            actions.Push(0);
        }

        private void UpdateGameState(int userNumber)
        {
            labelUserNubmer.Text = $"Текущее число: {userNumber}";
        }

        private void UpdateGameState(int userNumber, int computerNumber, int countActions)
        {
            UpdateGameState(userNumber);
            this.computerNumber = computerNumber;
            labelComputerNumber.Text = $"Получите число: {computerNumber}";
            this.countActions = countActions;
        }



        private void buttonReset_Click(object sender, EventArgs e)
        {
            userNumber = 0;
            UpdateGameState(userNumber, random.Next(20), 0);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            //userNumber = userNumber * 2;
            //UpdateGameState(userNumber);

            actions.Push(userNumber);
            UpdateGameState(userNumber *= 2);
            CheckWin();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //userNumber = userNumber + 1;
            //UpdateGameState(userNumber);

            actions.Push(userNumber);
            UpdateGameState(++userNumber);
            CheckWin();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (actions.Count > 0)
            {
                userNumber = actions.Pop();
                UpdateGameState(userNumber);
                Console.WriteLine(userNumber.ToString());
            }
            
        }

        private void CheckWin()
        {
            countActions++;

            if (userNumber == computerNumber)
            {
                MessageBox.Show($"Вы успешно завершили игру за {countActions} ходов!", "Удвоитель",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                if (MessageBox.Show("Желаете сыграть еще раз?", "Удвоитель", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userNumber = 0;
                    countActions = 0;
                    UpdateGameState(userNumber, random.Next(20), countActions);
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
