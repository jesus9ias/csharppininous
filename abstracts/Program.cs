using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracts
{
    public abstract class animal
    {
        public string name { get; set; }
        public int feet { get; set; } = 4;

        public virtual string getInfo()
        {
            return name + " has " + feet + " legs";
        }
    }

    public abstract class feline : animal
    {

        public string run()
        {
            return this.name + " is running";
        }
    }

    public abstract class bird : animal
    {
        public int wings { get; set; } = 2;

        public string fly()
        {
            return this.name + " is flying";
        }

        public override string getInfo()
        {
            return name + " has " + feet + " legs " + wings + " and wings";
        }
    }

    public class cat : feline
    {
        public cat(string name)
        {
            this.name = name;
        }

        public string roar()
        {
            return "miew";
        }
    }

    public class worm
    {
        public string eaten(string name)
        {
            return "I'm getting eaten by " + name + ", help me!!";
        }
    }

    public class eagle : bird
    {
        public eagle(string name)
        {
            this.name = name;
            this.feet = 2;
        }

        public string chop()
        {
            return "chop chop";
        }

        public string eat(worm food)
        {
            return food.eaten(name);
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            cat myCat = new cat("Pussy");
            Console.Write(myCat.roar());
            Console.Write("\n" + myCat.run());
            Console.Write("\n" + myCat.getInfo());

            Console.Write("\n\n");

            eagle myBird = new eagle("Condorito");
            Console.Write(myBird.chop());
            Console.Write("\n" + myBird.fly());
            Console.Write("\n" + myBird.getInfo());

            worm worm1 = new worm();

            Console.Write("\n" + myBird.eat(worm1));

            Console.ReadLine();
        }
    }
}
