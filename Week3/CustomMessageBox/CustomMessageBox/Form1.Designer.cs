namespace CustomMessageBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.YesNo = new System.Windows.Forms.RadioButton();
            this.OkCancel = new System.Windows.Forms.RadioButton();
            this.Ok = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Information = new System.Windows.Forms.RadioButton();
            this.Error = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.YesNo);
            this.groupBox1.Controls.Add(this.OkCancel);
            this.groupBox1.Controls.Add(this.Ok);
            this.groupBox1.Location = new System.Drawing.Point(119, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Button Type";
            // 
            // YesNo
            // 
            this.YesNo.AutoSize = true;
            this.YesNo.Location = new System.Drawing.Point(32, 143);
            this.YesNo.Name = "YesNo";
            this.YesNo.Size = new System.Drawing.Size(75, 21);
            this.YesNo.TabIndex = 2;
            this.YesNo.TabStop = true;
            this.YesNo.Text = "Yes No";
            this.YesNo.UseVisualStyleBackColor = true;
            this.YesNo.CheckedChanged += new System.EventHandler(this.ButtonType_CheckedChanged);
            // 
            // OkCancel
            // 
            this.OkCancel.AutoSize = true;
            this.OkCancel.Location = new System.Drawing.Point(32, 98);
            this.OkCancel.Name = "OkCancel";
            this.OkCancel.Size = new System.Drawing.Size(94, 21);
            this.OkCancel.TabIndex = 1;
            this.OkCancel.TabStop = true;
            this.OkCancel.Text = "Ok Cancel";
            this.OkCancel.UseVisualStyleBackColor = true;
            this.OkCancel.CheckedChanged += new System.EventHandler(this.ButtonType_CheckedChanged);
            // 
            // Ok
            // 
            this.Ok.AutoSize = true;
            this.Ok.Location = new System.Drawing.Point(32, 54);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(47, 21);
            this.Ok.TabIndex = 0;
            this.Ok.TabStop = true;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.CheckedChanged += new System.EventHandler(this.ButtonType_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Information);
            this.groupBox2.Controls.Add(this.Error);
            this.groupBox2.Location = new System.Drawing.Point(446, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Icon Type";
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Location = new System.Drawing.Point(28, 109);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(99, 21);
            this.Information.TabIndex = 4;
            this.Information.TabStop = true;
            this.Information.Text = "Information";
            this.Information.UseVisualStyleBackColor = true;
            this.Information.CheckedChanged += new System.EventHandler(this.IconType_CheckedChanged);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(28, 54);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(61, 21);
            this.Error.TabIndex = 3;
            this.Error.TabStop = true;
            this.Error.Text = "Error";
            this.Error.UseVisualStyleBackColor = true;
            this.Error.CheckedChanged += new System.EventHandler(this.IconType_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Display Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton YesNo;
        private System.Windows.Forms.RadioButton OkCancel;
        private System.Windows.Forms.RadioButton Ok;
        private System.Windows.Forms.RadioButton Information;
        private System.Windows.Forms.RadioButton Error;
        private System.Windows.Forms.Label label1;
    }
}

