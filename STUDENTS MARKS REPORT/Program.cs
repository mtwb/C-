using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace STUDENTS_MARKS_REPORT
{
    class Program
    {
        static double mark1;
        static double mark2;
        static double mark3;
        static double mark4;
        static double mark5;

        static double avg = 0;

        static public void AvgCount()
        {
            avg = (mark1 + mark2 + mark3 + mark4 + mark5) / 5;
        }

        static public int NWD(int a, int b, bool test)
        {
            if (!test)
            {
                Console.Write("Podaj a: ");
                a = Int32.Parse(Console.ReadLine());
                Console.Write("Podaj b: ");
                b = Int32.Parse(Console.ReadLine());
            }

            // Wykonuj dopóki a jest różne b
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            Console.WriteLine("Największy wspólny dzielnik (NWD) to: " + a);
            return a;
        }

        static void Main(string[] args)
        {
            //test
            CorrectAvgCount();
            CheckNWD();

            string name;
            int numStudents = -1;

            Console.WriteLine("Student MarkList Application");
            Console.Write("Enter the Total number  of students: ");

            string s = Console.ReadLine();
            numStudents = Convert.ToInt32(s);

            for(int i =0; i<numStudents;i++)
            {
                Console.Write("Student Name: ");
                name = Console.ReadLine();

                Console.Write("Sub 1 Mark: ");
                mark1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Sub 2 Mark: ");
                mark2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Sub 3 Mark: ");
                mark3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Sub 4 Mark: ");
                mark4 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Sub 5 Mark: ");
                mark5 = Convert.ToDouble(Console.ReadLine());

                AvgCount();

                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("SNo Student Name        ENG   MATH   PHY    CHE    BIO     AVG");
                Console.WriteLine("_______________________________________________________________");

                Console.Write("{0, -5}", i + 1);
                Console.Write("{0, -19}", name);
                Console.Write("{0, -7}", mark1);
                Console.Write("{0, -7}", mark2);
                Console.Write("{0, -7}", mark3);
                Console.Write("{0, -7}", mark4);
                Console.Write("{0, -7}", mark5);
                Console.Write("{0, -7}\n", avg);
            }

            Console.WriteLine("A teraz policzymy NWD dla liczb\n");
            NWD(0, 0, false);

            char ch = Console.ReadKey().KeyChar;
        }

        //TESTY

        //poprawnie liczona srednia
        public static void CorrectAvgCount()
        {
            mark1 = 1;
            mark2 = 1;
            mark3 = 1;
            mark4 = 1;
            mark5 = 1;

            AvgCount();

            if (avg == 1)
                Console.WriteLine("Test pierwszy na poprawnosc liczenia sredniej przeszedl poprawnie");
            else
                Console.WriteLine("Test pierwszy na poprawnosc liczenia sredniej przeszedl błednie");

            mark1 = 1;
            mark2 = 2;
            mark3 = 3;
            mark4 = 4;
            mark5 = 5;

            AvgCount();

            if (avg == 3)
                Console.WriteLine("Test drugi na poprawnosc liczenia sredniej przeszedl poprawnie\n");
            else
                Console.WriteLine("Test drugi na poprawnosc liczenia sredniej przeszedl błednie\n");
        }

        //sprawdzanie poprawnosci liczenia NWD
        public static void CheckNWD()
        {
            if (NWD(1, 1, true) == 1)
                Console.WriteLine("Test pierwszy na poprawnosc liczenia NWD przeszedl poprawnie\n");
            else
                Console.WriteLine("Test pierwszy na poprawnosc liczenia NWD przeszedl błednie\n");

            if (NWD(1024, 31752, true) == 8)
                Console.WriteLine("Test drugi na poprawnosc liczenia NWD przeszedl poprawnie\n");
            else
                Console.WriteLine("Test drugi na poprawnosc liczenia NWD przeszedl błednie\n");
        }
    }

}

