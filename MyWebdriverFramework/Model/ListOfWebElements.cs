using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MyWebdriverFramework.Model
{
    class ListOfWebElements
    {

        public ObservableCollection<WebElement> listOfElements { get; set; }

        /*returns an element  from the list*/
        public string findElement(string target)
        {
            return target;
        }

        public void saveElements()
        {
            //serialize to json begins here
            string json = JsonConvert.SerializeObject(listOfElements, Formatting.Indented);

            Console.WriteLine(json);
        }

        /*loads elements from a file*/
        public void loadElements() 
        { 
            DirectoryInfo d = new DirectoryInfo(@"D:\TestData");
            FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files
            List<string> fileNames = new List<string>();
           
            foreach (FileInfo file in Files)
            {

                fileNames.Add(file.Name);
                
             
            }
            

            ObservableCollection<WebElement> listOfElements = JsonConvert.DeserializeObject<ObservableCollection<WebElement>>(fileNames.First());
        
        }
    }
}
