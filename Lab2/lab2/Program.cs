using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    /**
     * This class is the "driver" class for our program
     * 
     * @class Program
     * */
    public class Program
    {

        /**
         * the main method for out driver class
         * 
         * @method Main
         * @param {string[]} args
         * */
        public static void Main(string[] args)
        {
            Person person; // Person person = new Person(); <--- way to do it in one line

            // create a new instance of the Person class
            person = new Person("Tom");

            Console.WriteLine(person.Name);

            // set a value in the Name property of the Person class
           // person.Name = "Tom";

            // get the Name value and print to console
            Console.WriteLine(person.Name);
            

        }
    }
}
