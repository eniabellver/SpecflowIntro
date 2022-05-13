using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GameCore.Specs
{
    [Binding]
    public class Hooks : Steps
    {
        [BeforeScenario("elf")]
        public void BeforeScenario()
        {

        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}
