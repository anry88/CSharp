namespace GuessTheNumber
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelinfo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxEnter.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnter.Location = new System.Drawing.Point(45, 200);
            this.textBoxEnter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEnter.Multiline = true;
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(387, 98);
            this.textBoxEnter.TabIndex = 2;
            this.textBoxEnter.TextChanged += new System.EventHandler(this.textBoxEnter_TextChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(465, 200);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(133, 98);
            this.buttonEnter.TabIndex = 3;
            this.buttonEnter.Text = "Ввод";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(45, 31);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(553, 74);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Угадайте число  от 0 до 99";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInfo.UseCompatibleTextRendering = true;
            this.labelInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelinfo2
            // 
            this.labelinfo2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelinfo2.Location = new System.Drawing.Point(47, 123);
            this.labelinfo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelinfo2.Name = "labelinfo2";
            this.labelinfo2.Size = new System.Drawing.Size(553, 74);
            this.labelinfo2.TabIndex = 1;
            this.labelinfo2.Text = "Введите предполагаемое число";
            this.labelinfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelinfo2.UseCompatibleTextRendering = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 311);
            this.Controls.Add(this.labelinfo2);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxEnter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(661, 358);
            this.MinimumSize = new System.Drawing.Size(661, 358);
            this.Name = "Main";
            this.Text = "Угадай число";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxEnter;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelinfo2;
    }
}

