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
    class ElementsManager
    {

        


        
        /*returns an element  from the list*/
        public string findElement(ListOfElements listOfElements, string target)
        {
            foreach(WebElement e in listOfElements)
            {
                if (e.path == target || e.name == target)
                    return target;
            }

            return "Element not found";
        }

        public void saveElements(ListOfElements listOfElements)
        {
            //serialize to json begins here
            string json = JsonConvert.SerializeObject(listOfElements, Formatting.Indented);
            File.WriteAllText(@"D:\TestData.json", json);
        }

        /*loads elements from a file*/
        public ListOfElements loadElements() 
        { 
            DirectoryInfo d = new DirectoryInfo(@"D:");
            FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files
            List<string> fileNames = new List<string>();
           
            foreach (FileInfo file in Files)
            {

                fileNames.Add(file.Name);

            }
            ListOfElements listOfElements = new ListOfElements();
            try
            {

                if (Files.Count() > 0)
                {
                    string json = File.ReadAllText(@"D:\TestData.json");
                    listOfElements = JsonConvert.DeserializeObject<ListOfElements>(json);
                    return listOfElements; 

                }
                
            }
            catch (JsonReaderException e) 
            { 
                Console.WriteLine("Error reading JSon: "+e.Message); 
                
            }

            return listOfElements;
        }
    }
}
