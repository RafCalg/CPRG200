namespace ArraysProgramingProject1
{
    partial class ArrayProgramming1
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
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.saveNumberButton = new System.Windows.Forms.Button();
            this.numberDisplayListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(12, 72);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(110, 13);
            this.numberLabel.TabIndex = 0;
            this.numberLabel.Text = "Enter DecimalNumber";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(157, 72);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 1;
            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
            // 
            // saveNumberButton
            // 
            this.saveNumberButton.Enabled = false;
            this.saveNumberButton.Location = new System.Drawing.Point(292, 72);
            this.saveNumberButton.Name = "saveNumberButton";
            this.saveNumberButton.Size = new System.Drawing.Size(96, 23);
            this.saveNumberButton.TabIndex = 2;
            this.saveNumberButton.Text = "Save Number";
            this.saveNumberButton.UseVisualStyleBackColor = true;
            this.saveNumberButton.Click += new System.EventHandler(this.saveNumberButton_Click);
            // 
            // numberDisplayListBox
            // 
            this.numberDisplayListBox.FormattingEnabled = true;
            this.numberDisplayListBox.Location = new System.Drawing.Point(410, 72);
            this.numberDisplayListBox.Name = "numberDisplayListBox";
            this.numberDisplayListBox.Size = new System.Drawing.Size(120, 95);
            this.numberDisplayListBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(410, 234);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate Statistics";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // ArrayProgramming1
            // 
            this.AcceptButton = this.saveNumberButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 347);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numberDisplayListBox);
            this.Controls.Add(this.saveNumberButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.numberLabel);
            this.Name = "ArrayProgramming1";
            this.Text = "Array Programming Project 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button saveNumberButton;
        private System.Windows.Forms.ListBox numberDisplayListBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

