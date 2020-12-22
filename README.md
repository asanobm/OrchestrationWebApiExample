
## 1. Create Model
```c#
namespace OrchestrationWebApiExample.Models
{

    /// <summary>
    /// Todo Item model.
    /// </summary>
    public class TodoItem
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Secret { get; set; }
        public bool IsComplete { get; set; }
    }
}
```
## 2. Create Model Context
```c#
using Microsoft.EntityFrameworkCore;

namespace OrchestrationWebApiExample.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems {get; set;}
        
        public TodoContext(DbContextOptions<TodoContext> options): base(options)
        {
        }
    }
}
```
## 3. Create Update Startup
```c#
services.AddDbContext<TodoContext>(opt =>
opt.UseInMemoryDatabase("TodoList"));
```
## 4. Run codegenerator

```
dotnet aspnet-codegenerator controller \
    -api \
    -async \
    -m TodoItem \
    -dc TodoContext \
    -outDir Controllers \
    -name TodoItemsController
```

## 5.Check your app

![](./OrchestrationWebApiExample/README/Images/5.checkyourapp.png)