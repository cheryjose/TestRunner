using System;
using System.Reflection;
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
        public List<string> AttributeTypesMatchListBoxDataSource = new List<string>();
        public List<string> TestsListBoxDataSource = new List<string>();
        public List<string> SetUpListBoxDataSource = new List<string>();
        public List<string> TearDownListBoxDataSource = new List<string>();
        internal readonly AssemblyOperations _assemblyOperations;
        public string setupSelectedTestFixtureClass;
        public string setupSelected;
        private TestRun _testRun;
        internal string FileName;
        internal List<Type> TestFixtureTypes;
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
            FileName = openFileDialog1.FileName;
            if (FileName.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
            {
                LocatedDllTxtBox.Text = FileName;
                TypesListBox.DataSource = _assemblyOperations.GetAllAssemblyTypes(FileName);
                TestFixtureTypes = _assemblyOperations.GetTypesWithSpecifiedCustomAttributes(FileName);
                AttributeTypesMatchListBoxDataSource = TestFixtureTypes.ConvertAll<string>(x => x.ToString());
                AttributeTypesMatchListBox.DataSource = AttributeTypesMatchListBoxDataSource;
                TestsListBoxDataSource = _assemblyOperations.GetNunitMethodsForSpecifiedTypeAndAttribute(TestFixtureTypes[0]);
                TestsListBox.DataSource = TestsListBoxDataSource;
                SetUpListBoxDataSource = _assemblyOperations.GetNunitMethodsForSpecifiedTypeAndAttribute(TestFixtureTypes[0], "SetUpAttribute");
                SetUpListBox.DataSource = SetUpListBoxDataSource;
                TearDownListBoxDataSource = _assemblyOperations.GetNunitMethodsForSpecifiedTypeAndAttribute(TestFixtureTypes[0], "TearDownAttribute");
                TearDownListBox.DataSource = TearDownListBoxDataSource;
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
            var textFixtureListBoxSelection = AttributeTypesMatchListBox.SelectedItem.ToString();
            var setupFixtureClassSelected = _assemblyOperations.GetTypeSetupFixtureClass(textFixtureListBoxSelection, TestFixtureTypes);
            TestsListBox.DataSource = _assemblyOperations.GetNunitMethodsForSpecifiedTypeAndAttribute(setupFixtureClassSelected);
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
                var startUpTestName = startUpTxtBox.Text.Replace("Void", "").Replace("()", "").Trim();
                var testName = SelectedTextBox.Text.Replace("Void", "").Replace("()","").Trim();
                _testRun.RunTest(startUpTestName);
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
            preConditionButton.Enabled = true;
        }

        private void preConditionButton_Click(object sender, EventArgs e)
        {
            SetUpSelection form2 = new SetUpSelection(this);
            form2.Show();
        }

    }
}
