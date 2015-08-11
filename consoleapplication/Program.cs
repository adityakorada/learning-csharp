using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication {
    class Program {
        static void Main(string[] args) {
            //https://github.com/engiacad/learning-csharp
            // Win 8
            //.NET 4.5
            //VS 2013  - Update 4 Ultimate
            // what exactly is a program ?

            // data <--> logic

            //data 
                // variables
                   // native
                        // stored in Stack in the memory 
                        //not sarter, faster
                        // int - 4bytes
                        // bool - 2 bytes

                   // object / user defined types
                        // stored in Heap in the memory 
                        // smrter - slower
                        // collec, array : 4* number of items
                        // inheritance - type is not secified
                // constants

            //variables :
            // Life cycle of the varable ..
            
            //declare
                //type **
                // name / indetifier **
                // prevalue --
            //use
            //dispose

            //int count = 10;
            //count = 190;

            //int anotherCount = 11;
            //anotherCount = 189;

            //string name = "niranjan awati";
            //name = "jsdkldfjklsdjfdsjf";

            //char sym = '@';

            //float precision = 10.89f;
            //double accuracy = 190.9023435345;

            //bool flag = true;

            //List<int> counts = new List<int>() { 10, 19, 20 };
            //counts.Add(30);
            //count = counts[1];

            DoThis("this is the passed message from the main function");//call for the function
            DoThisAsWell("", 0);
      }

        //implementation of the function
        
        static void DoThis(string mesage) {
            Console.WriteLine(mesage);
            Console.ReadLine();
        }
        static void DoThisAsWell(string message, int count) { 
            
        }
    }
}
