
namespace LearnDataStructuresAndAlgorithms
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIsMatch = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.txtIsMatch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(660, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // btnIsMatch
            // 
            this.btnIsMatch.Location = new System.Drawing.Point(315, 24);
            this.btnIsMatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIsMatch.Name = "btnIsMatch";
            this.btnIsMatch.Size = new System.Drawing.Size(82, 22);
            this.btnIsMatch.TabIndex = 2;
            this.btnIsMatch.Text = "Is Match?";
            this.btnIsMatch.UseVisualStyleBackColor = true;
            this.btnIsMatch.Click += new System.EventHandler(this.btnIsMatch_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(12, 23);
            this.txtString.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(285, 23);
            this.txtString.TabIndex = 3;
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(660, 239);
            this.txtPattern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(110, 23);
            this.txtPattern.TabIndex = 4;
            // 
            // txtIsMatch
            // 
            this.txtIsMatch.Location = new System.Drawing.Point(12, 73);
            this.txtIsMatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsMatch.Multiline = true;
            this.txtIsMatch.Name = "txtIsMatch";
            this.txtIsMatch.ReadOnly = true;
            this.txtIsMatch.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIsMatch.Size = new System.Drawing.Size(285, 351);
            this.txtIsMatch.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIsMatch);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnIsMatch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIsMatch;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.TextBox txtIsMatch;
    }
}

