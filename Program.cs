var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//for books
app.MapGet("/", () => "Home Page");
app.MapGet("/books", () => "Get all books");
app.MapGet("/books/{id}", (string id) => $"Get book with ID {id}");
app.MapPost("/books", () => "Add a new book");
app.MapPut("/books/{id}", (string id) => $"Update book with ID {id}");
app.MapDelete("/books/{id}", (string id) => $"Delete book with ID {id}");

//for readers
app.MapGet("/readers", () => "Get all readers");
app.MapGet("/readers/{id}", (string id) => $"Get reader with ID {id}");
app.MapPost("/readers", () => "Add a new reader");
app.MapPut("/readers/{id}", (string id) => $"Update reader with ID {id}");
app.MapDelete("/readers/{id}", (string id) => $"Delete reader with ID {id}");

//for borrowings
app.MapGet("/borrowings", () => "Get all borrowings");
app.MapGet("/borrowings/{id}", (string id) => $"Get borrowing with ID {id}");
app.MapPost("/borrowings", () => "Add a new borrowing");
app.MapPut("/borrowings/{id}", (string id) => $"Update borrowing with ID {id}");
app.MapDelete("/borrowings/{id}", (string id) => $"Delete borrowing with ID {id}");

app.Run();
