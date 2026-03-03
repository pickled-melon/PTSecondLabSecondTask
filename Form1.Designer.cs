namespace PTSecondLabSecondTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputTextBox = new TextBox();
            label1 = new Label();
            numbersSumLabel = new Label();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(12, 43);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.ScrollBars = ScrollBars.Vertical;
            inputTextBox.Size = new Size(434, 187);
            inputTextBox.TabIndex = 0;
            inputTextBox.TextChanged += inputTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(434, 20);
            label1.TabIndex = 1;
            label1.Text = "Введите строку вида d_1±d_2±...±d_n, где d_i — цифры (n > 1)";
            // 
            // numbersSumLabel
            // 
            numbersSumLabel.AutoSize = true;
            numbersSumLabel.Location = new Point(12, 248);
            numbersSumLabel.Name = "numbersSumLabel";
            numbersSumLabel.Size = new Size(303, 20);
            numbersSumLabel.TabIndex = 2;
            numbersSumLabel.Text = "Результат арифметического выражения: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 284);
            Controls.Add(numbersSumLabel);
            Controls.Add(label1);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "Подсчёт суммы чисел в строке";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private Label label1;
        private Label numbersSumLabel;
    }
}
