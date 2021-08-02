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
    }
}
