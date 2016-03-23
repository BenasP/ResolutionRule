namespace ResolutionRule
{
    partial class ResolutionRuleForm
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
            this.SourceFileLabel = new System.Windows.Forms.Label();
            this.ResultFileLabel = new System.Windows.Forms.Label();
            this.SourceFileTextBox = new System.Windows.Forms.TextBox();
            this.ResultFileTextBox = new System.Windows.Forms.TextBox();
            this.SourceFileSelectionButton = new System.Windows.Forms.Button();
            this.ResultFileSelectionButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SourceFileLabel
            // 
            this.SourceFileLabel.AutoSize = true;
            this.SourceFileLabel.Location = new System.Drawing.Point(12, 9);
            this.SourceFileLabel.Name = "SourceFileLabel";
            this.SourceFileLabel.Size = new System.Drawing.Size(57, 13);
            this.SourceFileLabel.TabIndex = 0;
            this.SourceFileLabel.Text = "Source file";
            // 
            // ResultFileLabel
            // 
            this.ResultFileLabel.AutoSize = true;
            this.ResultFileLabel.Location = new System.Drawing.Point(13, 36);
            this.ResultFileLabel.Name = "ResultFileLabel";
            this.ResultFileLabel.Size = new System.Drawing.Size(58, 13);
            this.ResultFileLabel.TabIndex = 1;
            this.ResultFileLabel.Text = "Results file";
            // 
            // SourceFIleTextBox
            // 
            this.SourceFileTextBox.Location = new System.Drawing.Point(90, 6);
            this.SourceFileTextBox.Name = "SourceFileTextBox";
            this.SourceFileTextBox.Size = new System.Drawing.Size(125, 20);
            this.SourceFileTextBox.TabIndex = 2;
            // 
            // ResultFileTextBox
            // 
            this.ResultFileTextBox.Location = new System.Drawing.Point(90, 33);
            this.ResultFileTextBox.Name = "ResultFileTextBox";
            this.ResultFileTextBox.Size = new System.Drawing.Size(125, 20);
            this.ResultFileTextBox.TabIndex = 3;
            // 
            // SourceFileSelectionButton
            // 
            this.SourceFileSelectionButton.Location = new System.Drawing.Point(234, 4);
            this.SourceFileSelectionButton.Name = "SourceFileSelectionButton";
            this.SourceFileSelectionButton.Size = new System.Drawing.Size(75, 23);
            this.SourceFileSelectionButton.TabIndex = 4;
            this.SourceFileSelectionButton.Text = "Search";
            this.SourceFileSelectionButton.UseVisualStyleBackColor = true;
            // 
            // ResultFileSelectionButton
            // 
            this.ResultFileSelectionButton.Location = new System.Drawing.Point(234, 30);
            this.ResultFileSelectionButton.Name = "ResultFileSelectionButton";
            this.ResultFileSelectionButton.Size = new System.Drawing.Size(75, 23);
            this.ResultFileSelectionButton.TabIndex = 5;
            this.ResultFileSelectionButton.Text = "Search";
            this.ResultFileSelectionButton.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Enabled = false;
            this.GenerateButton.Location = new System.Drawing.Point(210, 84);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            // 
            // ResolutionRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 120);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.ResultFileSelectionButton);
            this.Controls.Add(this.SourceFileSelectionButton);
            this.Controls.Add(this.ResultFileTextBox);
            this.Controls.Add(this.SourceFileTextBox);
            this.Controls.Add(this.ResultFileLabel);
            this.Controls.Add(this.SourceFileLabel);
            this.Name = "ResolutionRuleForm";
            this.Text = "Resolution rule";
            this.Load += new System.EventHandler(this.ResolutionRuleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SourceFileLabel;
        private System.Windows.Forms.Label ResultFileLabel;
        private System.Windows.Forms.TextBox SourceFileTextBox;
        private System.Windows.Forms.TextBox ResultFileTextBox;
        private System.Windows.Forms.Button SourceFileSelectionButton;
        private System.Windows.Forms.Button ResultFileSelectionButton;
        private System.Windows.Forms.Button GenerateButton;
    }
}

