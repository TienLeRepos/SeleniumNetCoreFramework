using BoDi;
using DotNetFramework.Core.API.REST;
using TechTalk.SpecFlow;

namespace DotNetFramework.StepDefinitions.API
{
    [Binding]
    class TestApiSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public TestApiSteps(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I test the api call")]
        public async void GivenITestTheApiCall()
        {
            var token = await RestTest.GetApiKeyAsync();
        }
    }
}
