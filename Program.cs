// Chamando importações do Selenium e webdriver do Firefox

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace GoogleSearchAutomatization
{

    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver(); // Inicia a aplicação do Firefox criando um driver
            driver.Navigate().GoToUrl("https://www.google.com/"); // Navega até a URL desejada
            driver.Manage().Window.Maximize();

            var searchText = driver.FindElement(By.ClassName("gLFyf")); // Localiza o input através do nome da classe
            searchText.SendKeys("Concert Technologies S.A"); // Manda a pesquisa para a caixa de texto
            searchText.SendKeys(Keys.Enter); // Simula o click da tecla Enter

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // Caso o objeto de pesquisa não seja encontrado
        }
    }
    
}