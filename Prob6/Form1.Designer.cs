namespace Prob6
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
            this.anotimpuri = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // anotimpuri
            // 
            this.anotimpuri.FormattingEnabled = true;
            this.anotimpuri.Items.AddRange(new object[] {
            "Iarna",
            "Vara",
            "Toamna",
            "Primavara"});
            this.anotimpuri.Location = new System.Drawing.Point(12, 12);
            this.anotimpuri.Name = "anotimpuri";
            this.anotimpuri.Size = new System.Drawing.Size(121, 23);
            this.anotimpuri.TabIndex = 0;
            this.anotimpuri.Text = "Anotimpul";
            this.anotimpuri.SelectedIndexChanged += new System.EventHandler(this.anotimpuri_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.anotimpuri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox anotimpuri;
    }
}