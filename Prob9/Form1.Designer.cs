namespace Prob9
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
            this.varstaInput = new System.Windows.Forms.TextBox();
            this.weightInfo = new System.Windows.Forms.Label();
            this.heightInfo = new System.Windows.Forms.Label();
            this.determinabt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // varstaInput
            // 
            this.varstaInput.Location = new System.Drawing.Point(12, 12);
            this.varstaInput.Name = "varstaInput";
            this.varstaInput.PlaceholderText = "Varsta Copilului";
            this.varstaInput.Size = new System.Drawing.Size(100, 23);
            this.varstaInput.TabIndex = 0;
            // 
            // weightInfo
            // 
            this.weightInfo.AutoSize = true;
            this.weightInfo.Location = new System.Drawing.Point(12, 38);
            this.weightInfo.Name = "weightInfo";
            this.weightInfo.Size = new System.Drawing.Size(80, 15);
            this.weightInfo.TabIndex = 1;
            this.weightInfo.Text = "Greutate: 0 kg";
            // 
            // heightInfo
            // 
            this.heightInfo.AutoSize = true;
            this.heightInfo.Location = new System.Drawing.Point(12, 62);
            this.heightInfo.Name = "heightInfo";
            this.heightInfo.Size = new System.Drawing.Size(82, 15);
            this.heightInfo.TabIndex = 2;
            this.heightInfo.Text = "Inaltime: 0 cm";
            // 
            // determinabt
            // 
            this.determinabt.Location = new System.Drawing.Point(12, 80);
            this.determinabt.Name = "determinabt";
            this.determinabt.Size = new System.Drawing.Size(75, 23);
            this.determinabt.TabIndex = 3;
            this.determinabt.Text = "Determina";
            this.determinabt.UseVisualStyleBackColor = true;
            this.determinabt.Click += new System.EventHandler(this.determinabt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.determinabt);
            this.Controls.Add(this.heightInfo);
            this.Controls.Add(this.weightInfo);
            this.Controls.Add(this.varstaInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox varstaInput;
        private Label weightInfo;
        private Label heightInfo;
        private Button determinabt;
    }
}