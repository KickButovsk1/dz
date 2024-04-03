using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = File.ReadAllText("pizza.json");
            var product = JsonConvert.DeserializeObject<List<Product>>(data);
            //var first = product.Where(x => x.category_id == 1).ToList();
            //if (first.Count != 0)
            //{
            //  Console.WriteLine("Таких товаров нету");
            //}
            //else
            //{
            //    foreach (var item in first)
            //    {
            //        Console.WriteLine($"id_product: {item.id_product}");
            //        Console.WriteLine($"name_product: {item.name_product}");
            //        Console.WriteLine($"category_id: {item.category_id}");
            //        Console.WriteLine($"description: {item.description}");
            //        Console.WriteLine($"price: {item.price}");
            //        Console.WriteLine($"image: {item.image}");

            //        Console.WriteLine("--------------------------------");
            //    }
            //}

            //var second = product.Select(x => x.name_product).ToList();
            //foreach (var item in second)
            //{
            //    Console.WriteLine(item);
            //}

            //var third = product.Where(x => x.price > 500).ToList();
            //if (third.Count == 0) 
            //{           
            //foreach (var item in third)
            //{
            //Console.WriteLine("Таких товаров нету");
            //}
            //}
            //else
            //{
            //    foreach (var item in third)
            //{
            //    Console.WriteLine($"id_product: {item.id_product}");
            //    Console.WriteLine($"name_product: {item.name_product}");
            //    Console.WriteLine($"category_id: {item.category_id}");
            //    Console.WriteLine($"description: {item.description}");
            //    Console.WriteLine($"price: {item.price}");
            //    Console.WriteLine($"image: {item.image}");

            //    Console.WriteLine("--------------------------------");
            //}

            //var chetire = product.Where(x => x.description.Contains("чеснок")).ToList();
            //if (chetire.Count == 0 ) 
            //{
            //    Console.WriteLine("Таких товаров нету");
            //}
            //else
            //{
            //    foreach ( var item in chetire )
            //    {
            //        Console.WriteLine($"id_product: {item.id_product}");
            //        Console.WriteLine($"name_product: {item.name_product}");
            //        Console.WriteLine($"category_id: {item.category_id}");
            //        Console.WriteLine($"description: {item.description}");
            //        Console.WriteLine($"price: {item.price}");
            //        Console.WriteLine($"image: {item.image}");

            //        Console.WriteLine("--------------------------------");
            //    }
            //}
          

            //var shest = product.Where(x => x.description.Contains("чеснок")).First();
            //Console.WriteLine($"id_product: {shest.id_product}");
            //Console.WriteLine($"name_product: {shest.name_product}");
            //Console.WriteLine($"category_id: {shest.category_id}");
            //Console.WriteLine($"description: {shest.description}");
            //Console.WriteLine($"price: {shest.price}");
            //Console.WriteLine($"image: {shest.image}");

            //Console.WriteLine("--------------------------------");

            //Console.WriteLine("Выбирайте товар");
            //string str = String.Empty;
            //int result = 0;
            //while (str != "закончить выбор")
            //{
            //    str = Console.ReadLine();
            //    try
            //    {
            //        if (str == "закончить выбор")
            //        {
            //            break;
            //        }
            //        var seven = product.Where(x => x.id_product == Convert.ToInt32(str));
            //        foreach (var item in seven)
            //        {
            //            result += item.price;                 
            //        }
            //        Console.WriteLine(result);
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Такого товара нету");
            //    }
            //}

            // НЕ РАБОТАЕТ

            //List<Product> eleven = product.Where(x => x.id_product == 1 ).ToList();
            //List<Product> elevenn = product.Where(x => x.id_product == 2).ToList();
            //List<string> desc = new List<string>();
            //string p = String.Empty;
            //foreach (var item in eleven)
            //{
            //    p += item.description;
            //}
            //for (int i = 0; i < p.Split().Length; i++)
            //{
            //    desc.Add(p.Split()[i]);
            //}
            //string[] result = desc.ToArray();
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine(  );
            //List<string> dess = new List<string>();
            //string str = String.Empty;
            //foreach (var item in elevenn)
            //{
            //    str += item.description;
            //}
            //for (int i = 0; i <str.Split().Length; i++)
            //{
            //    dess.Add(str.Split()[i]);
            //}
            //string[] res = dess.ToArray();
            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //var devyat = from products in eleven.Intersect(elevenn) select product;
            //foreach(var dev in devyat)
            //{
            //    Console.WriteLine(dev);
            //}
            Console.ReadKey();
        }
    }
}
