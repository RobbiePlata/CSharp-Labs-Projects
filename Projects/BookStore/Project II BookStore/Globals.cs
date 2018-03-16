// Globals Information Class 
// Contains only a reference to the BookStore class and the instantiation of this class
//     Frank Friedman
//     CIS 3309

//     Created on January 13 by FLF
//     Modified ... January 30, 2017 and February 2, 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_II_BookStore
{
    class Globals
    {

        // NOTE:
        //       Static methods of a class may be called without instantiating the class
        //              They called from the class itself
        //       Static objects or variables may be accessed without creating an instance of the class
        //              that contains them
        //       When you declare a class as static, all its members are automatically static

        // Application classes -- BookStore is accessible throughout all code without passing it as an argument
        public static BookStoreClass BookStore = new BookStoreClass();

    }  // end Globals Class

}
