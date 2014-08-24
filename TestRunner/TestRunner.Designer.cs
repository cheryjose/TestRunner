namespace TestRunner
{
    partial class TestRunner
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
            this.locateDllButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LocatedDllTxtBox = new System.Windows.Forms.TextBox();
            this.TypesListBox = new System.Windows.Forms.ListBox();
            this.AttributeTypesMatchListBox = new System.Windows.Forms.ListBox();
            this.TestsListBox = new System.Windows.Forms.ListBox();
            this.runTestButton = new System.Windows.Forms.Button();
            this.SelectedTextBox = new System.Windows.Forms.TextBox();
            this.NUnitTestsLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TestFixtureClassLabel = new System.Windows.Forms.Label();
            this.SetUpListBox = new System.Windows.Forms.ListBox();
            this.TearDownListBox = new System.Windows.Forms.ListBox();
            this.SetUpLabel = new System.Windows.Forms.Label();
            this.TearDownLabel = new System.Windows.Forms.Label();
            this.preConditionButton = new System.Windows.Forms.Button();
            this.startUpTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // locateDllButton
            // 
            this.locateDllButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.locateDllButton.Location = new System.Drawing.Point(12, 32);
            this.locateDllButton.Name = "locateDllButton";
            this.locateDllButton.Size = new System.Drawing.Size(97, 24);
            this.locateDllButton.TabIndex = 0;
            this.locateDllButton.Text = "Locate DLL";
            this.locateDllButton.UseVisualStyleBackColor = true;
            this.locateDllButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LocatedDllTxtBox
            // 
            this.LocatedDllTxtBox.Location = new System.Drawing.Point(156, 36);
            this.LocatedDllTxtBox.Name = "LocatedDllTxtBox";
            this.LocatedDllTxtBox.Size = new System.Drawing.Size(235, 20);
            this.LocatedDllTxtBox.TabIndex = 1;
            this.LocatedDllTxtBox.TextChanged += new System.EventHandler(this.locatedDllTxtBox_TextChanged);
            // 
            // TypesListBox
            // 
            this.TypesListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TypesListBox.FormattingEnabled = true;
            this.TypesListBox.HorizontalScrollbar = true;
            this.TypesListBox.Location = new System.Drawing.Point(23, 105);
            this.TypesListBox.Name = "TypesListBox";
            this.TypesListBox.Size = new System.Drawing.Size(311, 69);
            this.TypesListBox.TabIndex = 2;
            // 
            // AttributeTypesMatchListBox
            // 
            this.AttributeTypesMatchListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AttributeTypesMatchListBox.FormattingEnabled = true;
            this.AttributeTypesMatchListBox.HorizontalScrollbar = true;
            this.AttributeTypesMatchListBox.Location = new System.Drawing.Point(363, 105);
            this.AttributeTypesMatchListBox.Name = "AttributeTypesMatchListBox";
            this.AttributeTypesMatchListBox.Size = new System.Drawing.Size(311, 69);
            this.AttributeTypesMatchListBox.TabIndex = 3;
            this.AttributeTypesMatchListBox.SelectedIndexChanged += new System.EventHandler(this.TypesWithAttributeListBox_SelectedIndexChanged);
            // 
            // TestsListBox
            // 
            this.TestsListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TestsListBox.FormattingEnabled = true;
            this.TestsListBox.HorizontalScrollbar = true;
            this.TestsListBox.Location = new System.Drawing.Point(23, 218);
            this.TestsListBox.Name = "TestsListBox";
            this.TestsListBox.Size = new System.Drawing.Size(260, 69);
            this.TestsListBox.TabIndex = 4;
            this.TestsListBox.SelectedIndexChanged += new System.EventHandler(this.TestsListBox_SelectedIndexChanged);
            // 
            // runTestButton
            // 
            this.runTestButton.Enabled = false;
            this.runTestButton.Location = new System.Drawing.Point(577, 406);
            this.runTestButton.Name = "runTestButton";
            this.runTestButton.Size = new System.Drawing.Size(97, 24);
            this.runTestButton.TabIndex = 5;
            this.runTestButton.Text = "Run Test";
            this.runTestButton.UseVisualStyleBackColor = true;
            this.runTestButton.Click += new System.EventHandler(this.runTestButton_Click);
            // 
            // SelectedTextBox
            // 
            this.SelectedTextBox.Location = new System.Drawing.Point(489, 361);
            this.SelectedTextBox.Name = "SelectedTextBox";
            this.SelectedTextBox.Size = new System.Drawing.Size(235, 20);
            this.SelectedTextBox.TabIndex = 6;
            this.SelectedTextBox.TextChanged += new System.EventHandler(this.SelectedTextBox_TextChanged);
            // 
            // NUnitTestsLabel
            // 
            this.NUnitTestsLabel.AutoSize = true;
            this.NUnitTestsLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NUnitTestsLabel.Location = new System.Drawing.Point(20, 192);
            this.NUnitTestsLabel.Name = "NUnitTestsLabel";
            this.NUnitTestsLabel.Size = new System.Drawing.Size(63, 13);
            this.NUnitTestsLabel.TabIndex = 7;
            this.NUnitTestsLabel.Text = "NUnit Tests";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TypeLabel.Location = new System.Drawing.Point(20, 80);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(43, 13);
            this.TypeLabel.TabIndex = 8;
            this.TypeLabel.Text = "Classes";
            // 
            // TestFixtureClassLabel
            // 
            this.TestFixtureClassLabel.AutoSize = true;
            this.TestFixtureClassLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TestFixtureClassLabel.Location = new System.Drawing.Point(360, 80);
            this.TestFixtureClassLabel.Name = "TestFixtureClassLabel";
            this.TestFixtureClassLabel.Size = new System.Drawing.Size(98, 13);
            this.TestFixtureClassLabel.TabIndex = 9;
            this.TestFixtureClassLabel.Text = "TestFixture Classes";
            // 
            // SetUpListBox
            // 
            this.SetUpListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SetUpListBox.FormattingEnabled = true;
            this.SetUpListBox.HorizontalScrollbar = true;
            this.SetUpListBox.Location = new System.Drawing.Point(296, 218);
            this.SetUpListBox.Name = "SetUpListBox";
            this.SetUpListBox.Size = new System.Drawing.Size(260, 69);
            this.SetUpListBox.TabIndex = 10;
            // 
            // TearDownListBox
            // 
            this.TearDownListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TearDownListBox.FormattingEnabled = true;
            this.TearDownListBox.HorizontalScrollbar = true;
            this.TearDownListBox.Location = new System.Drawing.Point(568, 218);
            this.TearDownListBox.Name = "TearDownListBox";
            this.TearDownListBox.Size = new System.Drawing.Size(260, 69);
            this.TearDownListBox.TabIndex = 11;
            // 
            // SetUpLabel
            // 
            this.SetUpLabel.AutoSize = true;
            this.SetUpLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SetUpLabel.Location = new System.Drawing.Point(293, 192);
            this.SetUpLabel.Name = "SetUpLabel";
            this.SetUpLabel.Size = new System.Drawing.Size(37, 13);
            this.SetUpLabel.TabIndex = 12;
            this.SetUpLabel.Text = "SetUp";
            // 
            // TearDownLabel
            // 
            this.TearDownLabel.AutoSize = true;
            this.TearDownLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TearDownLabel.Location = new System.Drawing.Point(565, 192);
            this.TearDownLabel.Name = "TearDownLabel";
            this.TearDownLabel.Size = new System.Drawing.Size(57, 13);
            this.TearDownLabel.TabIndex = 13;
            this.TearDownLabel.Text = "TearDown";
            // 
            // preConditionButton
            // 
            this.preConditionButton.Enabled = false;
            this.preConditionButton.Location = new System.Drawing.Point(12, 310);
            this.preConditionButton.Name = "preConditionButton";
            this.preConditionButton.Size = new System.Drawing.Size(97, 25);
            this.preConditionButton.TabIndex = 14;
            this.preConditionButton.Text = "StartUpTest";
            this.preConditionButton.UseVisualStyleBackColor = true;
            this.preConditionButton.Click += new System.EventHandler(this.preConditionButton_Click);
            // 
            // startUpTxtBox
            // 
            this.startUpTxtBox.Location = new System.Drawing.Point(124, 313);
            this.startUpTxtBox.Name = "startUpTxtBox";
            this.startUpTxtBox.Size = new System.Drawing.Size(235, 20);
            this.startUpTxtBox.TabIndex = 15;
            // 
            // TestRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(840, 496);
            this.Controls.Add(this.startUpTxtBox);
            this.Controls.Add(this.preConditionButton);
            this.Controls.Add(this.TearDownLabel);
            this.Controls.Add(this.SetUpLabel);
            this.Controls.Add(this.TearDownListBox);
            this.Controls.Add(this.SetUpListBox);
            this.Controls.Add(this.TestFixtureClassLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.NUnitTestsLabel);
            this.Controls.Add(this.SelectedTextBox);
            this.Controls.Add(this.runTestButton);
            this.Controls.Add(this.TestsListBox);
            this.Controls.Add(this.AttributeTypesMatchListBox);
            this.Controls.Add(this.TypesListBox);
            this.Controls.Add(this.LocatedDllTxtBox);
            this.Controls.Add(this.locateDllButton);
            this.Name = "TestRunner";
            this.Text = "TestRunner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button locateDllButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox LocatedDllTxtBox;
        private System.Windows.Forms.ListBox TypesListBox;
        private System.Windows.Forms.ListBox AttributeTypesMatchListBox;
        private System.Windows.Forms.ListBox TestsListBox;
        private System.Windows.Forms.Button runTestButton;
        private System.Windows.Forms.TextBox SelectedTextBox;
        private System.Windows.Forms.Label NUnitTestsLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label TestFixtureClassLabel;
        private System.Windows.Forms.ListBox SetUpListBox;
        private System.Windows.Forms.ListBox TearDownListBox;
        private System.Windows.Forms.Label SetUpLabel;
        private System.Windows.Forms.Label TearDownLabel;
        private System.Windows.Forms.Button preConditionButton;
        internal System.Windows.Forms.TextBox startUpTxtBox;
    }
}

