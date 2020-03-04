using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');

            p1.Draw();


            Point p2 = new Point(4, 5, '*');

            p2.Draw();

            list<int> numlist = new list<int>();
            numlist.add(0);
            numlist.add(1);
            numlist.add(2);

            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];

            foreach (int i in numlist)
            {
                Console.WriteLine(i);
            }

            numlist.RemuveAt(0);

            list<point> plist = new list<point>();
            plist.Add(p1);
            plist.Add(p2);

            Console.ReadLine ();
             
            
        }
    }   
}

