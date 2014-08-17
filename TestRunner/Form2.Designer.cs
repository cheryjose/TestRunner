namespace TestRunner
{
    partial class Form2
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
            this.TestsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TestFixtureClassLabel = new System.Windows.Forms.Label();
            this.AttributeTypesMatchListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TestsListBox
            // 
            this.TestsListBox.FormattingEnabled = true;
            this.TestsListBox.HorizontalScrollbar = true;
            this.TestsListBox.Location = new System.Drawing.Point(74, 163);
            this.TestsListBox.Name = "TestsListBox";
            this.TestsListBox.Size = new System.Drawing.Size(260, 69);
            this.TestsListBox.TabIndex = 8;
            this.TestsListBox.SelectedIndexChanged += new System.EventHandler(this.TestsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(71, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "NUnit Tests";
            // 
            // TestFixtureClassLabel
            // 
            this.TestFixtureClassLabel.AutoSize = true;
            this.TestFixtureClassLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TestFixtureClassLabel.Location = new System.Drawing.Point(71, 6);
            this.TestFixtureClassLabel.Name = "TestFixtureClassLabel";
            this.TestFixtureClassLabel.Size = new System.Drawing.Size(98, 13);
            this.TestFixtureClassLabel.TabIndex = 11;
            this.TestFixtureClassLabel.Text = "TestFixture Classes";
            // 
            // AttributeTypesMatchListBox
            // 
            this.AttributeTypesMatchListBox.FormattingEnabled = true;
            this.AttributeTypesMatchListBox.HorizontalScrollbar = true;
            this.AttributeTypesMatchListBox.Location = new System.Drawing.Point(74, 31);
            this.AttributeTypesMatchListBox.Name = "AttributeTypesMatchListBox";
            this.AttributeTypesMatchListBox.Size = new System.Drawing.Size(311, 69);
            this.AttributeTypesMatchListBox.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 316);
            this.Controls.Add(this.TestFixtureClassLabel);
            this.Controls.Add(this.AttributeTypesMatchListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TestsListBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TestsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TestFixtureClassLabel;
        private System.Windows.Forms.ListBox AttributeTypesMatchListBox;
    }
}