using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CS_Using_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("we're using hashset");

            string[] recentVisitors = new string[]
            {
                "Lorian",
                "Nanoya",
                "Devne",
                "Lorian"
            };
            Console.WriteLine("Length of Array " + recentVisitors.Length);
            Console.WriteLine();
            Console.WriteLine("The Data in Array");
            foreach (var n in recentVisitors)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            HashSet<string> myHSet = new HashSet<string>(recentVisitors);

            Console.WriteLine("Count data HAshset " + myHSet.Count);

            Console.WriteLine();

            Console.WriteLine("in my hashset theres:");
            foreach (var n in myHSet)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

          
            
            //section 3
            string[] names1 = new string[] {
                "Avo",
                "Vilos",
                "Tirkavina",
                "Nicanor"
            };

            string[] names2 = new string[] {
                "Trickster",
                "Nicanor",
                "Tellru",
                "Nobody",
                "Anetanya"
            };
            

            HashSet<string> hSetN1 = new HashSet<string>(names1);
            Console.WriteLine("Data in the names1");
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_______________________________________________________________");
            HashSet<string> hSetN2 = new HashSet<string>(names2);
            Console.WriteLine("Data in names2");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("________________________________________________________________");



            Console.WriteLine("Data when smushed together w union");
            hSetN1.UnionWith(hSetN2);
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }
            

            ///*
            //section 4
            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Data in HashSet before using Except With");
            Console.WriteLine("_________________________________");

            //temporary hashset to avoid modifying the original
            HashSet<string> hSetN3 = new HashSet<string>(names1);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using Except With");
            Console.WriteLine("_________________________________");
            hSetN3.ExceptWith(hSetN2);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }
            //Keeps the elements of the used HSEt except the ones also present in the other one
            //"Nicanor" is now no longer present in hSetN3

            //section 5
            HashSet<string> hSetN4 = new HashSet<string> (names1);

            Console.WriteLine("_________________________________");
            Console.WriteLine("Elements in HashSet before using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            Console.WriteLine("HashSet 1");
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("HashSet 2");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            //keeps all elements from BOTH sets except the doubles
            //essentially a union + exceptwith combination
            hSetN4.SymmetricExceptWith(hSetN2);
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
            //everyone's there except "Nicanor"
            */
            Console.WriteLine("names length: " + names.Length);
            Get_Add_Performance_HashSet_vs_List();
            Get_Contains_Performance_HashSet_vs_List();
            Get_Remove_Performance_HashSet_vs_List();

        }

        static string[] names = new string[] {
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis","Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis","Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis","Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis","Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis","Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis","Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis","Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis","Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis","Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita"
        };

        static void Get_Add_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while Adding Item");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Add(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while Adding Item");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Add(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();


            //In the example, the HashSet is significantly slower than the List, which makes sense
            //since the list can add items without checking, but the Hashset has to
            //check each new item against all other items to avoid duplicates.
            //at first, the list is a LOT slower than the
            //HSet (1.494 ms for the list vs. 0.177 ms for the Hset), which was likely
            //caused by the array being a lot smaller than the example (~200 items);
            //after making the array longer, the numbers looked more reasonable.


        }

        static void Get_Contains_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while checking Contains operation");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Contains(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while checking Contains operation");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Contains(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

            //my results (582 strings in names): 0.031 ms for the List & 0.018 ms for hset
            //the hset is faster since it doesn't contain duplicates & stores data in
            //buckets, meaning it doesn't have to look through every individual item

        }

        static void Get_Remove_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while performing Remove item operation");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Remove(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while performing Remove item operation");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Remove(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

            //like for the Contains operation, the Remove operation goes through each
            //individual list item, but in HashSets it navigates the buckets & so
            //finds the specified element much quicker.
        }
    }
}

