using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials1.CovariancesContravariances.Covariances.Fruits
{
    public class ShowFruit
    {
        public static void Run()
        {
            Console.WriteLine($"First fruits - ");
            Console.WriteLine();

            var fruits = new[]
            {
                new Fruit(name: "Banana"),
                new Fruit(name: "Apple"),
                new Fruit(name: "Tomato"),
            };
            
            ShowFruits(fruits);


            Console.WriteLine($"Second fruits");
            Console.WriteLine();

            var fruits2 = new[]
            {
                new Banana(typeBanana: "Manzano"),          //Banana Maçã
                new Banana(typeBanana: "Chunkey"),          //Banana Prata
                new Banana(typeBanana: "Yellow Cavendish"), //Nanica
            };

            ShowFruits(fruits2);
        }

        public static void ShowFruits(IEnumerable<Fruit> fruits)
        {
            foreach (var fruit in fruits)
            {
                Console.WriteLine($"The fruit is: {fruit.Name}");
            }
        }
    }
}
