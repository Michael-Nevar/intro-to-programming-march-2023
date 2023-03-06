using Status;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/status", () =>
{
    var statusMessage = new StatusMessage(Guid.NewGuid(), "Looks good. Just learning some .net", DateTimeOffset.Now);
    return Results.Ok(statusMessage);
}
);

app.Run(); // "Block"




//var statusMessage = new StatusMessage(Guid.NewGuid(), "Looks good. Just learning some .net", DateTimeOffset.Now);   

//Console.WriteLine($"The id {statusMessage.Id} status: {statusMessage.Message} at {statusMessage.When}");