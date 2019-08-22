using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181122.Zoo
{
    class Program2
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
            // Collection Object
            // 한 우리에다가 가둔다
            // 이러한 array를 polymorphic container
            Animal[] arr = new Animal[100];
            int n = 0;  // 우리에 동물이 하나도 없다

            arr[n++] = new Lion("사원");
            arr[n++] = new Lion("사투");
            arr[n++] = new Lion("사쓰");

            arr[n++] = new Rabbit("토일");
            arr[n++] = new Rabbit("토이");
            arr[n++] = new Rabbit("토삼");

            arr[n++] = new Elephant("코돌이");
            arr[n++] = new Elephant("코순이");

            // dynamic binding
            // 함수를 호출할 때, 그 레퍼런스의 타입에 의존해서 하는 것이 아니라
            // 그 레퍼런스가 가리키는 객체의 종류에 따라서 알아서 호출되는 제도
            for (int day = 0; day < 10; day++)
            {
                for (int i = 0; i < n; i++)
                {
                    arr[i].makeSound();

                    if (arr[i] is Lion)
                    {
                        arr[i].eat(2);

                        // type casting
                        Lion x = (Lion)arr[i];
                        x.fart();
                    }
                    else if (arr[i] is Rabbit)
                    {
                        arr[i].eat(7);
                        Rabbit x = (Rabbit)arr[i];
                        x.dig();
                    }
                    else if (arr[i] is Elephant)
                    {
                        arr[i].eat(100);
                        Elephant x = (Elephant)arr[i];
                        x.shootWater();
                    }
                    // downcasting하기 전에 반드시 해야 하는 것 : RTTi
                    arr[i].sleep();
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
