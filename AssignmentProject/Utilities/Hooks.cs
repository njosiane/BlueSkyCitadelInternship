using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AssignmentProject.Utilities
{
    [Binding]
    public class Hooks
    {
       public ChromeDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            //ChromeDriver driver = new ChromeDriver();
            Driver = new ChromeDriver();     
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
