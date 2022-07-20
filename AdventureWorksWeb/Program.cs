using AdventureWorksWeb;

Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
{
    webBuilder.UseStartup<StartUp>();

}).Build().Run();