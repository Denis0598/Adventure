namespace AdventureWorksWeb
{
    public class StartUp
    {

        public void ConfigureServices(IServiceCollection service)
        {
            service.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsDevelopment())
            {
                app.UseHsts();
            }

            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapGet("/hola", () => "hola mundo");
            });
        }
    }
}

