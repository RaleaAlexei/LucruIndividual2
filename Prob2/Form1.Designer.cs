namespace Prob2
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
            this.cutieOriginal = new System.Windows.Forms.TextBox();
            this.btShow = new System.Windows.Forms.Button();
            this.cutieEditat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cutieOriginal
            // 
            this.cutieOriginal.Location = new System.Drawing.Point(12, 12);
            this.cutieOriginal.Name = "cutieOriginal";
            this.cutieOriginal.PlaceholderText = "Text";
            this.cutieOriginal.Size = new System.Drawing.Size(176, 23);
            this.cutieOriginal.TabIndex = 0;
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(12, 70);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(75, 23);
            this.btShow.TabIndex = 1;
            this.btShow.Text = "Afiseaza";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // cutieEditat
            // 
            this.cutieEditat.Location = new System.Drawing.Point(12, 41);
            this.cutieEditat.Name = "cutieEditat";
            this.cutieEditat.PlaceholderText = "Text Rezultat";
            this.cutieEditat.Size = new System.Drawing.Size(176, 23);
            this.cutieEditat.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 144);
            this.Controls.Add(this.cutieEditat);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.cutieOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox cutieOriginal;
        private Button btShow;
        private TextBox cutieEditat;
    }
}