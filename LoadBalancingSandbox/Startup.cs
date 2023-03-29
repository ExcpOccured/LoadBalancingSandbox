namespace LoadBalancingSandbox;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
        services.AddRouting();
        services.AddLogging();
        services.AddControllers();
    }

    public void Configure(
        IApplicationBuilder app)
    {
        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}