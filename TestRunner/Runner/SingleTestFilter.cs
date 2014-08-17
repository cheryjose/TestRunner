using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Core;

namespace TestRunner.Runner
{
    public class SingleTestFilter : TestFilter
    {
        private string _testName;

        public SingleTestFilter(string testName)
        {
            _testName = testName;
        }

        public override bool Match(ITest test)
        {
            return test.TestName.Name.Equals(_testName);
        }
    }
}
