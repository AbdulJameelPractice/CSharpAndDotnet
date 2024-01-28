namespace WarehouseManagementSystem.Domain;

public static class OrderExtension
{
    public static void PrintReprot(this Order order)
    {
        Console.WriteLine($"print : your order is ready? {order.IsReadyForShipment}");
    }

    public static bool DoesOrderContain(this Order order, Func<Order, bool> predicate)
    {
        if (predicate(order))
        {
            return order.IsReadyForShipment;
        }

        return false;
    }
}