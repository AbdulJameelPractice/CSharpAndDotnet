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
            IsReadyForShipment = true
        };
        processor.Process(order, OnOrderProcessed, OrderAction);

        order.PrintReprot();

        var readyToShip = order.DoesOrderContain(p => p.OrderNumber.ToString() == "XDED");
        Console.WriteLine(readyToShip);
        
        var subSetOrder = new {order.OrderNumber, order.IsReadyForShipment};
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