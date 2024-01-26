
### Delegate
- “A delegate is a type that represents references to methods with a
  particular parameter list and return type"
- Passing a Delegate to a Method
  - Replace or extend
    functionality in runtime
  - Receive a callbacks when
    operation completes
- Delegates allow you to
  reference a method and later
  invoke it
- When to use delegates
  - When you need a callback
    Commonly used in the past when performing background work
  - Events
    When a publisher notifies that an event has occurred, every subscriber
    is executed and can act on it
  - Extensibility
    Allow a method to run additional functionality, or replace functionality
    during runtime. Some libraries rely on
    delegates to allow
    functionality to be
    determined by the consumer
- Delegates are a powerful
  language feature
- If processing runs in the
  background, a delegate can
  be used to get updated
  information
- **Multicast Delegates**
- The multicast delegate contains a list of the assigned delegates. When
  the multicast delegate is called, it invokes the delegates in the list, in
  order.
  Only delegates of the same type can be combined
```csharp
delegate Order Buy (Item item, int quantity);

delegate Order Buy (Item item, int quantity);
ProcessedOrder BuyNow (Item item, int quantity) { … }
```

```csharp
OrderProcessor.ProcessCompleted chain = SendConfirmationEmail;
chain += LogOrderProcessCompleted;
chain += UpdateStock;
// Invoke like a method
chain(order);
// Invoke through a method call
chain.Invoke(order);
```

- A `lambda` produces an
  anonymous function.
```csharp
(parameter1, parameter2) =>
{
return parameter1 + parameter2;
};
```
- Use a lambda statement for
  anonymous functions that
  does not return anything
- Removing an anonymous
  function from a multicast
  delegate is not simple
- You should aim to keep
  anonymous functions as
  simple as possible to reduce
  complexity

```csharp
OrderProcessor.OrderInitialized action = bool (order) =>
{
return order.IsReadyForShipment;
};
```
- most of the extension methods of LINQ uses lambda methods
- Generic Delegates

```csharp
delegate void Action<T>(T input);
Action<Order> OrderProcessed;
    
delegate TResult Func<T, TResult>(T input);

Func<Order, bool> func = SendMessageToWarehouse;
Func<Order, bool> func = (order) => order.IsReadyForShipment
```
- delegate is simply a method
reference and has a very small
memory footprint