﻿using System;
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
    public partial class Main : Form
    {
        TrueFalseDatabase database;


        public Main()
        {
            InitializeComponent();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalseDatabase(dlg.FileName);
                database.Add("Замля круглая?", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalseDatabase(dlg.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }

        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (CheckDatabase())
            {
                database.Save();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckDatabase())
            {

                database.Add($"#{database.Count + 1}", true);
                nudNumber.Maximum = database.Count;
                nudNumber.Value = database.Count;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CheckDatabase())
            {
                database.Remove((int)nudNumber.Value - 1);
                nudNumber.Maximum--;
                nudNumber.Value--;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckDatabase())
            {
                database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
            }

        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (CheckDatabase())
            {
                tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                cbTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
            }

        }

        private bool CheckDatabase()
        {
            if (database == null)
            {
                MessageBox.Show("База вопросов не загуружена", "TrueFalseEditor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else
            {
                return true;
            }

        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            if (CheckDatabase())
            {
                NewGame newGame = new NewGame();

                newGame.Show();
            }

        }
    }
}
