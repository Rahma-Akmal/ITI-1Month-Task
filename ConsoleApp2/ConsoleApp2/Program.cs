using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LINQtoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var query = SampleData.Books.Count(x => x.Price > 20);
            //Console.WriteLine(query);

            //var query = SampleData.Books.Select(x => new { x.Title, x.Subject, x.Price }).OrderBy(x=>x.Subject.Name).ThenByDescending(x=>x.Price);
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"title= {item.Title},price= {item.Price},subject={item.Subject}");
            //}

            //var query = SampleData.Books.Select(x => new { x.Title, x.Subject });
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"title= {item.Title},subject={item.Subject}");
            //}
            //var query = from sub in SampleData.Subjects
            //            from name in SampleData.Books
            //            where(sub.Name == name.Subject.Name) 
            //            select new {name.Title,sub.Name};
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"title= {item.Title},subject={item.Name}");
            //}
            var query = SampleData.GetBooks();
            

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            //var query = from b in SampleData.Books
            //            group b by (b.Publisher , b.Subject);
            //foreach (var item in query)
            //{
            //    //Console.WriteLine($" publishername : {item.Key.Publisher} ");
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2.Title );
            //    }

            //}

        }
    }
}
