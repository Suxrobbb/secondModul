namespace _2._5_dars
{
    public class Program
    {

        // Abstract class
        abstract class Animal
        {
            // Abstract method (does not have a body)
            public abstract void animalSound();
            // Regular method
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        // Derived class (inherit from Animal)
        class Dog : Animal
        {
            public override void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The dog says: wov wov");
            }
        }

        
            static void Main(string[] args)
            {
                Dog myPig = new Dog(); // Create a Pig object
                myDog.animalSound();  // Call the abstract method
                myDog.sleep();  // Call the regular method
            }
        }

    }

