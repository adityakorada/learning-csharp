﻿using System;
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

            //DoThis("this is the passed message from the main function");//call for the function
            //DoThisAsWell("", 0);

            List<string> left = new List<string>() { "niranjan", "ravi", "amarendra", "junaid" };
            List<string> right = new List<string>() { "niranjan"};

            List<string> result =
            leftOuter(left, right);

            foreach (var item in result) {
                Console.WriteLine(item);
            }
            Console.ReadLine();
      }

        //implementation of the function
        
        static void DoThis(string mesage) {
            Console.WriteLine(mesage);
            Console.ReadLine();
        }

        static List<string> leftOuter(List<string> left, List<string> right) { 
            //return all the items in the left list but not in the right
            //can you do this ?

            List<string> result = new List<string>();
            foreach (var item in left) {
                for (int i = 0; i < right.Count; i++) {
                    if (item!=right[i]) {
                        result.Add(item);
                    }
                }
            }
            return result;
        }

        static void DoThisAsWell(string message, int count) { 
            //if i were to write some body ..i would write it here .. 
            bool flag = true;
            bool insideFlag = true;
            int result = 0;

            if (flag) {
                result = 10;
                if (insideFlag) {
                    result = result + 10;
                }
                else {
                    result = result - 5;
                }
            }
            else {
                result = 0;
            }

            result = flag == true ? insideFlag==true? 20:15 : 0;

            List<string> names = new List<string>() { "pune", "mysore", "bangalore", "chandiagrh" };

            List<string> resultList = new List<string>();

            for (int i = 0; i < names.Count; i++) {
                if (names[i].Contains("e")) {
                    resultList.Add(names[i]);
                }
            }
            for (int i = 0; i < resultList.Count; i++){
			    Console.WriteLine(resultList[i]);
			}

            foreach (var item in names) {
                 if (item.Contains("e")) {
                    resultList.Add(item);
                }
            }
        }
    }
}
