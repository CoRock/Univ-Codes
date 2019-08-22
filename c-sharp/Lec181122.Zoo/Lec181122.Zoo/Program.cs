using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. sleep(): 함수의 이름이 같으면서 하는 일도 같은 경우
// 2. makeSound(): 함수의 이름이 같지만 하는 일이 다른 경우
namespace Lec181122.Zoo
{
    class Program
    {
        // 추상 클래스의 가장 큰 특징은 인스턴시에이션을 할 수 없다.
        abstract class Animal : Object
        {
            protected String name;
            protected int weight;

            public Animal(String name)
            {
                this.name = name;
                weight = 0;
            }

            public void sleep()
            {
                Console.WriteLine("zzz...");
            }

            // 추상 클래스: 함수의 존재감만 나타내기 위함
            public abstract void makeSound();

            public virtual void eat(int x)
            {
                weight += x;
            }

            public override string ToString()
            {
                return null;
            }
        }   // end of class Animal

        class Lion : Animal
        {
            protected String name;
            protected int weight;
            protected int meat;

            public Lion(String name)
                : base(name)    // call a constructor of base class
            {
                // this.name = name;
                this.weight = 10;
                meat = 0;
            }

            public override void makeSound()
            {
                Console.WriteLine("으르렁~~~");
            }

            public override void eat(int pig)
            {
                meat += pig;

                // weight += (pig * 3);
                base.eat(pig * 3);
            }

            public void fart()
            {
                Console.WriteLine("뿌우우웅");
                weight -= 1;
            }

            public override string ToString()
            {
                String s = "";
                s = s + name + " " + "weight: " + weight;
                s = s + "돼지 수: " + meat;
                return s;
            }
        }   // end of class Lion

        class Rabbit : Animal
        {
            int carrot;

            public Rabbit(String name)
            {

            }

            public override void makeSound()
            {
                Console.WriteLine("으르렁~~~");
            }

            public override void eat(int c)
            {
                carrot += c;
                base.eat(c);
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }   // end of class Rabbit

        class Elephant : Animal
        {
            int banana;

            public Elephant(String name)
                : base(name)
            {
                weight = 100;
                banana = 0;
            }

            public void makeSound()
            {
                Console.WriteLine("뿌우~~~");
            }

            public override void eat(int b)
            {
                banana = banana + b;
                base.eat(b * 2);
            }
        }   // end of class Elephant

        static void Main(string[] args)
        {
            Lion x = new Lion("사원");
            Lion y = new Lion("사투");
            Lion z = new Lion("사쓰");

            Rabbit a = new Rabbit("토일");
            Rabbit b = new Rabbit("토이");
            Rabbit c = new Rabbit("토삼");

            Elephant p = new Elephant("코돌이");
            Elephant q = new Elephant("코순이");
            
            x.sleep();

            for (int i = 0; i < 10; i++)
            {
                x.makeSound();
                x.eat(2);
                x.fart();
                x.sleep();

                y.makeSound();
                y.eat(5);
                y.fart();
                y.sleep();

                z.makeSound();
                z.eat(3);
                z.fart();
                z.sleep();
            }

            c.makeSound();
            c.eat(5);
            c.dig();
            c.sleep();


            p.makeSound();

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(p);
            Console.WriteLine(q);
        }
    }
}
