namespace words_in_string
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.words = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.space = new System.Windows.Forms.Label();
            this.new_line = new System.Windows.Forms.Label();
            this.leters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 8);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(440, 152);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // words
            // 
            this.words.AutoSize = true;
            this.words.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.words.Location = new System.Drawing.Point(32, 208);
            this.words.Name = "words";
            this.words.Size = new System.Drawing.Size(127, 32);
            this.words.TabIndex = 1;
            this.words.Text = "Words: 0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(240, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 95);
            this.button1.TabIndex = 2;
            this.button1.Text = "Count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // space
            // 
            this.space.AutoSize = true;
            this.space.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.space.Location = new System.Drawing.Point(32, 248);
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(127, 32);
            this.space.TabIndex = 3;
            this.space.Text = "Space: 0";
            // 
            // new_line
            // 
            this.new_line.AutoSize = true;
            this.new_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.new_line.Location = new System.Drawing.Point(32, 288);
            this.new_line.Name = "new_line";
            this.new_line.Size = new System.Drawing.Size(155, 32);
            this.new_line.TabIndex = 4;
            this.new_line.Text = "New line: 0";
            // 
            // leters
            // 
            this.leters.AutoSize = true;
            this.leters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leters.Location = new System.Drawing.Point(32, 328);
            this.leters.Name = "leters";
            this.leters.Size = new System.Drawing.Size(125, 32);
            this.leters.TabIndex = 5;
            this.leters.Text = "Leters: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 447);
            this.Controls.Add(this.leters);
            this.Controls.Add(this.new_line);
            this.Controls.Add(this.space);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.words);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label words;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label space;
        private System.Windows.Forms.Label new_line;
        private System.Windows.Forms.Label leters;
    }
}

