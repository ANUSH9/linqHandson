using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace linqHandson
{
    public class Students
    {

        public int StuId { get; set; }
        public string StuName { get; set; }
        public int GrPoint { get; set; }
        public void handson1()
        {
            int[] n1 = new int[] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var a = from x in n1 where x > 0 where x < 20 select x;
            foreach (var x in a)
            {
                Console.WriteLine(x);
            }





        }
        public void handson2()
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var c = from d in arr1 group d by d into m select m;
            foreach (var n in c)
            {
                Console.WriteLine("Number");
                Console.WriteLine(n.Key);
                Console.WriteLine("appears ");
                Console.WriteLine(n.Count());
                Console.WriteLine("Times");


            }
        }
        public void handson3()
        {
            string a = "apple";
            char[] b = a.ToCharArray();

            var c = from d in b group d by d into m select m;
            foreach (var n in c)
            {
                Console.WriteLine("Character");
                Console.WriteLine(n.Key);
                Console.WriteLine(n.Count());
                Console.WriteLine("Times");


            }
        }
        public void handson4(string start, string end)
        {

            string[] m = new string[]{ "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
                    "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            

            var name = from x in m where x.StartsWith(start) && x.EndsWith(end)select x;
            Console.Write(start, end);
            foreach(var n in name)
            {
                Console.WriteLine(n);
            }
        }
        public void handson5(int a)
        {
            int[] number = new int[] { 5, 7, 13, 24, 6, 9, 8, 7 };
            var x = number.OrderByDescending(n => n).Take(a);
            Console.WriteLine(a);
            foreach (var m in x)
            {
                Console.WriteLine(m);
            }


        }
        public void handson6(int n)
        {
            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });
            var m = (from stu in stulist orderby stu.GrPoint descending group stu by stu.GrPoint into student select student).Take(n).Reverse().Take(0);
            foreach (var r in m)
            {
               

                foreach (var student in r)
                {
                    Console.WriteLine(student.StuId + " " + student.StuName + " " + student.GrPoint);
                }

            }


        }
        public void handson789(string latter)
        {
            var people = new List<Person>()
        {
            new Person("Bill", "Smith", 41),
            new Person("Sarah", "Jones", 22),
            new Person("Stacy","Baker", 21),
            new Person("Vivianne","Dexter", 19 ),
            new Person("Bob","Smith", 49 ),
            new Person("Brett","Baker", 51 ),
            new Person("Mark","Parker", 19),
            new Person("Alice","Thompson", 18),
            new Person("Evelyn","Thompson", 58 ),
            new Person("Mort","Martin", 58),
            new Person("Eugene","DeLauter", 84 ),
            new Person("Gail","Dawson", 19 ),

        };
            Console.Write("people with last name that starts with the letter ");
            String s = Console.ReadLine();
            var res = (from a in people
                       where a.Lname.StartsWith(s)
                       select a.Lname).ToList();
            foreach (var resultitem in res)
            {
                Console.WriteLine(resultitem);
            }

            
            Console.WriteLine($"Number of people whose name startswith {s} are: {res.Count()}");

           
            var resdescName = (from a in people
                               where a.Age > 40
                               orderby a.Fname descending
                               select a.Fname).ToList();


            foreach (var f in resdescName)
            {
                Console.Write(f);
            }


        }
        public void handson10(string start)
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", 
                "Lime", "Watermelon", "Loganberry" };
            var name = from x in fruits where x.StartsWith(start)  select x;
            Console.Write(start);
            foreach (var n in name)
            {
                Console.WriteLine(n);
            }

        }
        public void handson11()
        {
            List<int> mixedNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var multiple_of_4_6 = mixedNumbers.Where(multiple => multiple % 4 == 0 || multiple % 6 == 0).Select(multiple => multiple);
            foreach (var number in multiple_of_4_6)
            {
                Console.WriteLine(number);
            }
        }
    }
}
