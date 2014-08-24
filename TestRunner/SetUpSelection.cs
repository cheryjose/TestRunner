using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TestRunner
{
    public partial class SetUpSelection : Form
    {
        // add a delegate
        public delegate void PreConditionTestHandler(object sender, PreConditionTest e);
        private readonly TestRunner testRunner;

        public SetUpSelection(TestRunner testRunner)
        {
            InitializeComponent();
            this.testRunner = testRunner;
            TestFixtureClasses.DataSource = testRunner.AttributeTypesMatchListBoxDataSource;
            TestsListBox.DataSource = testRunner.TestsListBoxDataSource;
        }

        private void TestsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string SelectedTest()
        {
            return TestsListBox.SelectedItem.ToString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            testRunner.setupSelectedTestFixtureClass = TestFixtureClasses.SelectedItem.ToString();
            testRunner.setupSelected = TestsListBox.SelectedItem.ToString();
            SetUpSelection_FormClosed(sender, new FormClosedEventArgs(CloseReason.UserClosing) );
            this.Close();
         }

        private void SetUpSelection_FormClosed(object sender, FormClosedEventArgs e)
        {
            testRunner.startUpTxtBox.Text = TestsListBox.SelectedItem.ToString();
        }

        private void AttributeTypesMatchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var testFixtureClassSelected = TestFixtureClasses.SelectedItem.ToString();
            var testFixtureClassSelectedType = testRunner._assemblyOperations.
                GetTypeSetupFixtureClass(testFixtureClassSelected, testRunner.TestFixtureTypes);
            TestsListBox.DataSource = testRunner._assemblyOperations.
                GetNunitMethodsForSpecifiedTypeAndAttribute(testFixtureClassSelectedType);
        }
    }
}
