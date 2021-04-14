using IranDailyTime.Server;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

await (Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(wb =>
    {
        wb.UseStartup<Startup>();
    }).Build()).RunAsync();