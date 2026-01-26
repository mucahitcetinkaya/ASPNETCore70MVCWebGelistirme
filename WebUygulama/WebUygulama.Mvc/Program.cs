var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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


/*
 
 burasý ana alan mvc si otomatik olarak olusturuluyor buna pipeline deniyor
 MapController kýsmý uygulama acýldýgýnda acýlan kýsým 
 url calýsma mantýgý 
    pattern: "{controller=Home}/{action=Index}/{id?}");
controller olacak 
action olacak

controller dedigin Controller klasöründeki HomeController.cs
action dediði Controller klasöründeki Index metotu

 */