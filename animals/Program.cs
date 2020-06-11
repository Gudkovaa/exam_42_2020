using System;

namespace animals
{
    class Program
    {
        static void Main(string[] args)
        {
            lion l = new lion("savanna","river");//новый лев и пример его методов
            l.roam();
            l.eat("zebra");
            l.makeNoize();
            l.sleep();

            wolf w = new wolf("forest", "mountain");//новый волк и примеры его методов
            w.roam();
            w.eat("rabbit");
            w.makeNoize();
            w.sleep();

            Console.ReadKey();
        }
    }
    abstract class animals //абстрактный класс животные
    {
        public string location; // поля локация 
        public string boundaries;// и граница???

        public string type;//вид  животного
        public animals(string loc,string bound)//конструктор животного
        {
            location = loc;
            boundaries = bound;
        }
        public void sleep()//метод спать
        {
            Console.WriteLine($"{type} sleeps");//вывод на экран кто спит
        }
        public void roam()//метод странствовать
        {
            Console.WriteLine($"{type} roams in the {location}");//вывод на экран кто бродит
        }
        public abstract void makeNoize(); // абстратный метод создавать шум
        public abstract void eat(string what); // абстрактный метод есть с аргументом - "что" есть
    }
    class lion : animals //класс лев, наследуемый от животного 
    {
        public lion(string location,string boundares):base(location,boundares) //конструктор льва
        {
            type = "Lion";
        } 
        
        public override void makeNoize()//переопределение метода "создавать шум"
        {
            Console.WriteLine("Lion makes noize rrr"); //здесь именно, то что должен делать лев
        }

        public override void eat(string what)//переопределение метода "есть"
        {
            Console.WriteLine($"Lion eats {what}");//лев ест
        }
    }
    class wolf : animals//для волка все так же как и для льва
    {
        public wolf(string location, string boundares):base(location,boundares)
        {
            type = "Wolf";
        }
        public override void makeNoize()
        {
            Console.WriteLine("Woolf makes noize auuu");
        }

        public override void eat(string what)
        {
            Console.WriteLine($"Wolf eats {what}");
        }
    }
}
