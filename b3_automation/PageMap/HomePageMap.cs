
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b3_automation.PageMap
{
    class HomePageMap
    {
    
       [FindsBy(How = How.Id, Using = "ibovPct")]
        public IWebElement lblIndicadorBovespa { get; set; }


        [FindsBy(How = How.Id, Using = "ibovPts")]
        public IWebElement lblPontosBovespa { get; set; }

        [FindsBy(How = How.Id, Using = "taxaPct")]
        public IWebElement lblTaxaDI { get; set; }

        [FindsBy(How = How.Id, Using = "taxaData")]
        public IWebElement lblDataTaxaDI { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[contains(@class,'menu-acesso-rapido')]")]
        public IWebElement listaAcessoRapido { get; set; }



    }
}
