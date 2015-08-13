using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication {
    public class Employee {
        //DESIGN principles - SOLID

        //s: single responsiblity
        //o: open closed principle
        //l: liskov subsitution
        //i: interface based design
        //d: dependency injection

        private string name;
        private string role;
        private int age;


        //c`tor
        public Employee() {
            this.name = "no name as yet";
            this.role = "no role as yet";
            this.age = 18;
        }
        public Employee(int defaultAge) {
            this.name = "no name as yet";
            this.role = "no role as yet";
            this.age = defaultAge;
        }
        public void Ping() {

        }
        public int Age {
            get { return this.age; }
            set {
                if (value > 0 && value < 75) {
                    this.age = value;
                }
            }
        }

        public string Location { get; set; }

        public void SetName(string p) {
            //if there is a rogue value that is coming in you can choose not to set
            this.name = p;
        }

        public void SetRole(string p) {
            this.role = p;
        }
    }
}
