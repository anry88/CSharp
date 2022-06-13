namespace TrueFalseEditor
{
    partial class NewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCounter = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.labelChooser = new System.Windows.Forms.Label();
            this.radioButtonTrue = new System.Windows.Forms.RadioButton();
            this.radioButtonFalse = new System.Windows.Forms.RadioButton();
            this.buttonSaveAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCounter
            // 
            this.labelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCounter.Location = new System.Drawing.Point(168, 43);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(439, 60);
            this.labelCounter.TabIndex = 0;
            this.labelCounter.Text = "Вопрос №";
            this.labelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCounter.Click += new System.EventHandler(this.labelCounter_Click);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuestion.Location = new System.Drawing.Point(13, 123);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(757, 115);
            this.textBoxQuestion.TabIndex = 1;
            this.textBoxQuestion.Text = "Вопрос";
            this.textBoxQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelChooser
            // 
            this.labelChooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooser.Location = new System.Drawing.Point(12, 293);
            this.labelChooser.Name = "labelChooser";
            this.labelChooser.Size = new System.Drawing.Size(441, 60);
            this.labelChooser.TabIndex = 2;
            this.labelChooser.Text = "Выберите вариант ответа";
            this.labelChooser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonTrue
            // 
            this.radioButtonTrue.AutoSize = true;
            this.radioButtonTrue.Checked = true;
            this.radioButtonTrue.Location = new System.Drawing.Point(491, 291);
            this.radioButtonTrue.Name = "radioButtonTrue";
            this.radioButtonTrue.Size = new System.Drawing.Size(45, 20);
            this.radioButtonTrue.TabIndex = 3;
            this.radioButtonTrue.TabStop = true;
            this.radioButtonTrue.Text = "Да";
            this.radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // radioButtonFalse
            // 
            this.radioButtonFalse.AutoSize = true;
            this.radioButtonFalse.Location = new System.Drawing.Point(605, 293);
            this.radioButtonFalse.Name = "radioButtonFalse";
            this.radioButtonFalse.Size = new System.Drawing.Size(53, 20);
            this.radioButtonFalse.TabIndex = 4;
            this.radioButtonFalse.TabStop = true;
            this.radioButtonFalse.Text = "Нет";
            this.radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // buttonSaveAnswer
            // 
            this.buttonSaveAnswer.Location = new System.Drawing.Point(515, 330);
            this.buttonSaveAnswer.Name = "buttonSaveAnswer";
            this.buttonSaveAnswer.Size = new System.Drawing.Size(114, 61);
            this.buttonSaveAnswer.TabIndex = 5;
            this.buttonSaveAnswer.Text = "Отправить";
            this.buttonSaveAnswer.UseVisualStyleBackColor = true;
            this.buttonSaveAnswer.Click += new System.EventHandler(this.buttonSaveAnswer_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.buttonSaveAnswer);
            this.Controls.Add(this.radioButtonFalse);
            this.Controls.Add(this.radioButtonTrue);
            this.Controls.Add(this.labelChooser);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.labelCounter);
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "NewGame";
            this.Text = "TrueFalse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label labelChooser;
        private System.Windows.Forms.RadioButton radioButtonTrue;
        private System.Windows.Forms.RadioButton radioButtonFalse;
        private System.Windows.Forms.Button buttonSaveAnswer;
    }
}