using BoDi;
using DotNetFramework.DataObjects;
using DotNetFramework.PageObjects.FormsPageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DotNetFramework.StepDefinitions
{
    [Binding]
    class FormsSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly FormsPage _formsPage;

        public FormsSteps(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _formsPage = new FormsPage(objectContainer.Resolve<IWebDriver>());
        }

        [When(@"I fill the form using the below data:")]
        public void WhenIFillTheFormUsingTheBelowData(Table userData)
        {
            var formUserData = userData.CreateInstance<FormUserData>();

            _formsPage.EnterFirstName(formUserData.Name);
            _formsPage.EnterLastName(formUserData.LastName);
            _formsPage.EnterEmail(formUserData.Email);
            _formsPage.SelectGender(formUserData.Gender);
            _formsPage.EnterMobile(formUserData.Mobile);
            _formsPage.EnterBirthDate(formUserData.Birthday);
            _formsPage.EnterSubject(formUserData.Subjects);
            _formsPage.SelectHobbies(formUserData.Hobbies);
            _formsPage.EnterAddress(formUserData.Address);
            _formsPage.EnterState(formUserData.State);
            _formsPage.EnterCity(formUserData.City);

            _formsPage.ClickSubmit();
        }
    }
}
