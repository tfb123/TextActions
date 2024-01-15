namespace TextoRoflai
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.AppendButton = new System.Windows.Forms.Button();
            this.SplitButton = new System.Windows.Forms.Button();
            this.SubstringButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.btnRaides = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(972, 473);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(17, 501);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(142, 34);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AppendButton
            // 
            this.AppendButton.Location = new System.Drawing.Point(165, 501);
            this.AppendButton.Name = "AppendButton";
            this.AppendButton.Size = new System.Drawing.Size(142, 34);
            this.AppendButton.TabIndex = 2;
            this.AppendButton.Text = "Append";
            this.AppendButton.UseVisualStyleBackColor = true;
            this.AppendButton.Click += new System.EventHandler(this.AppendButton_Click);
            // 
            // SplitButton
            // 
            this.SplitButton.Location = new System.Drawing.Point(313, 501);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(142, 34);
            this.SplitButton.TabIndex = 3;
            this.SplitButton.Text = "Split";
            this.SplitButton.UseVisualStyleBackColor = true;
            this.SplitButton.Click += new System.EventHandler(this.SplitButton_Click);
            // 
            // SubstringButton
            // 
            this.SubstringButton.Location = new System.Drawing.Point(461, 501);
            this.SubstringButton.Name = "SubstringButton";
            this.SubstringButton.Size = new System.Drawing.Size(142, 34);
            this.SubstringButton.TabIndex = 4;
            this.SubstringButton.Text = "Substring";
            this.SubstringButton.UseVisualStyleBackColor = true;
            this.SubstringButton.Click += new System.EventHandler(this.SubstringButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(609, 501);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(142, 34);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(757, 501);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(142, 34);
            this.OpenButton.TabIndex = 6;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // btnRaides
            // 
            this.btnRaides.Location = new System.Drawing.Point(905, 501);
            this.btnRaides.Name = "btnRaides";
            this.btnRaides.Size = new System.Drawing.Size(142, 34);
            this.btnRaides.TabIndex = 7;
            this.btnRaides.Text = "Raides";
            this.btnRaides.UseVisualStyleBackColor = true;
            this.btnRaides.Click += new System.EventHandler(this.btnRaides_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 547);
            this.Controls.Add(this.btnRaides);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SubstringButton);
            this.Controls.Add(this.SplitButton);
            this.Controls.Add(this.AppendButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AppendButton;
        private System.Windows.Forms.Button SplitButton;
        private System.Windows.Forms.Button SubstringButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button btnRaides;
    }
}

