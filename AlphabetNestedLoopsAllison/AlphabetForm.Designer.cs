namespace AlphabetNestedLoopsAllison
{
    partial class frmAlphabet
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
            this.btnstart = new System.Windows.Forms.Button();
            this.lstLetters = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(97, 23);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(78, 25);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lstLetters
            // 
            this.lstLetters.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLetters.FormattingEnabled = true;
            this.lstLetters.ItemHeight = 19;
            this.lstLetters.Location = new System.Drawing.Point(65, 63);
            this.lstLetters.Name = "lstLetters";
            this.lstLetters.Size = new System.Drawing.Size(141, 194);
            this.lstLetters.TabIndex = 1;
            // 
            // frmAlphabet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstLetters);
            this.Controls.Add(this.btnstart);
            this.Name = "frmAlphabet";
            this.Text = "Alphabet Nested Loops by Allison C";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.ListBox lstLetters;
    }
}

