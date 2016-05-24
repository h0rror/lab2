using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    /**
     * REFER TO http://yui.github.io/yuidoc/syntax/index.html for documentation syntax conventions
     * This class defines a generic Person
     * 
     * @class Person
     * @field _name {string}
     */
    public class Person
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //(underscores signify private variables)  
        //[always add an access modifier likepublic or private to variables]
        private string _name;

        //PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //(no underscore and capitalized first letter to signify public)

        /**
         * This is a property for out _name field
         *
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                return this._name;
            }
           
            set
            {
                this._name = value;

            }
           
        }
        /**
         *This is the default empty constructor for the Person class
         *
         * @constructor Person
         */
        public Person()
        {
            this._name = "unknown name!";

        }
        /**
      *This is a constructor that takes name as a parameter and passes it
      *to the _name private instance variable
      *
      * @constructor Person
      * @param {string} name
      */
        public Person(string name)
        {
            this._name = name;

        }
    }
}
