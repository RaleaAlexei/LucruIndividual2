namespace Prob8
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
            this.btShow = new System.Windows.Forms.Button();
            this.numInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(12, 79);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(75, 23);
            this.btShow.TabIndex = 5;
            this.btShow.Text = "Afiseaza";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(12, 12);
            this.numInput.Name = "numInput";
            this.numInput.PlaceholderText = "Text";
            this.numInput.Size = new System.Drawing.Size(100, 23);
            this.numInput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 144);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.numInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btShow;
        private TextBox numInput;
    }
}