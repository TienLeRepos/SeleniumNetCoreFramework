using DotNetFramework.Core.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using static DotNetFramework.DataObjects.FormUserData;

namespace DotNetFramework.PageObjects.FormsPageObjects
{
    class FormsPage : Page
    {
        public FormsPage(IWebDriver driver) : base(driver) 
        {
            
        }

        private TextBox FirstName => new TextBox(_driver, By.Id("firstName"));
        private TextBox LastName => new TextBox(_driver, By.Id("lastName"));
        private TextBox Email => new TextBox(_driver, By.Id("userEmail"));
        private RadioButton Gender(string gender) => new RadioButton(_driver, By.CssSelector($"input[value='{gender}']"));
        private TextBox Mobile => new TextBox(_driver, By.Id("userNumber"));
        private TextBox Birthdate => new TextBox(_driver, By.Id("dateOfBirthInput"));
        private TextBox Subject => new TextBox(_driver, By.Id("subjectsInput"));
        private RadioButton Hobby(int index) => new RadioButton(_driver, By.CssSelector($"[id='hobbies-checkbox-{index}']"));
        private TextBox Address => new TextBox(_driver, By.Id("currentAddress"));
        private TextBox State => new TextBox(_driver, By.CssSelector("[id='state'] input"));
        private TextBox City => new TextBox(_driver, By.CssSelector("[id='city'] input"));
        private Button Submit => new Button(_driver, By.Id("submit"));

        public void EnterFirstName(string firstName) => FirstName.EnterText(firstName);
        public void EnterLastName(string lastName) => LastName.EnterText(lastName);
        public void EnterEmail(string email) => Email.EnterText(email);
        public void EnterAddress(string address) => Address.EnterText(address);
        public void SelectGender(string gender)
        {
            if (!Gender(gender).IsActive)
                Gender(gender).ClickViaJs();
        }
        public void EnterMobile(string number) => Mobile.EnterText(number);

        public void EnterBirthDate(DateTime birthDate) => Birthdate.SelectAllTextAndEnterNewText($"{birthDate:dd} {birthDate:MMM} {birthDate:yyyy}");

        public void EnterSubject(List<string> subjects)
        {
            foreach (var item in subjects)
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(Subject.Locator));
                Subject.EnterTextAndHitEnter(item);
            }
        }

        public void SelectHobbies(List<Hobby> hobbies)
        {
            foreach (var item in hobbies)
            {
                if (!Hobby((int)item).IsActive)
                    Hobby((int)item).ClickViaJs();
            }
        }

        public void EnterState(string state) => State.EnterTextAndHitEnter(state);
        public void EnterCity(string city) => City.EnterTextAndHitEnter(city);
        public void ClickSubmit() => Submit.ClickViaJs();
    }
}
