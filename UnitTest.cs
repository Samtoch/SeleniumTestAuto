using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAuto
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void WebUIAutoamtionWithCustomMethods()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://propertynovel.com/Home/Login");
            driver.Manage().Window.Maximize();

            SeleniumCustomMethod.EnterText(driver, By.Name("Email"), "sooo@caledonian.ac.uk");
            SeleniumCustomMethod.EnterText(driver, By.Name("password"), "password");
            SeleniumCustomMethod.Click(driver, By.Name("load"));
        }

        [Test]
        public void WebAdvancedControls()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/Offiahs/OneDrive%20-%20merseycare.nhs.uk/Desktop/websites/LearnMore.html");
            driver.Manage().Window.Maximize();

            var dropdown = driver.FindElement(By.Id("cars"));
            SelectElement selectElement = new SelectElement(dropdown);
            //selectElement.SelectByText("Mercedes");
            selectElement.SelectByValue("audi");

            //Retrieve Selected Option
            var selectedOption = selectElement.SelectedOption;
            Console.WriteLine(selectedOption.Text);

        }

        [Test]
        public void WebUITest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();

            //IWebElement loginLink = driver.FindElement(By.Id("loginLink"));
            IWebElement loginLink = driver.FindElement(By.LinkText("Login"));
            loginLink.Click();

            var txtUsername = driver.FindElement(By.Name("UserName"));
            txtUsername.SendKeys("admin");

            var txtPassword = driver.FindElement(By.Id("Password"));
            txtPassword.SendKeys("Password");

            //var submitLogin = driver.FindElement(By.CssSelector("btn btn-default"));
            var submitLogin = driver.FindElement(By.ClassName("btn"));
            submitLogin.Submit();

        }

        [Test]
        public void WebLogin()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://propertynovel.com/Home/Login");

            driver.Manage().Window.Maximize();

            IWebElement webElement = driver.FindElement(By.Name("Email"));
            webElement.SendKeys("sooo@caledonian.ac.uk");

            IWebElement webElement2 = driver.FindElement(By.Name("password"));
            webElement2.SendKeys("password123");
            webElement2.SendKeys(Keys.Return);
            //Assert.Pass();
        }




    }
}