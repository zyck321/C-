using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p=new Program();
            OrderService os = new OrderService();
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                try
                {
                    switch (a)
                    {
                        case 1:
                            os.AddOrder();
                            break;
                        case 2:
                            os.searchatID(1);
                            break;
                        case 3:
                            os.changeatID(2);
                            break;
                    }
                }
                catch (NotExistException e)
                {
                    Console.WriteLine("NOT  FOUND!");
                }
                finally
                {
                    a = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}


class Order
{
    private static int ID = 1;
    private string name;
    private string goods;
    private int quantity;

    public Order(string n,string g,int q) { name = n; goods = g; quantity = q; }
    public int getID() { return ID; }
    public string getname() { return name; }
    public string getgoods() { return goods; }
    public int getquantity() { return quantity; }

    public void setname(string n) { name = n; }
    public void setgoods(string n) { goods = n; }
    public void setquantity(int n) { quantity = n; }
}

class OrderService
{ 
    private List<Order> l;
    public OrderService() { l = new List<Order>(); }

    public void AddOrder()
    {
        string name = Console.ReadLine();
        string goods = Console.ReadLine();
        int quantity = Convert.ToInt32(Console.ReadLine());
        Order order = new Order(name,goods,quantity);
        l.Add(order);

        /////////////////////////////////////////////
    }

    public void deletebyID(int n)
    {
        if (l.RemoveAll(delegate (Order order) { return order.getID().Equals(n); }) == 0)
            throw (new NotExistException("NOT FOUND OBJ!"));
    }

    public void searchatname(string n)
    {
        List<Order> find = l.FindAll(delegate (Order order) { return order.getname().Equals(n); });

        if (find == null)
            throw (new NotExistException("NOT FOUND OBJ!"));

        foreach (Order or in find)
        {
            Console.WriteLine(or.getID() + "  " + or.getname() + "  " + or.getquantity());
        }
    }
    public void searchatgoods(string n)
    {
        List<Order> find = l.FindAll(delegate (Order order) { return order.getgoods().Equals(n); });

        if (find == null)
            throw (new NotExistException("NOT FOUND OBJ!"));

        foreach (Order or in find)
        {
            Console.WriteLine(or.getID() + "  " + or.getname() + "  " + or.getquantity());
        }
    }
    public void searchatID(int n)
    {
        List<Order> find = l.FindAll(delegate (Order order) { return order.getID().Equals(n); });

        if (find == null)
            throw (new NotExistException("NOT FOUND OBJ!"));

        foreach (Order or in find)
        {
            Console.WriteLine(or.getID() + "  " + or.getname() + "  " + or.getquantity());
        }
    }
    public void changeatID(int n)
    {
        Order find = l.Find(delegate (Order order) { return order.getID().Equals(n); });
        if (find == null)
            throw (new NotExistException("NOT FOUND OBJ!"));
        find.setname(Console.ReadLine());
        find.setgoods(Console.ReadLine());
        find.setquantity(Convert.ToInt32(Console.ReadLine()));
    }
}

public class NotExistException: ApplicationException
{
    public NotExistException(string message): base(message)
    {
    }
}

public class OpFailException : ApplicationException
{
    public OpFailException(string message): base(message)
    {
    }
}

