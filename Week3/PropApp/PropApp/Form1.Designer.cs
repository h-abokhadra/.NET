namespace PropApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.Bold = new System.Windows.Forms.CheckBox();
            this.Italic = new System.Windows.Forms.CheckBox();
            this.Underline = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is My text";
            // 
            // Bold
            // 
            this.Bold.AutoSize = true;
            this.Bold.Location = new System.Drawing.Point(241, 126);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(58, 21);
            this.Bold.TabIndex = 1;
            this.Bold.Text = "Bold";
            this.Bold.UseVisualStyleBackColor = true;
            this.Bold.CheckedChanged += new System.EventHandler(this.Bold_CheckedChanged);
            // 
            // Italic
            // 
            this.Italic.AutoSize = true;
            this.Italic.Location = new System.Drawing.Point(382, 126);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(58, 21);
            this.Italic.TabIndex = 2;
            this.Italic.Text = "Italic";
            this.Italic.UseVisualStyleBackColor = true;
            this.Italic.CheckedChanged += new System.EventHandler(this.Italic_CheckedChanged);
            // 
            // Underline
            // 
            this.Underline.AutoSize = true;
            this.Underline.Location = new System.Drawing.Point(535, 126);
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(91, 21);
            this.Underline.TabIndex = 3;
            this.Underline.Text = "Underline";
            this.Underline.UseVisualStyleBackColor = true;
            this.Underline.CheckedChanged += new System.EventHandler(this.Underline_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Underline);
            this.Controls.Add(this.Italic);
            this.Controls.Add(this.Bold);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Bold;
        private System.Windows.Forms.CheckBox Italic;
        private System.Windows.Forms.CheckBox Underline;
    }
}

