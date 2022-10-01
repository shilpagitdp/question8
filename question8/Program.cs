using System.IO;
using System;

namespace question8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name");
            string name = Console.ReadLine();
            string fileName = @"C:\Users\shilpa.devanga\\file1" + name + ".txt";
            try
            {
                StreamWriter sw = File.AppendText(fileName);



                sw.WriteLine("1st line added");
                sw.WriteLine("adding more text");
                sw.WriteLine("again adding text");
                sw.WriteLine("further adding text");
                sw.WriteLine("adding texttttt");
                sw.WriteLine("adding texttttt");
                sw.WriteLine("adding texttttt");
                sw.WriteLine("adding texttttt");
                sw.WriteLine("adding texttttt");
                sw.WriteLine("adding texttttt");
                sw.WriteLine("adding texttttt");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Enter the text you wanna replaced");
            string OldText = Console.ReadLine();
            Console.WriteLine("Enter the text you want in the file");
            string NewText = Console.ReadLine();
            string text = File.ReadAllText(fileName);
            text = text.Replace(OldText, NewText);
            File.WriteAllText(fileName, text);
            Console.ReadKey();
        }
    }
}
