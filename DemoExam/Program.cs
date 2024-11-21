List<Order> repo =
[
    new(0,new(2005,3,12),"холодос","Не морозит","Не морозит совсем","Брелова Кристина","Не назначен"),
];

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
var app = builder.Build();

app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.MapGet("/", () => "Hello World!");

app.Run();

class Order(int number, DateTime startDate, string device, string problem, string fullproblem, string fullname, string statys)
{
    public int Number { get; set; } = number;
    public DateTime StartDate { get; set; } = startDate;
    public string Device { get; set; } = device;
    public string Problem { get; set; } = problem;
    public string Fullproblem { get; set; } = fullproblem;
    public string Fullname { get; set; } = fullname;
    public string Statys { get; set; } = statys;
    public string Master { get; set; } = "Не назначен";
    public DateTime? EndDate { get; set; } = null;
    public List<string> Comment { get; set; } = [];
}

record class OrderUpdateDTO(int Number, string? Statys ="", string? Fullproblem = "", string? Master = "", string? Comment = "");