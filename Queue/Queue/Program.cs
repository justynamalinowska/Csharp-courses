using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stacks;

Queue<int> queue = new Queue<int>();
//adding new element on the end
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
//printing the element at the front of the queue (pierwszy element)
Console.WriteLine("in the front is " + queue.Peek());
//deleting item in the beginning
queue.Dequeue();
Console.WriteLine("in the front is " + queue.Peek());

 while (queue.Count > 0)
{
    queue.Dequeue();
    Console.WriteLine("counted: " + queue.Count);
}

//


Queue<Orders> ordersQueue = new Queue<Orders>();

foreach (Orders o in RecieveOrdersFromBranch1())
{
    //adding them to the queue
    ordersQueue.Enqueue(o);

}

foreach (Orders o in RecieveOrdersFromBranch2())
{
    //adding them to the queue
    ordersQueue.Enqueue(o);

}

while (ordersQueue.Count > 0)
{
    Orders currentOrder = ordersQueue.Dequeue();
    //process the order
    currentOrder.ProcessOrder();
}



Orders[] RecieveOrdersFromBranch1()
{
    //creatitng new orders
    Orders[] orders = new Orders[]
    {
                new Orders(1,5),
                new Orders(2,4),
                new Orders(6,10),
    };
    return orders;
}

Orders[] RecieveOrdersFromBranch2()
{
    //creatitng new orders
    Orders[] orders = new Orders[]
    {
                new Orders(3,3),
                new Orders(4,1),
                new Orders(5,12),
    };
    return orders;
}

namespace Stacks
{
    class Orders
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }


        public Orders(int OrderId, int OrderQuantity)
        {
            this.OrderId = OrderId;
            this.OrderQuantity = OrderQuantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($" Order {OrderId} processed!");
        }


    }

}