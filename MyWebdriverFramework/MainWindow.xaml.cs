using MyWebdriverFramework.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyWebdriverFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        [TestFixture]
        class CreateEmailECM
        {

            IWebDriver driver;
            public ListOfWebElements listOfElements = new ListOfWebElements();

            [SetUp]
            public void Setup()
            {
                // Create a new instance of the Chrome driver
                driver = new ChromeDriver(@"C:\");
                // driver = new FirefoxDriver();
            }

            [TearDown]
            public void Teardown()
            {
                driver.Quit();
            }

            [Test]
            public void CreateEmail()
            {

                

                

                


                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
                //navigate to 
                driver.Navigate().GoToUrl("");


                

                StreamReader reader = new StreamReader("TestFile.txt");

            }


            public void Click(String element)
            {
                driver.FindElement(By.XPath(element)).Click();

            }

            public void sendKeys(String element, String input)
            {
                driver.FindElement(By.XPath(element)).SendKeys(input);
            }


            public void waitSeconds(int time)
            {
                Thread.Sleep(TimeSpan.FromSeconds(time));

            }

        }

       
    }
}

