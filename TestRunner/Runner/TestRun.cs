using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Core;

namespace TestRunner.Runner
{
    public class TestRun 
    {
        RemoteTestRunner remoteTesRunner; 

        public TestRun()
        {
            remoteTesRunner = new RemoteTestRunner();
        }
        public TestRun(string fileName)
        {
            TestPackage testPackage = new TestPackage(fileName);
            remoteTesRunner = new RemoteTestRunner();
            remoteTesRunner.Load(testPackage);
        }
       
        public void RunTest(string setUp, string testName, string tearDown)
        {
            var testResult = remoteTesRunner.Run(new NullListener(), new SingleTestFilter(setUp), false, LoggingThreshold.Info);
            var testResult1 = remoteTesRunner.Run(new NullListener(), new SingleTestFilter(testName), false, LoggingThreshold.Info);
            var testResult2 = remoteTesRunner.Run(new NullListener(), new SingleTestFilter(tearDown), false, LoggingThreshold.Info);
        }

        public void RunTest(string testName)
        {
            var testResult1 = remoteTesRunner.Run(new NullListener(), new SingleTestFilter(testName), false, LoggingThreshold.Info);
        }
    }
}
