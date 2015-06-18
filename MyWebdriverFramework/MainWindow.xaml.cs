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
using System.Xaml;


namespace MyWebdriverFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListOfElements lstElements = new ListOfElements();
        ElementsManager eManager = new ElementsManager();
        enum actions
        {
            click = 1,
            sendkeys = 2

        };
        

        public MainWindow()
        {
            InitializeComponent();

            lstElements = eManager.loadElements();
            listActionsBox.ItemsSource = Enum.GetValues(typeof(actions));
            pathListBox.DataContext = lstElements;

           
        }



        [TestFixture]
        class CreateEmailECM
        {

            IWebDriver driver;
            public ElementsManager listOfElements = new ElementsManager();

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

        private void saveElement_Click(object sender, RoutedEventArgs e)
        {
           
            WebElement el = new WebElement();

             foreach(WebElement element in lstElements)
             {
                 if (element.name == intputElementName.Text)
                     logBox.Text = "Name already exists. Please choose a unique name for each element.";
             }

             el.name = intputElementName.Text;
            el.path = inputElementPath.Text;
            lstElements.Add(el);
            eManager.saveElements(lstElements);
        }

        

        private void addAction_Click(object sender, RoutedEventArgs e)
        {
            actions a;
            Enum.TryParse<actions>(listActionsBox.SelectedValue.ToString(), out a); 
        }

       
    }
}

