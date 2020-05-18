using b3_automation.PageMap;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace b3_automation.PageObjects
{
    class HomePage:HomePageMap
    {

        private IWebDriver driver;
        private WebDriverWait wait;
        private string url = "http://www.b3.com.br/pt_br/";


        public HomePage()
        {
            driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            this.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
            
        }
        public void abrirSite()
        {
            this.driver.Navigate().GoToUrl(url);
        }

        public void getBovespaIndicator()
        {
            String indicador_bovespa = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(lblIndicadorBovespa.GetAttribute("Id")))).Text;
            String pontos_bovespa = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(lblPontosBovespa.GetAttribute("Id")))).Text;
            Console.WriteLine("Indicador Bovespa:" + " " + indicador_bovespa + " " + pontos_bovespa);
        }

        public void getBovespaTaxaDI()
        {
            Thread.Sleep(6000);
            String taxa_de_DI = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(lblTaxaDI.GetAttribute("Id")))).Text;
            String data_taxa_DI = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(lblDataTaxaDI.GetAttribute("Id")))).Text;
            Console.WriteLine("Taxa de DI:" + " " + taxa_de_DI + " " + data_taxa_DI);
        }

        public void getPageTitle()
        {
            String tituloPagina = driver.Title;
            Assert.AreEqual("A Bolsa do Brasil | B3", tituloPagina);
        }

        public void getListAcessoRapido()
        {
            IList<IWebElement> all = driver.FindElements(By.XPath("//ul[contains(@class,'menu-acesso-rapido')]"));
            String[] listaTextos = new String[all.Count];
            int i = 0;
            foreach (IWebElement element in all)
            {
                listaTextos[i++] = element.Text;
            }
            Console.WriteLine(listaTextos[i - 1]);
        }

        public void tearDown()
        {
            this.driver.Close();
            this.driver.Dispose();
        }

    }
}
