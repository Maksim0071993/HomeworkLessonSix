using System;
using System.Collections.Generic;

namespace LessonSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Stack<int> numbers = new Stack<int>();
            numbers.Push(r.Next(0,15));
            numbers.Push(r.Next(0, 15));
            numbers.Push(r.Next(0, 15));

            Console.WriteLine(numbers.Pop());
            Console.WriteLine(numbers.Peek());


            Queue<string> words = new Queue<string>();
            words.Enqueue("fvdsfw");
            words.Enqueue("alx");
            words.Enqueue("pfew");

            Console.WriteLine(words.Dequeue());
            Console.WriteLine(words.Count);
            Console.WriteLine(words.Peek());

            Dictionary<string, long> phonebook = new Dictionary<string, long>();
            phonebook.Add("Alex", 375291112233);
            phonebook.Add("Julia", 375293456789);
            phonebook.Add("Iosif", 375333551602);

            
            try
            {
                long chekValue = Convert.ToInt64(Console.ReadLine());
                string checkKey = Console.ReadLine();
               
                Console.WriteLine(phonebook.ContainsKey(checkKey));
                Console.WriteLine(phonebook.ContainsValue(chekValue));
                phonebook.Remove("Alex");
                             
            }
            catch (Exception)
            {
                Console.WriteLine("ОШИБКА!!!");
            }
            
       

        }
    }
}
