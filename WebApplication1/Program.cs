using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//List<string> DutyList = new List<string>();
string dutyListString = string.Empty;

decimal TaxPrice(decimal price)
{
    decimal duty = price < 200 ? 0 : ((price - 200) * (decimal) 0.15);
    //DutyList.Add($"Вычисленная пошлина = {duty} €");
    dutyListString += $"\nВычисленная пошлина = {duty} €;\n";
    return duty;
}

app.MapGet("/hello", ()=>"Hi!");
app.MapGet("/duty", (string price) => $"Ваша пошлина = {TaxPrice(decimal.Parse(price))} €");
app.MapGet("/history", ()=>dutyListString);
app.MapGet("/datetime", (string lang) => DateTime.Now.ToString("dd MMMM yyyy, dddd, HH:mm:ss", new CultureInfo(lang)));

app.Run();