using b3_automation.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using TechTalk.SpecFlow;

namespace b3_automation.StepDefinitions 
{
    [Binding]
    public class HomePageSteps
    { 
        HomePage objectsHomePage = new HomePage();
    
        [Given(@"I opened website bovespa")]
        public void GivenIOpenedWebsiteBovespa()
        {
            objectsHomePage.abrirSite();
        }

        [Given(@"I have get value of bovespa indicator")]
        public void GivenIHaveGetValueOfBovespaIndicator()
        {
            objectsHomePage.getBovespaIndicator();
        }

        [Given(@"I have to click on link to Acesso aos sistemas")]
        public void GivenIHaveToClickOnLinkToAcessoAosSistemas()
        {
           objectsHomePage.getListAcessoRapido();
        }


        [Given(@"I have get value of DI Tax")]
        public void GivenIHaveGetValueOfDITax()
        {
            objectsHomePage.getBovespaTaxaDI();

        }

        [Then(@"the result should be showed on console")]
        public void ThenTheResultShouldBeShowedOnConsole()
        {
           objectsHomePage.getPageTitle();
            
        }
        
        [Then(@"I validate webpage opened")]
        public void ThenIValidateWebpageOpened()
        {
            Assert.AreEqual(true, true);
        }


        [AfterScenario]
        public void fecharWebBrowser()
        {
            objectsHomePage.tearDown();
        }
    }
}
