using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Repositories.Abstracts.Base;
using ECommerce.BLL.Repositories.Concretes;
using ECommerce.BLL.Repositories.Concretes.BaseConcrete;
using ECommerce.DAL.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Dependecy injection

//Adddbcontext
builder.Services.AddDbContext<ECommerceContext>(options=>options.UseSqlServer("Server=LAPTOP-7RVI861P\\SQLEXPRESS;Database=ECommerceDb;Trusted_Connection=True;TrustServerCertificate=True;",b=>b.MigrationsAssembly("ECommerce.MVC")));
//Repository Service
builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

//Entity Services
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ISupplierService, SupplierService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
     name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});




app.Run();
