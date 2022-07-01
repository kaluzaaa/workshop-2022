using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    ConsumeCPU(100);
    return "Hello World!";
});

app.Run();

static void ConsumeCPU(int percentage)
{
    if (percentage < 0 || percentage > 100)
        throw new ArgumentException("percentage");
    Stopwatch watch = new Stopwatch();
    watch.Start();
    while (true)
    {
        // Make the loop go on for "percentage" milliseconds then sleep the 
        // remaining percentage milliseconds. So 40% utilization means work 40ms and sleep 60ms
        if (watch.ElapsedMilliseconds > percentage)
        {
            Thread.Sleep(100 - percentage);
            watch.Reset();
            watch.Start();
        }
    }
}