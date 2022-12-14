using Dependency_Injection.Services;

var builder = WebApplication.CreateBuilder(args);  // built in IoC

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog()));
builder.Services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));

//default olarak bunlar singleton'd?r.


ServiceProvider provider = builder.Services.BuildServiceProvider();
provider.GetService<ConsoleLog>();
provider.GetService<TextLog>();


builder.Services.AddSingleton<ConsoleLog>();
builder.Services.AddSingleton<TextLog>();   

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
