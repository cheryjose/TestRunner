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
    public partial class Form2 : Form
    {
        public Form2(List<string> AttributeTypesMatchListBoxDataSource, List<string> TestsListBoxDataSource)
        {
            InitializeComponent();
            AttributeTypesMatchListBox.DataSource = AttributeTypesMatchListBoxDataSource;
            TestsListBox.DataSource = TestsListBoxDataSource;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TestsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string SelectedTest()
        {
            return TestsListBox.SelectedItem.ToString();
        }

    }
}
