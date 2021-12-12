using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactory
    {
        public IAnimalFactory GetAnimalFactory(string typeOfFactory)
        {
            if(typeOfFactory == "dog")
            {
                return new DogFactory();
            }
            if(typeOfFactory == "cat")
            {
                return new CatFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
