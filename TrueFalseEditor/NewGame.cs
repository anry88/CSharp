using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueFalseEditor
{
    public partial class NewGame : Form
    {
        private TrueFalseDatabase database;
        private int counterAnswer;
        private int counterSuccessAnswer;

        public NewGame(TrueFalseDatabase database)
        {
            InitializeComponent();

            Init(database);
        }

        private void Init(TrueFalseDatabase database)
        {
            this.database = database;

            counterAnswer = 0;

            labelCounter.Text = $"Вопрос №{counterAnswer + 1}";

            textBoxQuestion.Text = this.database[counterAnswer].Text;
        }

        private void labelCounter_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveAnswer_Click(object sender, EventArgs e)
        {
            if (counterAnswer < database.Count - 1)
            {
                if (radioButtonTrue.Checked && database[counterAnswer].TrueFalse)
                {
                    counterSuccessAnswer++;
                    ShowAnswer(true);
                }
                else if (radioButtonFalse.Checked && !database[counterAnswer].TrueFalse)
                {
                    counterSuccessAnswer++;
                    ShowAnswer(true);
                }
                else {
                    ShowAnswer(false);
                }
                counterAnswer++;

                labelCounter.Text = $"Вопрос №{counterAnswer + 1}";

                textBoxQuestion.Text = this.database[counterAnswer].Text;

            }
            else
            {
                GameOver();
            }
        }

        private void ShowAnswer(bool success)
        {
            if (success)
            {
                MessageBox.Show("Ответ правильный", "TrueFalseEditor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Ответ не правильный", "TrueFalseEditor",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void GameOver()
        {
            MessageBox.Show($"Вы ответили правильно на {counterSuccessAnswer} вопросов.\n" +
                $"Игра завершена.", "TrueFalseEditor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
