namespace Prob5
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
            this.figuri = new System.Windows.Forms.ComboBox();
            this.razaInput = new System.Windows.Forms.TextBox();
            this.lungInput = new System.Windows.Forms.TextBox();
            this.inaltInput = new System.Windows.Forms.TextBox();
            this.calculeaza = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // figuri
            // 
            this.figuri.FormattingEnabled = true;
            this.figuri.Items.AddRange(new object[] {
            "Cerc",
            "Dreptunghi"});
            this.figuri.Location = new System.Drawing.Point(12, 12);
            this.figuri.Name = "figuri";
            this.figuri.Size = new System.Drawing.Size(135, 23);
            this.figuri.TabIndex = 0;
            this.figuri.Text = "Alege figura";
            this.figuri.UseWaitCursor = true;
            // 
            // razaInput
            // 
            this.razaInput.Location = new System.Drawing.Point(12, 41);
            this.razaInput.Name = "razaInput";
            this.razaInput.PlaceholderText = "Raza";
            this.razaInput.Size = new System.Drawing.Size(100, 23);
            this.razaInput.TabIndex = 1;
            this.razaInput.UseWaitCursor = true;
            // 
            // lungInput
            // 
            this.lungInput.Location = new System.Drawing.Point(118, 41);
            this.lungInput.Name = "lungInput";
            this.lungInput.PlaceholderText = "Lungime";
            this.lungInput.Size = new System.Drawing.Size(100, 23);
            this.lungInput.TabIndex = 2;
            this.lungInput.UseWaitCursor = true;
            // 
            // inaltInput
            // 
            this.inaltInput.Location = new System.Drawing.Point(224, 41);
            this.inaltInput.Name = "inaltInput";
            this.inaltInput.PlaceholderText = "Inaltime";
            this.inaltInput.Size = new System.Drawing.Size(100, 23);
            this.inaltInput.TabIndex = 3;
            this.inaltInput.UseWaitCursor = true;
            // 
            // calculeaza
            // 
            this.calculeaza.Location = new System.Drawing.Point(12, 102);
            this.calculeaza.Name = "calculeaza";
            this.calculeaza.Size = new System.Drawing.Size(100, 23);
            this.calculeaza.TabIndex = 5;
            this.calculeaza.Text = "Calculeaza";
            this.calculeaza.UseVisualStyleBackColor = true;
            this.calculeaza.UseWaitCursor = true;
            this.calculeaza.Click += new System.EventHandler(this.calculeaza_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.info.Location = new System.Drawing.Point(12, 67);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 17);
            this.info.TabIndex = 6;
            this.info.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 241);
            this.Controls.Add(this.info);
            this.Controls.Add(this.calculeaza);
            this.Controls.Add(this.inaltInput);
            this.Controls.Add(this.lungInput);
            this.Controls.Add(this.razaInput);
            this.Controls.Add(this.figuri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox figuri;
        private TextBox razaInput;
        private TextBox lungInput;
        private TextBox inaltInput;
        private Button calculeaza;
        private Label info;
    }
}