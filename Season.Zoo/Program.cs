using System;
using System.Collections.Generic;
using System.Linq;
using Season.Zoo.Enums;
using Season.Zoo.Exceptions;

namespace Season.Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("oi!");
            
            // Animal toto = new Animal();
            // toto.Name = "Totó";   
            // toto.Height = 3.0m;        
            // //toto.Born();

            // Animal[] animals = new Animal [3];

            // animals[0] = new Animal();
            // animals[0].Name = "Manu";
            // animals[0].Color = "Branco";
            // animals[0].Height = 0.3m;
            // //Console.WriteLine(animals[0].Name);

            // animals[1] = new Animal();
            // animals[1].Name = "Tuca";
            // animals[1].Color = "Preta";
            // animals[1].Height = 0.15m;
            // //Console.WriteLine(animals[1].Name);
            
            // animals[2] = new Animal();
            // animals[2].Name = "Cappuccino";
            // animals[2].Color = "Caramelo";
            // animals[2].Height = 0.5m;
            // //Console.WriteLine(animals[2].Name);


            // for(int i = 0; i < animals.Length; i++)
            // {
            //     Console.WriteLine(animals[i].Name);
            // }

            //LinkedList<Animal> animals = new LinkedList<Animal>(10);

            // List<Animal> animals = new List<Animal>(10);
            // animals.Add(new Animal
            // {
            //     Name = "Manu",
            //     Height = 0.15m
            // });
            // animals.Add(new Animal
            // {
            //     Name = "Cappuccino",
            //     Height = 0.4m
            // });
            // animals.Add(new Animal
            // {
            //     Name = "Mike",
            //     Height = 0.5m
            // });

            // for (int i = 0; i < animals.Count; i++)
            // {
            //     Console.WriteLine(animals[i].Name);
            // }

            // foreach(Animal a in animals)
            // {
            //     Console.WriteLine(a.Name);
            // }
            // //LINQ
            // animals.ForEach((a) =>
            // {
            //     Console.WriteLine(a.Name);
            // });

            // // decimal totalHeight = 0;
            // // foreach (Animal a in animals)
            // // {
            // //     totalHeight += a.Height;
            // // }
            // decimal totalHeight = animals.Average(a => a.Height);
            // List<Animal> bigAnimals = animals.Where(a => a.Height > 0.2m).ToList();
            // Console.WriteLine(totalHeight);
            // bigAnimals.ForEach(a =>
            // {
            //     Console.WriteLine(a.Name);
            // });
            // //Projeção
            // animals
            //     .Select(a => new { Name = a.Name, Height = a.Height})
            //     .ToList()
            //     .ForEach(a => 
            //     {
            //         Console.WriteLine(a.Name);
            //     });
            // // Inferencia 
            // var list = animals
            //     .Select(a => new { Name = a.Name, Height = a.Height});
            // foreach(var whatever in list) 
            // {
            //     Console.WriteLine(whatever.Name);
            // } 

            try
            {
                //Animal toto = new Animal();
                Animal toto = new Cat();
                toto.Name = "Totó";
                toto.Born();
                Console.WriteLine(toto.Speak());
                //toto.Die();
                toto.Die();
                Console.WriteLine(toto.Speak());
                toto.Color = Colors.Write;
            }
            catch(DeadAnimalException ex)
            {
                Console.WriteLine($"Morreu: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Deu erro: {ex.Message}. Entre em contato com o suporte.");
            }
            finally
            {
                Console.WriteLine("Tchau!");
            }
        }
    }
}
