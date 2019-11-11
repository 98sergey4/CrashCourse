using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourseOOP
{
    interface IPlayable
    {
        void play();
        
    }
    internal abstract class Cat
    {
        private string name;
        private string breed;

        public string Name 
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Breed 
        {
            get
            {
                return breed;
            }

            set
            {
                breed = value;
            }
        }
    }

    internal class HomeCat : Cat, IPlayable
    {
        private string master;

        public string Master 
        {
            get
            {
                return master;
            }

            set
            {
                master = value;
            }
        }

        public HomeCat(string name, string breed, string mstr)
        {
            Name = name;
            Breed = breed;
            Master = mstr;
        }

        public void layOnSofa()
        {
            Console.WriteLine("Mhr-mhr-mhr");
        }
        public void spoilShoes()
        {
            Console.WriteLine("Spoiled!");
        }

        public void play()
        {
            Console.WriteLine("Playing with thread ball...");
        }
    }

    internal class WildCat : Cat, IPlayable
    {
        public WildCat(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }
        public void hatePeople()
        {
            Console.WriteLine("Mew-mew, madafaka!");
        }
        public void play()
        {
            Console.WriteLine("Hunting for man...");
        }
    }
}
