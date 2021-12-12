using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class CatFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            return new Cat("Kitty");
        }
    }
}
