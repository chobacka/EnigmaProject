using EnigmaAPI;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseFileServer(); 
app.MapGet("/encrypt", (string text) => EnigmaLogic.Encrypt(text));
app.MapGet("/decrypt", (string text) => EnigmaLogic.Decrypt(text));
app.Run();

// Detta gör att vi kan visa index.html och bilder
app.UseFileServer(); 

// Endpoint för att KRYPTERA (Flyttar bokstaven framåt, A -> B)
app.MapGet("/encrypt", (string text) => 
{
    if (string.IsNullOrEmpty(text)) return "";
    char[] buffer = text.ToCharArray();
    for (int i = 0; i < buffer.Length; i++)
    {
        buffer[i] = (char)(buffer[i] + 1);
    }
    return new string(buffer);
});

// Endpoint för att AVKRYPTERA (Flyttar bokstaven bakåt, B -> A)
app.MapGet("/decrypt", (string text) => 
{
    if (string.IsNullOrEmpty(text)) return "";
    char[] buffer = text.ToCharArray();
    for (int i = 0; i < buffer.Length; i++)
    {
        buffer[i] = (char)(buffer[i] - 1);
    }
    return new string(buffer);
});

app.Run();