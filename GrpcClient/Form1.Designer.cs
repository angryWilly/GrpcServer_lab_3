namespace GrpcClient
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
            reverseBtn = new Button();
            outputReversedOnlyWords = new TextBox();
            outputReversedAllText = new TextBox();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(234, 35);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(360, 27);
            inputTextBox.TabIndex = 0;
            inputTextBox.Text = "Input your text here...";
            // 
            // reverseBtn
            // 
            reverseBtn.Location = new Point(347, 84);
            reverseBtn.Name = "reverseBtn";
            reverseBtn.Size = new Size(146, 36);
            reverseBtn.TabIndex = 1;
            reverseBtn.Text = "REVERSE";
            reverseBtn.UseVisualStyleBackColor = true;
            reverseBtn.Click += reverseBtn_Click;
            // 
            // outputReversedOnlyWords
            // 
            outputReversedOnlyWords.Location = new Point(234, 147);
            outputReversedOnlyWords.Name = "outputReversedOnlyWords";
            outputReversedOnlyWords.ReadOnly = true;
            outputReversedOnlyWords.Size = new Size(360, 27);
            outputReversedOnlyWords.TabIndex = 2;
            outputReversedOnlyWords.Text = "...";
            // 
            // outputReversedAllText
            // 
            outputReversedAllText.Location = new Point(234, 205);
            outputReversedAllText.Name = "outputReversedAllText";
            outputReversedAllText.ReadOnly = true;
            outputReversedAllText.Size = new Size(360, 27);
            outputReversedAllText.TabIndex = 3;
            outputReversedAllText.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 299);
            Controls.Add(outputReversedAllText);
            Controls.Add(outputReversedOnlyWords);
            Controls.Add(reverseBtn);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private Button reverseBtn;
        private TextBox outputReversedOnlyWords;
        private TextBox outputReversedAllText;
    }
}
