using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourseOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeCat homeKitty1 = new HomeCat("Loki","Birman","Viktor");
            HomeCat homeKitty2 = new HomeCat("Charlie", "Bengal", "Vasiliy");
            WildCat wildKitty1 = new WildCat("Shadow","Bombay");
            WildCat wildKitty2 = new WildCat("Lola", "Savannah");

            List<Cat> cats = new List<Cat>() {homeKitty1,homeKitty2,wildKitty1,wildKitty2 };

            foreach (Cat c in cats)
            {
                Console.WriteLine(c.Name + " " + c.Breed);
            }
        }
    }
}
