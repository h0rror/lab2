using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson3
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {sting[]} args
         */
        public static void Main(string[] args)
        {
            // create a new instance of the Person class
            Person tanya = new Person();
            tanya.Name = "Tatiana";
            tanya.Age = 28;
            tanya.SaysHello();
            tanya.ShowAge();

            Console.WriteLine();

            Person tom = new Person("Joe");
            tom.Age = 47;
            tom.SaysHello();
            tom.ShowAge();

            Console.WriteLine();

            Person mark = new Person(30);
            mark.Name = "Morpheus";
            mark.SaysHello();
            mark.ShowAge();

            Console.WriteLine();

            Person mary = new Person("Marie", 23);
            mary.SaysHello();
            mary.ShowAge();


        }
    }

}