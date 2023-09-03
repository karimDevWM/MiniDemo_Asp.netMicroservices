using MiniDemo.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", () => "Hello World!");

app.MapGet("/employee", (Func<Employee>)(() =>
{
    return new Employee()
    {
        EmployeeName = "Karim Trabelsi",
        Citizenship = "France",
        EmployeeId = "1"
    };
}));

app.MapGet("/employees", (Func<List<Employee>>)(() =>
{
    return new EmployeeCollection().GetEmployees();
}));

app.MapGet("/employee/{id}", async (http) =>
{
    if (!http.Request.RouteValues.TryGetValue("id", out var id))
    {
        http.Response.StatusCode = 400;
        return;
    }
    else
    {
        await http.Response.WriteAsJsonAsync(new EmployeeCollection()
            .GetEmployees()
            .FirstOrDefault(x => x.EmployeeId == (string)id));
    }
});

app.Run();
