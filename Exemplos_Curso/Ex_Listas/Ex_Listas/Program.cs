namespace Ex_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Goku");
            list.Add("Zero Two");
            list.Add("Killua");
            list.Add("Shisui");
            list.Add("Zoro");
            list.Insert(2, "Luffy");
            list.Insert(3,"Sasuke");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(Test);
            Console.WriteLine("First Z = " + s1);

            string s2 = list.Find(x => x[0] == 'S');
            Console.WriteLine($"First S = {s2}");

            string s3 = list.FindLast(x => x[0] == 'S');
            Console.WriteLine($"Last S = {s3}");

            int pos1 = list.FindIndex(x => x[0] == 'S');
            Console.WriteLine($"First position S = {pos1}");

            int pos2 = list.FindLastIndex(x => x[0] == 'S');
            Console.WriteLine($"Last position S = {pos2}");

            List<string> list2 = list.FindAll(x => x.Length == 6);

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            list.Remove("Shisui");

            Console.WriteLine("*************************************");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAll(x => x[0] == 'S');

            Console.WriteLine("*************************************");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            list.RemoveAt(3);

            Console.WriteLine("*************************************");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveRange(1,2);

            Console.WriteLine("*************************************");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


        }

        static bool Test(string s)
        {
            return s[0] == 'Z';
        }
    }
}
