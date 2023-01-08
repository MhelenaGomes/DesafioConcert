using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Google.Testes.Buscador
{
    [TestClass]
    public class BuscadorGoogle
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {

            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
        }

        [ClassCleanup]
        public static void CleanupClass()
        {
            try
            {
                driver.Close();
                driver.Dispose();
            }
            catch (Exception)
            {
                
            }
        }

        [TestInitialize]
        public void InitializeTest()
        {
            
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void PesquisaTextoConcert()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Name("q")).Click();
            driver.FindElement(By.Name("q")).Clear();
            driver.FindElement(By.Name("q")).SendKeys("concert technologies");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.IsNotNull(driver.FindElement(By.TagName("h3")).Equals("Concert Technologies | Tecnologia e Inovação para o seu ..."));
        }
   
        [TestMethod]
        public void PesquisaEstouComSorte()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Name("q")).Click();
            driver.FindElement(By.Name("q")).Clear();
            driver.FindElement(By.Name("q")).SendKeys("concert technologies site o");
            driver.FindElement(By.XPath("//div[4]/center/input[2]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            Assert.AreEqual("https://www.concert.com.br/", driver.Url);
        }
     
        [TestMethod]
        public void PesquisaPalavraEscritaIncorretamente()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.Name("q")).Click();
            driver.FindElement(By.Name("q")).Clear();
            driver.FindElement(By.Name("q")).SendKeys("A melhor telinologia com c");
            driver.FindElement(By.XPath("//div[4]/center/input")).Click();

            Assert.IsNotNull(driver.FindElement(By.XPath("//a[@id='fprsl']/b/i")).Equals("A melhor tecnologia com c"));

        }

    }
}