using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using TestRunner.AssemblyFunctions;
using TestRunner.Runner;

namespace TestRunner
{
    public partial class TestRunner : Form
    {
        private readonly AssemblyOperations _assemblyOperations;
        private TestRun _testRun;
        public TestRunner()
        {
            InitializeComponent();
            _assemblyOperations = new AssemblyOperations();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var fileName = openFileDialog1.FileName;
            if (fileName.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
            {
                LocatedDllTxtBox.Text = fileName;
                TypesListBox.DataSource = _assemblyOperations.GetAllAssemblyTypes(fileName);
                var testFixtureTypes = _assemblyOperations.GetTypesWithSpecifiedCustomAttributes(fileName);
                AttributeTypesMatchListBox.DataSource = testFixtureTypes;
                TestsListBox.DataSource = _assemblyOperations.GetNunitMethodsForSpecifiedTypeAndAttribute(testFixtureTypes[0]);
                SetUpListBox.DataSource = _assemblyOperations.GetNunitMethodsForSpecifiedTypeAndAttribute(testFixtureTypes[0], "SetUpAttribute");
                TearDownListBox.DataSource = _assemblyOperations.GetNunitMethodsForSpecifiedTypeAndAttribute(testFixtureTypes[0], "TearDownAttribute");
            }
            else
            {
                LocatedDllTxtBox.Text = "Invalid Input!!!";
                TypesListBox.DataSource = null;
            }
        }

        private void locatedDllTxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TypesWithAttributeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TestsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTextBox.Text = TestsListBox.SelectedItem.ToString();
        }


        private void runTestButton_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox.Text != string.Empty)
            {
                var packageLocation = LocatedDllTxtBox.Text;
                _testRun = new TestRun(packageLocation);
                var testName = SelectedTextBox.Text.Replace("Void", "").Replace("()","").Trim();
                _testRun.RunTest(testName);
            }
            else
            {
                MessageBox.Show("No test selected to run!!!", "Error");
            }
        }

        private void SelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            runTestButton.Enabled = true;
        }

    }
}
