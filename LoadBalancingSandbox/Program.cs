namespace LoadBalancingSandbox;

public static class Program
{
    public static void Main(string[] args)
    {
        CreateHost(args)
            .Build()
            .Run();
    }

    private static IWebHostBuilder CreateHost(string[] args)
    {
        var host = new WebHostBuilder()
            .UseKestrel(kestrelServerOptions =>
                kestrelServerOptions
                    .UseSystemd())
            .ConfigureAppConfiguration(app =>
                app
                    .AddCommandLine(args)
                    .AddJsonFile("appsettings.json"))
            .UseStartup<Startup>();

        return host;
    }
}