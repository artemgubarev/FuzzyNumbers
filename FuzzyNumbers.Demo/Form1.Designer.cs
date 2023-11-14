namespace FuzzyNumbers.Demo
{
    partial class Form1
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
            this.fuzzyNumbersControl1 = new FuzzyNumbers.FuzzyNumbersControl();
            this.SuspendLayout();
            // 
            // fuzzyNumbersControl1
            // 
            this.fuzzyNumbersControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuzzyNumbersControl1.Location = new System.Drawing.Point(0, 0);
            this.fuzzyNumbersControl1.Name = "fuzzyNumbersControl1";
            this.fuzzyNumbersControl1.Size = new System.Drawing.Size(879, 601);
            this.fuzzyNumbersControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 601);
            this.Controls.Add(this.fuzzyNumbersControl1);
            this.MinimumSize = new System.Drawing.Size(895, 640);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор нечЁтких чисел";
            this.ResumeLayout(false);

        }

        #endregion

        private FuzzyNumbersControl fuzzyNumbersControl1;
    }
}

