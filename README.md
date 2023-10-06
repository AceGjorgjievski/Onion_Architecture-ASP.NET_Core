# Onion_Architecture-ASP.NET_Core


In this GitHub repository we have an example project of Onion Architecture in ASP.NET
Core for building web applications.

You can reuse this project to start your web application in
ASP.NET Core using the **Rider IDE** from JetBrains using the PostgreSQL database.

### **The Onion Architecture consists of four main layers:**

- Domain Layer
- Infrastructure Layer (Repository or Data)
- Application Services Layer (Service or Application)
- Presentation Layer (Web)

Necessary packages to install in the layers:
- **Domain Layer**
    - Microsoft.AspNetCore.Identity.UI **&middot;** 3.1.32
- **Infrastructure Layer (Repository or Data)**
    - Microsoft.AspNetCore.Identity.EntityFrameworkCore **&middot;** 3.1.32
    - Microsoft.EntityFrameworkCore.Design **&middot;** 3.1.32
- **Application Services Layer (Service or Application)**
    - (None)
- **Presentation Layer (Web)**
    - Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore **&middot;** 3.1.32
    - Microsoft.AspNetCore.Identity.EntityFrameworkCore **&middot;** 3.1.32
    - Microsoft.AspNetCore.Identity.UI **&middot;** 3.1.32
    - Microsoft.EntityFrameworkCore.Tools **&middot;** 3.1.32
    - Npgsql.EntityFrameworkCore.PostgreSQL **&middot;** 3.1.32
    - [note: I removed Sqlite because we're using Npgsql (PostgreSQL db); if you encounter some
      problems, consider reinstalling it: Microsoft.EntityFrameworkCore.Sqlite **&middot;** 3.1.32]

Commands in order to interact with the migrations:
- `dotnet ef migrations list` - listing all migrations
- `dotnet ef migrations add [name of the new migration]` - adding new migration
- `dotnet ef migrations remove` - removing the last migration
- `dotnet ef database update` - updating the database after adding new migration


I have recorded a video tutorial on how to configure an ASP.NET application
in the Rider IDE from JetBrains, using a PostgreSQL database.
You can watch it through this [video link](https://www.youtube.com/watch?v=Bz24uIRrl5I).

I hope helped somebody, thank you. `:)`

Have a great day & life ❤