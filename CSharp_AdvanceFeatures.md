- [Delegate](#delegate)
- [Extension Methods](#extension-methods)
- [Anonymous Types](#anonymous-types)
- [Tuples](#tuples)
- [DeConstructor](#deconstructor)
- [Records](#records)


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
- A delegate is simply a method
  reference and has a very small
  memory footprint
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
    
void Process(OrderInitialized onInitialized)
    
// Func and Action in the method. 
void Process(Func<Order, bool> onInitialized,
Action callback)
{
var result = onInitialized?.Invoke();
callback?.Invoke();
}
{ ... }

Process(SendMessageToWarehouse);

Process(order => order.IsReadyForShipment);    
```
- delegate is simply a method
reference and has a very small
memory footprint
- Lambda Makes the code easier to read. The logic is defined in-place and the intent is clearly
  communicated. Can capture local variables
- **Event**
- The event keyword is used to declare an event in a publisher class.
- Publisher
  The class that owns the event
  and is in charge of raising it
- Subscriber
  The classes that subscribe to
  events exposed by the publisher
- An event delegate is always
  void and an event never
  returns a value
- When you add the `event`
  keyword before a delegate, it
  `can only be invoked from that
  class only`
- The publisher should never
  care about what the
  subscriber does when the
  event is raised
- Don’t forget to unsubscribe when you are done with the event!
- The publisher owns the invocation.
  It cannot be invoked by anyone else
- Use a delegate that conforms with the .NET guidelines.
  This is EventHandler or EventHandler<T>
- Subscribers may be attached for a very long time.
  This is especially true in UI applications.
- Different parts of the system
  may subscribe to the event
  and handle it in different
  ways
- Event handlers are delegates
  and execute on the same
  thread as they were called on
- Avoid lambdas for event handlers
- Event handler leaks can happen in any type of application.
- Always unsubscribe from events when the subscribe is no longer relevant.
```csharp
// EventHandler delegate to be used for event
// it returns void and has two parameters:
// Inherit from EventArgs to create a class that represents the event data.

class OrderProcessor
{
   public event EventHandler OrderCreated;
}

var processor = new OrderProcessor();
processor.OrderCreated += Processor_OrderCreated;
    
// dont forget to unsubscribe
processor.OrderCreated -= Processor_OrderCreated;

// Event with Event Data
public event EventHandler<OrderCreatedEventArgs> OrderCreated;
```
Event with EventData
```csharp
class OrderProcessor
{
    public event EventHandler<OrderCreatedEventArgs> OrderCreated;
    protected virtual void OnOrderCreated(OrderCreatedEventArgs args)
    {
        OrderCreated?.Invoke(this, args);
    }
}
```
### Extension Methods
- How would you add methods
  to a class you do not own? - Extension Methods
- Enable you to "add" methods to existing types without creating a new
  derived type, recompiling, or otherwise modifying the original type
- Looks like an instance method
  Defined in a completely different library than the original type
- Lets you add method overloads
  You can create methods with the same names as the type you extend
  as long as they have different parameters
- Only for types you can’t control
  Don’t introduce extension methods for types in your project, or types
  that you could otherwise change

```csharp
namespace WarehouseManagementSystem.Domain.Extensions
{
public static class OrderExtensions
    {
    public static string GenerateReport(this Order order)
        {
            return $”This is the report for {order.OrderNumber}”;
        }
    }
}

using namespace WarehouseManagementSystem.Domain.Extensions;
Order order = new();
var report = order.GenerateReport();
```
- Extension methods can only
  access public properties and
  methods on the instance
- Extension methods have the
  lowest priority!
- The compiler will never choose
  an extension method if a better
  alternative exists on the type
- Language-Integrated Query (**LINQ**) is the name for a set of technologies
  based on the integration of query capabilities directly into the C#
  language

### Anonymous Types
- Anonymous types are a way to
  create objects without
  explicitly defining the type
- its a temporary class, use it to create a representation of a data
  used in the current method
- Do not return an anonymous type or use it as a parameter, It is only to be used in the current method
- Commonly used with LINQ
  Create a representation of a subset of the properties
- Equals on two different types check for value equality
- where as == operator checks for reference equality
- Explicitly define the names
  for the properties that the
  compiler cannot infer or
  where a better name is
  appropriate

```csharp
var subset = new
{
    order.OrderNumber,
    order.Total,
    AveragePrice = order.LineItems.Average(item => item.Price)
};
```
- Anonymous types provide a convenient way to encapsulate a set of
read-only properties into a single object without having to explicitly define
a type first.
The type name is generated by the compiler and is not available at the
source code level.
The type of each property is inferred by the compiler

### Tuples
- Tuples are a lightweight data
  structure that contain a
  number of elements
- The tuples feature provides concise syntax to group multiple data
  elements in a lightweight data structure

```csharp 
 var group = (order.OrderNumber, order.LineItems);
```
- Tuples are strongly typed
- Tuples are immutable
- Tuple 
  - Value type 
  - Values stored in fields 
  - Not immutable
  - not readonly, caller can change the vaLue
- Anonymous Type 
  - Reference type 
  - Values stored in properties with backing fields 
  - Read-only
  - caller is not allowed to change the values

### DeConstructor
- A de-constructor is a method that
  deconstructs an object into
  multiple values
```csharp
public class Order
{
  public void Deconstruct(out decimal total, out bool ready)
 {
  total = Total;
  ready = IsReadyForShipment;
  }
}
var order = new Order();
var (orderTotal, isReady) = order;
```

### Records
- Record can be used instead of
  a class
  If the purpose is to represent
  data
- Records are immutable
- Less code!
  Records come with generated
  code that you normally have to
  write yourself
- Records can be defined with a
  primary constructor
- Records can have a body
  where you define other
  properties, methods and
  fields
- How is this any better than
  creating a traditional class?
  There’s lots of code generated!
- Records come with value
  based equality
- Records let you focus on the
  important pieces and skip all
  the boilerplate code
- You cannot use records with
  Entity Framework
- Use Record When you want to represent
  data
- Not for classes that are meant
  for business logic
- If a property uses a record
  you will get value based
  equality for that as well
- Records are suitable for
  representing data! Do not use it for business logic
- Add optional parameters
  instead of multiple
  constructors

```csharp
record Customer();
record class Customer();
record struct Customer();
// record with primary constructor
record Customer(string Firstname, string Lastname);

Customer customer = new("Filip", "Ekberg");
Console.WriteLine(customer);


public record Order(
[property: JsonPropertyName("total")]
decimal Total = 0,
[property: JsonIgnore]
ShippingProvider ShippingProvider = default,
[property: JsonIgnore]
IEnumerable<Item> LineItems = default,
bool IsReadyForShipment = true);

record Customer(string Firstname, string Lastname);
var first = new Customer("Filip", "Ekberg");
var second = new Customer("Filip", "Ekberg");
first == second; // true

record Customer(string Firstname, string Lastname)
{
    public string Fullname => $"{Firstname} {Lastname}";
}
```