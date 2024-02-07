using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raseko_exersize1
{
    class Hooman
    {
        // Define properties of Hooman
        public string name = "Ex Exaple";
        public int age = 30;
        public string gender = "Maaster";

        // Deafult constructor w/o arguments
        //No need to define, will be created automatically
        public Hooman()
        {

        }

        // Constructor with one argument
        public Hooman(string name)
        {
            this.name = name;
        }

        // Constructor with two arguments
        public Hooman(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }

        // Constructor with three arguments
        public Hooman(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        // A method to say something
        public void SayOpinion()
        {
            Console.WriteLine("The Pets are The Maasters.");
        }
    }
    class CatOwner : Hooman
    {
        public new void SayOpinion()
        {
            Console.WriteLine("Cats own You.");
        }
    }
    // sub class inherits parent class via dots
    class DogOwner : Hooman
    {
        public new void SayOpinion()
        {
            Console.WriteLine("Dogs own everything You do.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Create (instantiate) a hooman object from Hooman class
            Hooman owner = new Hooman("Ozzy Ownersson", 35, "Misstress");
            
            // Call the SayOpinion method
            owner.SayOpinion();

            string who = owner.name;

            Console.WriteLine("Said " + who);

            // Create a new catowner object
            CatOwner catOwner = new CatOwner();

            // Use catowners SayOpinion method
            catOwner.SayOpinion();

            DogOwner dogOwner = new DogOwner();
            dogOwner.SayOpinion();

            // Keep the window open until Enter is pressed
            Console.ReadLine();

        }
    }
}
