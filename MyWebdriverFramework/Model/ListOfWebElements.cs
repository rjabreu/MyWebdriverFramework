using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /*loads elements from a file*/
        public void loadElements() 
        { 
        
        
        }
    }
}
