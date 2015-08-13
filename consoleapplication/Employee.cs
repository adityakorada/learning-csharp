using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication {

    public class Animal {
        
    }

    /// <summary>
    /// this is referred to as the base class
    /// </summary>
    public  class Employee {
        //DESIGN principles - SOLID

        //s: single responsiblity
        //o: open closed principle
        //l: liskov subsitution
        //i: interface based design
        //d: dependency injection

        
        private string role;
        private int age;

        protected double crrRating;

       
        //c`tor
        public Employee() {
            this.name = "no name as yet";
            this.role = "no role as yet";
            this.age = 18;
        }
        public Employee(int defaultAge) {
           
            this.role = "no role as yet";
            this.age = defaultAge;
        }
        public virtual void Ping() {
            Console.WriteLine("this is Hi from inside the Employee object");
            Console.ReadLine();
        }
        public int Age {
            get { return this.age; }
            set {
                if (value > 0 && value < 75) {
                    this.age = value;
                }
            }
        }
        public string Name { get; set; }

        public string Location { get; set; }

      
    }

    public interface IRegister {

        //abstract function signature .. 
        void Register();
        void UnRegister();
    }

    public interface IRender {
        void Draw();
    }

    /// <summary>
    /// is the child of employee
    /// </summary>
    public class Manager : Employee, IRegister, IRender {
        public string Role { get; set; }

        public override void Ping() {
            Console.WriteLine("this is Hi from the inside the Manager object");
            Console.ReadLine();
        }

        void IRegister.Register() {
            Console.WriteLine("we are now registering the manager");
        }

        void IRegister.UnRegister() {
            Console.WriteLine("we are now un-registring the manager");
        }
    }

    /// <summary>
    /// this is the child of employee
    /// </summary>
    public class Executive :Employee, IRegister {
        public float VaraibleSalaryComponent { get; set; }

        public override void Ping() {
            Console.WriteLine("this is hi from inside the executive object");
            base.Ping();
            base.crrRating = 2.5;

            
        }

        void IRegister.Register() {
            Console.WriteLine("we are now registering the executive");
        }

        void IRegister.UnRegister() {
            Console.WriteLine("we are now un-registering the executive");
        }
    }
}
