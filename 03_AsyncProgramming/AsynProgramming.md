Asynchronous Programming in C#
==============================
- `async programming` is applicable for any type of .net app including wpf, WinUI3, .net maui, asp.net etc
- `An asynchronous operation occurs in parallel` and relives the calling thread of the work.
- ways to achieve asynchronous programming in C#:
  - `async` and `await` keywords - widely used
  - Threading low level 
  - Task Parallel Library (TPL) - widely used
  - BackgroundWorker - event based asynchronous pattern
### async and await keywords 
  - are used to create asynchronous methods in C#.
  - suited for Disk, Network, Database, I/O bound operations for cpu bound operations use Task Parallel Library (TPL).
  - you cannot make the method async by just adding async keyword, you need to use await keyword inside the method
  - marking a method as async introduces the capability of using the await keyword to leverage the asynchronous principles.
  - `async` keyword is used to define an asynchronous method
  - calling `Result` or `Wait` may cause deadlocks
  - Use `await` with a Task to retrieve the result and to validate it completed successfully.
  - `await` keyword is used to pause the execution of the method until the awaited task completes.
  - await keyword gives you a potential result
  - validates the success of the operation
  - continuation is back on calling thread. a continuation allowing you to get back to the original context.
  - The await keyword will re-throw exceptions that occurs inside the Task.
  - Using async and await in ASP.NET means the web server can handler other requests, without blocking other requests.
  - Only use `async void` for event-handlers. `async void` is evil and avoid it all cost.
  - 

```csharp
// This is a blocking call, blocks the thread until result is available.
        var content = await response.Result.Content.ReadAsStringAsync();
```

### Task Parallel Library
TPL is used for cpu bound operations and independent chunks of data. 