using System;
using WarehouseManagementSystem.Business;
using WarehouseManagementSystem.Domain;


namespace WarehouseManagementSystem;

public class Program
{
    public static void Main(string[] args)
    {
        OrderProcessor processor = new OrderProcessor();
        processor.ItemProcessedEvent += ProcessorOnItemProcessedEvent;
        processor.ItemProcessedAgain += ProcessorOnItemProcessedAgain;

        var order = new Order()
        {
            IsReadyForShipment = true,
            LineItems = new[] { new Item() { Price = 10.00m }, new Item() { Price = 20.00m } },
        };

        var (orderNumber, items, sum) = order;

        processor.Process(order, OnOrderProcessed, OrderAction);

        order.PrintReprot();

        Console.WriteLine("Tuple- Start: -----------------");
        var groupTuple = processor.ProcessTuple(order);
        (var orderNumberOfreturnTuple, var itesmOfreturnTuple, var sumOfreturnTuple) = processor.ProcessTuple(order);
        Console.WriteLine(orderNumberOfreturnTuple);
        Console.WriteLine(itesmOfreturnTuple);
        Console.WriteLine(sumOfreturnTuple);
        sumOfreturnTuple = 23;
        Console.WriteLine("Tuple End: -----------------");

        Console.WriteLine(groupTuple.OrderNumber);

        var readyToShip = order.DoesOrderContain(p => p.OrderNumber.ToString() == "XDED");
        Console.WriteLine(readyToShip);

        var _orderNumber = order;
        Console.WriteLine(_orderNumber);

        var subSetOrder = new { order.OrderNumber, order.IsReadyForShipment };
        Console.WriteLine("-----------------");
        Console.WriteLine(subSetOrder.OrderNumber);
        Console.WriteLine(subSetOrder.IsReadyForShipment);

        order.LineItems?.Average(item => item.Price);
        // compiler error cannot access event
        // processor.ItemProcessedEvent = null;

        var instance = new { SampleText = "sample text", Total = 100 };

        var secondInstance = new { SampleText = "sample text", Total = 100 };

        Console.WriteLine(instance.SampleText);
        Console.WriteLine(instance.Total);
        Console.WriteLine(instance.Equals(secondInstance));
        Console.WriteLine(instance == secondInstance);
    }

    public void ProcessDictionary(Dictionary<string, int> dictionary)
    {
        foreach (var (orderKey, orderItem) in dictionary)
        {
            Console.WriteLine(orderKey + orderItem.ToString());
        }
    }

    private static void ProcessorOnItemProcessedAgain(object? sender, CustomArgs e)
    {
        Console.WriteLine("Item processed again event");
    }

    private static void ProcessorOnItemProcessedEvent(object? sender, EventArgs e)
    {
        Console.WriteLine("Item processed event");
    }

    private static void OrderAction(Order obj)
    {
        Console.WriteLine("your order is actioned");
    }

    private static void OnOrderProcessed()
    {
        Console.WriteLine("your order is processed");
    }
}