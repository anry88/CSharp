namespace Homework_8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxForNumericUpDown = new System.Windows.Forms.TextBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBoxForFirstTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxForNumericUpDown
            // 
            this.textBoxForNumericUpDown.Location = new System.Drawing.Point(155, 307);
            this.textBoxForNumericUpDown.Name = "textBoxForNumericUpDown";
            this.textBoxForNumericUpDown.ReadOnly = true;
            this.textBoxForNumericUpDown.Size = new System.Drawing.Size(624, 22);
            this.textBoxForNumericUpDown.TabIndex = 0;
            this.textBoxForNumericUpDown.TextChanged += new System.EventHandler(this.textBoxForNumericUpDown_TextChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(12, 307);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown.TabIndex = 1;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // textBoxForFirstTask
            // 
            this.textBoxForFirstTask.Location = new System.Drawing.Point(12, 45);
            this.textBoxForFirstTask.Multiline = true;
            this.textBoxForFirstTask.Name = "textBoxForFirstTask";
            this.textBoxForFirstTask.ReadOnly = true;
            this.textBoxForFirstTask.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxForFirstTask.Size = new System.Drawing.Size(767, 210);
            this.textBoxForFirstTask.TabIndex = 2;
            this.textBoxForFirstTask.TextChanged += new System.EventHandler(this.textBoxForFirstTask_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task 1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Task 2";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(812, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxForFirstTask);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.textBoxForNumericUpDown);
            this.MaximumSize = new System.Drawing.Size(830, 400);
            this.MinimumSize = new System.Drawing.Size(830, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForNumericUpDown;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.TextBox textBoxForFirstTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

