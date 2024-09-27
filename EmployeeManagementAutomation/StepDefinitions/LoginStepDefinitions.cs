using System;
using TechTalk.SpecFlow;

namespace EmployeeManagementAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given(@"I have browser with OrangeHRM application")]
        public void GivenIHaveBrowserWithOrangeHRMApplication()
        {
            Console.WriteLine("Given");
        }

        [When(@"I enter username as '([^']*)'")]
        public void WhenIEnterUsernameAs(string username)
        {
            Console.WriteLine("When"+ username);
        }

        [When(@"I enter password as '([^']*)'")]
        public void WhenIEnterPasswordAs(string password)
        {
            Console.WriteLine("When" + password);
        }

        [When(@"click on login")]
        public void WhenClickOnLogin()
        {
            Console.WriteLine("When");
        [Then(@"I should get access to dashboard page with '([^']*)'")]
        public void ThenIShouldGetAccessToDashboardPageWith(string expectedText)
        {
                Console.WriteLine("expectedText");
            }
    }
}
