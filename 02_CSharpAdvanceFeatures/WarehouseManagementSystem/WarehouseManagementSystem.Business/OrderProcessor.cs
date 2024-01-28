﻿using WarehouseManagementSystem.Domain;

namespace WarehouseManagementSystem.Business
{
    public class OrderProcessor
    {
        public delegate void OnOrderProcessed();

        public event EventHandler ItemProcessedEvent;

        public event EventHandler<CustomArgs> ItemProcessedAgain;

        private void Initialize(Order order)
        {
            Console.WriteLine("trying to initialize order");
        }

        public void Process(Order order, OnOrderProcessed onOrderProcessed, Action<Order> orderAction)
        {
            // Run some code..

            Initialize(order);
            orderAction?.Invoke(order);
            onOrderProcessed?.Invoke();
            // How do I produce a shipping label?
            
            ItemProcessedEvent?.Invoke(this,EventArgs.Empty);
            
            ItemProcessedAgain?.Invoke(this,new CustomArgs());
        }

        public void Process(IEnumerable<Order> orders)
        {
            var summaries = orders.Select(order => new
            {
                Order = order.OrderNumber,
                Items = order.LineItems.Count(),
                Total = order.LineItems.Sum(item => item.Price)
                
            });

            var orderSummaries = summaries.OrderBy(summary => summary.Items);
        }
    }
    
    public class CustomArgs
    {
        public Order order { get; set; }
    }
}