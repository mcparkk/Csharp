using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cat
    {
        public Cat(int hp)
        {
            HP = hp;
        }
        public int HP;
    }

    struct Snake
    {
        public Snake(int hp)
        {
            HP = hp;

        }
        public int HP;
    }

    class program
    {
        static void Foo(Snake a)        //Struct 사용
        {   // Snake a = s1 가 만들어진거와 같다.
            a.HP = 5;
        }   //{}가 끝나면 값이 사라진다. 

        static void Foo(Cat a)  // overloading. override와는 다르다는. //Class 사용 
        {   // Cat a = c1
            a.HP = 5;
        }   // heap에 생긴 정보가 들어가있다. //뱀은 복제, 고양이는 빌려온것, heap공간에 고양이(c1)의 값은 남아있다. 
            static void Main(string[] args)
        {

            Snake s1 = new Snake(1);
            Foo(s1);
            Console.WriteLine(s1.HP);

            Cat c1 = new Cat(1);
            Foo(c1);
            Console.WriteLine(c1.HP);



        }
    }
}


