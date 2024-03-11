using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Добавление служб MVC в контейнер IoC
        services.AddControllersWithViews();

        // Если есть другие службы, которые нужно добавить, делаем это здесь
        // Например, для Entity Framework Core:
        // services.AddDbContext<YourDbContext>(options =>...);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Использование страниц ошибок для разработки
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            // Для производства можно использовать пользовательскую страницу ошибок
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection(); // Принудительное использование HTTPS
        app.UseStaticFiles(); // Включение статических файлов (CSS, JavaScript, изображения)

        app.UseRouting(); // Включение маршрутизации

        app.UseAuthorization(); // Включение системы авторизации (если нужно)

        // Определение конечных точек маршрутизации
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
