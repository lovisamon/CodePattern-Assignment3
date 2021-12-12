using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på en sträng parameter
        
        public void Run()
        {
            AbstractFactory factory = new();
            IAnimalFactory dogFactory = factory.GetAnimalFactory("dog");
            IAnimalFactory catFactory = factory.GetAnimalFactory("cat");
            IAnimal dog = dogFactory.CreateAnimal();
            IAnimal cat = catFactory.CreateAnimal();
            Console.WriteLine($"The dog's name is {dog.Name}");
            Console.WriteLine($"The cat's name is {cat.Name}");
        }
    }
}
