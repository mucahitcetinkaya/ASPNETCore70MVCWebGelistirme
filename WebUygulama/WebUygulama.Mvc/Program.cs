using Microsoft.EntityFrameworkCore;
using WebUygulama.Mvc.Utility;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<UygulamaDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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


/*
 
 VÝDEO 14. DbContext Sýnýfýný Kullanarak Veritabaný ve Entity Model Arasýnda Köprü Kurma
 
DBContext sýnýfýna bakacagýz 

nedir

veritabanýmýz var sql server 
ve bizim entitylerimiz olacak modellerimiz KitapTuru bir model entity oluyor aslýnda 

karsýlýgý veri tabanýnda tablo olan class lara entity diyoruz 

veritabaný ile entity arasýndaki köprüsü dbcontext ile kuruyoruz

DbContext ten bir sýnýf olusturun sonra bundan nesne olusturup entity ve veri tabaný arasýndaki baglantýlarý yapabilirsiniz

WebUygulama.Mvc içinde yeni bir klasör olustur
 
oraya gidelim

UygulamaDbContext ten geldik

DbContext i buraya servis olarak eklememýz lazým 

builder.Services.AddDbContext<UygulamaDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconnection")));

bunu ekledik buraya

bu nerden geldi appsettings.json da ekleme yapmýstýk 

,
  "ConnectionStrings": {
    "DefaultConnection": "Server=SQLSERVERNAME;DataBase=DBADI;Trusted_Connection=True;TrustServerCertificate=True"
  }
}

ConnectionStrings in ustune gelince yazýyor orda Get.ConnectionString(string)

AddDbContext DbContext i kullan diyoruz nesnesini veriyoruz
bunu kullanýrkende sqlserver kullan diyoruz
sqlserver kullanýrkende json içindeki Defaultconnection i kullan diyoruz

db i kuralým þimdi 

tools dan nuget package maganer 
package maganer console

update-database

PM> update-database
Build started...
Build succeeded.
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (124ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
      CREATE DATABASE [VTKitapSatis];
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (66ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
      IF SERVERPROPERTY('EngineEdition') <> 5
      BEGIN
          ALTER DATABASE [VTKitapSatis] SET READ_COMMITTED_SNAPSHOT ON;
      END;
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (9ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [__EFMigrationsHistory] (
          [MigrationId] nvarchar(150) NOT NULL,
          [ProductVersion] nvarchar(32) NOT NULL,
          CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
      );
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (8ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT OBJECT_ID(N'[__EFMigrationsHistory]');
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (14ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [MigrationId], [ProductVersion]
      FROM [__EFMigrationsHistory]
      ORDER BY [MigrationId];
Microsoft.EntityFrameworkCore.Migrations[20405]
      No migrations were applied. The database is already up to date.
No migrations were applied. The database is already up to date.
Done.
PM> 

olusturdu sorun yaratmadý


*/