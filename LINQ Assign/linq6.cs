using System;
using System.Collections.Generic;
using System.Linq;


namespace program
{
    delegate List<Order> Showing(List<Order> list);
    public class Item 
    {
        public float price;
        public string name;
        public Item(float price , string name)
        {
            this.price = price;
            this.name = name;
        }
    }

    public class Order
    {
        public int id;
        public Item item;
        public DateTime date;
        public int quantity;
        public Order(int id , Item item , DateTime date , int quantity)
        {
            this.id = id;
            this.item = item;
            this.date = date;
            this.quantity = quantity;
        }
    }

    public class Solution
    {
        public List<Order> lst;
        public Solution(List<Order> lst)
        {
            this.lst = lst;
        }
        Showing show = delegate(List<Order> list)
        {
            list.Sort((a,b) => a.date.CompareTo(b.date));
            list.Reverse();
            return list;
        };
        public void show1()
        {
            this.lst = show(this.lst);
            Console.WriteLine("Here is our Output");
            foreach(var x in this.lst)
            {
                Console.WriteLine(x.id + "\t" + x.item.name + "\t" + x.date + "\t" + x.quantity*x.item.price);
            }
        }
    }
    

    public class mainSol
    {
        public static void Main()
        {
            List<Order> list = new List<Order> ();
            while (true)
            {
                Console.WriteLine("Press e to end and any other char to continue");
                string s = Console.ReadLine();
                if (s == "e"){
                    break;
                }
                Console.WriteLine("Enter Date in the from of ( dd/mm/yyyy )");
                var id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                var price = (float) Convert.ToDouble(Console.ReadLine());
                DateTime date = DateTime.Parse(Console.ReadLine());
                var quantity = Convert.ToInt32(Console.ReadLine());
                var item = new Item(price,name);
                var obj = new Order(id,item,date,quantity);

                list.Add(obj);

            }
            var sol = new Solution(list);
            sol.show1();
        }
    }
}