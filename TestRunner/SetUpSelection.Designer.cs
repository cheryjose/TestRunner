namespace TestRunner
{
    partial class SetUpSelection
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
            this.TestFixtureClasses = new System.Windows.Forms.ListBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestsListBox
            // 
            this.TestsListBox.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(71, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "NUnit Tests";
            // 
            // TestFixtureClassLabel
            // 
            this.TestFixtureClassLabel.AutoSize = true;
            this.TestFixtureClassLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TestFixtureClassLabel.Location = new System.Drawing.Point(71, 6);
            this.TestFixtureClassLabel.Name = "TestFixtureClassLabel";
            this.TestFixtureClassLabel.Size = new System.Drawing.Size(98, 13);
            this.TestFixtureClassLabel.TabIndex = 11;
            this.TestFixtureClassLabel.Text = "TestFixture Classes";
            // 
            // TestFixtureClasses
            // 
            this.TestFixtureClasses.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TestFixtureClasses.FormattingEnabled = true;
            this.TestFixtureClasses.HorizontalScrollbar = true;
            this.TestFixtureClasses.Location = new System.Drawing.Point(74, 31);
            this.TestFixtureClasses.Name = "TestFixtureClasses";
            this.TestFixtureClasses.Size = new System.Drawing.Size(311, 69);
            this.TestFixtureClasses.TabIndex = 10;
            this.TestFixtureClasses.SelectedIndexChanged += new System.EventHandler(this.AttributeTypesMatchListBox_SelectedIndexChanged);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(168, 271);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 12;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SetUpSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(456, 316);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.TestFixtureClassLabel);
            this.Controls.Add(this.TestFixtureClasses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TestsListBox);
            this.Name = "SetUpSelection";
            this.Text = "SetUp Selection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetUpSelection_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TestsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TestFixtureClassLabel;
        private System.Windows.Forms.ListBox TestFixtureClasses;
        private System.Windows.Forms.Button OkButton;
    }
}