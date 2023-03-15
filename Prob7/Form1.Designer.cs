namespace Prob7
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
            this.cuvantInput = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(12, 70);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(75, 23);
            this.btShow.TabIndex = 3;
            this.btShow.Text = "Afiseaza";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // cuvantInput
            // 
            this.cuvantInput.Location = new System.Drawing.Point(12, 12);
            this.cuvantInput.Name = "cuvantInput";
            this.cuvantInput.PlaceholderText = "Text";
            this.cuvantInput.Size = new System.Drawing.Size(100, 23);
            this.cuvantInput.TabIndex = 2;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info.Location = new System.Drawing.Point(12, 38);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 15);
            this.info.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 181);
            this.Controls.Add(this.info);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.cuvantInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btShow;
        private TextBox cuvantInput;
        private Label info;
    }
}