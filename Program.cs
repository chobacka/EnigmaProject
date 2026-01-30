using EnigmaAPI;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseFileServer(); 

// Vi anropar vår logik-klass EN gång per endpoint.
app.MapGet("/encrypt", (string text) => EnigmaLogic.Encrypt(text));
app.MapGet("/decrypt", (string text) => EnigmaLogic.Decrypt(text));

app.Run();