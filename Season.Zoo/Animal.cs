using System;
using Season.Zoo.Enums;
using Season.Zoo.Exceptions;

namespace Season.Zoo
{

    abstract class Animal : IAnimal
    {
        //Características (Atributos):
        //Nome, Tamanho, Altura, Cor
        //Ações (Métodos):
        //Nascer, Comer, Crescer, Morrer, Dormir

        //#MomentoJava
        // public bool Alive 
        // { 
        //     get
        //     {
        //         return Alive;
        //     } 
        // }

        //Expression-bodier elements
        //public bool Alive => Alive;

        public bool Alive {get; private set;}
        public string Name { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public Colors Color { get; set; }

        public void Born()
        {
            Alive = true;
            Console.WriteLine($"O {Name} nasceu!");
        } 

        public void Die()
        {
            if(Alive)
            {
                Alive = false;
                Console.WriteLine($"O {Name} morreu :(");
            }
            else
            {
                throw new DeadAnimalException($"O {Name} já esta morto!");
            }
        }

        //Template Method
        public string Speak()
        {
            if(Alive)
            {
                return DoSpeak();
            }
            throw new DeadAnimalException($"O {Name} não pode fazer barulho porque morreu :(");

        }
        //abstract obriga as classes herdadas a implementar
        protected abstract string DoSpeak();

        public void Run()
        {
            Console.WriteLine($"o {Name} andou!");
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (Object.ReferenceEquals(obj, this))
            {
               return true;     
            }
            if(obj is Animal)
            {
                Animal animal2 = obj as Animal;
                return  this.Name == animal2.Name && 
                        this.Color == animal2.Color &&
                        this.Height == animal2.Height &&
                        this.Weight == animal2.Weight;
            }
            else
            {
                return false;
            }

        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            int hash = 17;
            return  (this.Name.GetHashCode() * hash) +
                    (this.Color.GetHashCode() * hash) +
                    (this.Height.GetHashCode() * hash) +
                    (this.Weight.GetHashCode() * hash);
        }


        public override string ToString()
        {
            return $"[Name = {this.Name}; Color = {this.Color}]";
        }

    }
}