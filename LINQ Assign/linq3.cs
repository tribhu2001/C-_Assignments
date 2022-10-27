using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace orderApp
{
    public class Order
    {
        public int orderId;
        public string itemName;
        public DateTime date;
        public int quantity;
        public Order(int orderId , string itemName , DateTime date , int quantity)
        {
            this.orderId = orderId;
            this.itemName = itemName;
            this.date = date;
            this.quantity = quantity;
        }
    }

    public class Solution
    {
        public List<Order> listItem;
        public Solution(List<Order> listItem)
        {
            this.listItem = listItem;
        }
        public void show1()
        {
            this.listItem.Sort((a,b) => a.quantity.CompareTo(b.quantity));
            this.listItem.Reverse();

            Console.WriteLine("decreasing order of quantity");
            foreach ( var item in this.listItem)
            {
                Console.WriteLine("\n");
                Console.WriteLine(item.orderId +"\t" + item.itemName + "\t" + item.date + "\t" + item.quantity);
            }
        }
        public void show2()
        {
            this.listItem.Sort((a,b) => a.date.CompareTo(b.date));
            this.listItem.Reverse();
            Console.WriteLine("new order to oldest");
            foreach(var item in this.listItem)
            {
                Console.WriteLine("\n");
                Console.WriteLine(item.orderId +"\t" + item.itemName + "\t" + item.date + "\t" + item.quantity);
            }
        }
    }
    

    public class Display2
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
                var orderId = Convert.ToInt32(Console.ReadLine());
                string itemName = Console.ReadLine();
                DateTime date = DateTime.Parse(Console.ReadLine());
                var quantity = Convert.ToInt32(Console.ReadLine());
                var obj = new Order(orderId,itemName,date,quantity);

                list.Add(obj);

            }
            var sol = new Solution(list);
            sol.show1();
            sol.show2();
        }
    }
}