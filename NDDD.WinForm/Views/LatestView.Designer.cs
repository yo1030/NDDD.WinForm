namespace NDDD.WinForm.Views
{
    partial class LatestView
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
            label1 = new Label();
            AreaIdTextBox = new TextBox();
            MeasureValueTextBox = new TextBox();
            label2 = new Label();
            MeasureDateTextBox = new TextBox();
            label3 = new Label();
            SearchButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 29);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "エリアID";
            // 
            // AreaIdTextBox
            // 
            AreaIdTextBox.Location = new Point(123, 24);
            AreaIdTextBox.Name = "AreaIdTextBox";
            AreaIdTextBox.ReadOnly = true;
            AreaIdTextBox.Size = new Size(100, 23);
            AreaIdTextBox.TabIndex = 1;
            // 
            // MeasureValueTextBox
            // 
            MeasureValueTextBox.Location = new Point(122, 96);
            MeasureValueTextBox.Name = "MeasureValueTextBox";
            MeasureValueTextBox.ReadOnly = true;
            MeasureValueTextBox.Size = new Size(100, 23);
            MeasureValueTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 101);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "計測値";
            // 
            // MeasureDateTextBox
            // 
            MeasureDateTextBox.Location = new Point(123, 60);
            MeasureDateTextBox.Name = "MeasureDateTextBox";
            MeasureDateTextBox.ReadOnly = true;
            MeasureDateTextBox.Size = new Size(100, 23);
            MeasureDateTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 65);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "計測日時";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(8, 146);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(270, 28);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // LatestView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(SearchButton);
            Controls.Add(MeasureDateTextBox);
            Controls.Add(label3);
            Controls.Add(MeasureValueTextBox);
            Controls.Add(label2);
            Controls.Add(AreaIdTextBox);
            Controls.Add(label1);
            Name = "LatestView";
            Text = "LatestView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox AreaIdTextBox;
        private TextBox MeasureValueTextBox;
        private Label label2;
        private TextBox MeasureDateTextBox;
        private Label label3;
        private Button SearchButton;
    }
}