using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBoxForFirstTask_TextChanged(this, EventArgs.Empty);
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            textBoxForNumericUpDown.Text = numericUpDown.Value.ToString();
        }

        private void textBoxForNumericUpDown_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxForFirstTask_TextChanged(object sender, EventArgs e)
        {
            String str = "";
            PropertyInfo[] properties = typeof(DateTime).GetProperties();
            int count = properties.Length;

            foreach (PropertyInfo pi in properties)
            {
                str += pi.Name;
                str += "\r\n";
            }

            str = str.Trim();

            textBoxForFirstTask.Text = str;
        }
    }
}
