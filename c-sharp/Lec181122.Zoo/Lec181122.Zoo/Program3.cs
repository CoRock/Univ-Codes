﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lec181122.Zoo
{
    class Program3
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
            // Program3 => ArrayList
            ArrayList list = new ArrayList();

            list.Add(new Lion("사원"));
            list.Add(new Lion("사투"));
            list.Add(new Lion("사쓰"));

            list.Add(new Rabbit("토일"));
            list.Add(new Rabbit("토이"));
            list.Add(new Rabbit("토삼"));

            list.Add(new Elephant("코돌이"));
            list.Add(new Elephant("코순이"));

            for (int day = 0; day < 10; day++)
            {
                foreach (Animal a in list)
                {
                    a.makeSound();

                    if (a is Lion)
                    {
                        a.eat(2);

                        // type casting
                        Lion x = (Lion)a;
                        x.fart();
                    }
                    else if (a is Rabbit)
                    {
                        a.eat(7);
                        Rabbit x = (Rabbit)a;
                        x.dig();
                    }
                    else if (a is Elephant)
                    {
                        a.eat(100);
                        Elephant x = (Elephant)a;
                        x.shootWater();
                    }
                    // downcasting하기 전에 반드시 해야 하는 것 : RTTi
                    a.sleep();
                }
            }

            foreach (Animal a in list)
            {
                Console.WriteLine(a);
            }
        }
    }
}
