using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IContructor
{
    
        // Interface
        interface IAnimal
        {
            string Name
            {
                get;
                set;
            }

            void animalSound(); // interface method (does not have a body)
        }

        // Pig "implements" the IAnimal interface
        class Pig : IAnimal
        {
            private string _name { get; set; }
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                IAnimal myPig = new Pig();  // Create a Pig object
                myPig.animalSound();
                myPig.Name = "Peppa";
                Console.WriteLine(myPig.Name);
            }
        }
    
}
