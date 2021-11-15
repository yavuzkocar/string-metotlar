using System;

namespace string_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           string degisken ="dersimiz CSharp, Hosgeldiniz!";
           string degisken2 = "CSharp";

           //length;
           Console.WriteLine(degisken.Length);

           //ToUpper , ToLower
           Console.WriteLine(degisken.ToUpper());
           Console.WriteLine(degisken.ToLower());

           //concat
           Console.WriteLine(string.Concat(degisken," merhaba!"));

           //compare, compareTo

           Console.WriteLine(degisken.CompareTo(degisken2)); //1, 0, -1 olarak geri dönücek
           Console.WriteLine(string.Compare(degisken,degisken2,true));
           Console.WriteLine(string.Compare(degisken,degisken2,true));

           //Ccontains
           Console.WriteLine(degisken.Contains(degisken2));
           Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("merhabalar"));

            //indexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("yavuz"));

            //insert
            Console.WriteLine(degisken.Insert(0,"merhaba! "));
           
            //lastindexof
            Console.WriteLine(degisken.LastIndexOf("i")); // son i kaçıncı sırada ise onu söyler.
            //Padleft, padRight;
            Console.WriteLine(degisken + degisken2.PadRight(30));
            Console.WriteLine(degisken + degisken2.PadRight(30,'*'));
            Console.WriteLine(degisken.PadLeft(50) + degisken2);
            Console.WriteLine(degisken.PadLeft(50,'-') + degisken2);

            //REMOVE
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));
            
            //replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring

            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
            



        }  

    }
}
