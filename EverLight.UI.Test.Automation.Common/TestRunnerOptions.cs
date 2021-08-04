using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverLight.UI.Test.Automation.Common
{
    public class TestRunnerOptions
    {
        public string SiteRoot { get; set; }

        public BrowserType BrowserType { get; set; } = BrowserType.Chrome;

        public bool TakeScreenshots { get; set; } = false;

        public string TestName { get; set; } = "NotSpecified";

        public bool EnabelConsoleLogging { get; set; } = true;

        public bool EnabelDiskLogging { get; set; } = true;

    }
}
