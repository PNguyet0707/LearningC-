using System;

namespace MyApplication
{
    // Abstract class
    abstract class Animal
    {
        // field name
        string name;
        // constructor 
        public Animal()
        {
            name = "Peppa";

        }
        //property Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzzzzzz");
        }
       

    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        // override method inherited from base abstract class 
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
            myPig.sleep();
            // abstract class has constructor and derived class inherited it 
           // myPig.Name = "Pn";
            Console.WriteLine(myPig.Name);
        }
    }
}