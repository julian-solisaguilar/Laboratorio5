 using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestProject
{
    public class Selenium
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void PruebaIngresoCrearPaises()
        {
            string URL = "https://localhost:44355/";
            driver.Manage().Window.Maximize();
            driver.Url = URL;

            IWebElement elementPaises = driver.FindElement(By.Id("Paises"));
            elementPaises.Click();
            Assert.IsNotNull(elementPaises);

            IWebElement elementCrearPais = driver.FindElement(By.Id("Crear Pais"));
            elementCrearPais.Click();
            Assert.IsNotNull(elementCrearPais);

            IWebElement element = driver.FindElement(By.XPath("/html/body/div/main/form/div/div[1]/input"));
            element.SendKeys("Noruega");

            element = driver.FindElement(By.XPath("/html/body/div/main/form/div/div[2]/select"));
            element.SendKeys("Europa");

            element = driver.FindElement(By.XPath("/html/body/div/main/form/div/div[3]/input"));
            element.SendKeys("Noruego");

            element = driver.FindElement(By.XPath("/html/body/div/main/form/div/input"));
            element.Click();

            Assert.IsNotNull(By.ClassName("alert-success"));
        }
    }
} 
