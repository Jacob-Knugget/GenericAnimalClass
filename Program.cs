using System;
namespace genericAnimal
{
    class Program
    {
        class Animal<T>
        {
            public T data { get; set; }
            public Animal(T data)
            {
                this.data = data;
            }
            public T getAnimal()
            {
                return data;
            }
        }

        public static void Main(string[] args)
        {
            Animal <string> animalName = new Animal <string> ("Horse");
            Animal <string> animalHabitat = new Animal <string> ("Grasslands");
            Animal <Boolean> endangered = new Animal <Boolean> (true);
            Animal <Boolean> extinct = new Animal <Boolean> (false);
            Animal <int> averageLifespan = new Animal <int> (15);

            Console.WriteLine(animalName.getAnimal());
            Console.WriteLine(animalHabitat.getAnimal());
            Console.WriteLine(endangered.getAnimal());
            Console.WriteLine(extinct.getAnimal());
            Console.WriteLine(averageLifespan.getAnimal());
        }
    }
}