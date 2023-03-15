namespace Prob4
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
            this.lungInput = new System.Windows.Forms.TextBox();
            this.Calculeaza = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.Sterge = new System.Windows.Forms.Button();
            this.tablou = new System.Windows.Forms.Panel();
            this.inaltInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lungInput
            // 
            this.lungInput.Location = new System.Drawing.Point(12, 11);
            this.lungInput.Name = "lungInput";
            this.lungInput.PlaceholderText = "Lungime";
            this.lungInput.Size = new System.Drawing.Size(100, 23);
            this.lungInput.TabIndex = 0;
            // 
            // Calculeaza
            // 
            this.Calculeaza.Location = new System.Drawing.Point(118, 12);
            this.Calculeaza.Name = "Calculeaza";
            this.Calculeaza.Size = new System.Drawing.Size(75, 23);
            this.Calculeaza.TabIndex = 1;
            this.Calculeaza.Text = "Calculeaza";
            this.Calculeaza.UseVisualStyleBackColor = true;
            this.Calculeaza.Click += new System.EventHandler(this.Calculeaza_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.info.Location = new System.Drawing.Point(148, 38);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(90, 17);
            this.info.TabIndex = 2;
            this.info.Text = "Aria: 200m^2";
            // 
            // Sterge
            // 
            this.Sterge.Location = new System.Drawing.Point(199, 12);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(75, 23);
            this.Sterge.TabIndex = 3;
            this.Sterge.Text = "Sterge";
            this.Sterge.UseVisualStyleBackColor = true;
            // 
            // tablou
            // 
            this.tablou.Location = new System.Drawing.Point(12, 57);
            this.tablou.Name = "tablou";
            this.tablou.Size = new System.Drawing.Size(262, 192);
            this.tablou.TabIndex = 4;
            // 
            // inaltInput
            // 
            this.inaltInput.Location = new System.Drawing.Point(12, 32);
            this.inaltInput.Name = "inaltInput";
            this.inaltInput.PlaceholderText = "Inaltime";
            this.inaltInput.Size = new System.Drawing.Size(100, 23);
            this.inaltInput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.inaltInput);
            this.Controls.Add(this.tablou);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Calculeaza);
            this.Controls.Add(this.lungInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox lungInput;
        private Button Calculeaza;
        private Label info;
        private Button Sterge;
        private Panel tablou;
        private TextBox inaltInput;
    }
}