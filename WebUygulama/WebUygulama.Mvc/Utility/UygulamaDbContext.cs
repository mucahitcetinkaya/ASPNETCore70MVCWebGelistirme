
using Microsoft.EntityFrameworkCore;
using WebUygulama.Mvc.Models;

namespace WebUygulama.Mvc.Utility
{
    public class UygulamaDbContext:DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options){}
        
        public DbSet<KitapTuru> KitapTurleri { get; set; }

    }
}


/*
 
 14. video program.cs den geldik

ilk hali

namespace WebUygulama.Mvc.Utility
{
    public class UygulamaDbContext
    {
    }
}

namespace WebUygulama.Mvc.Utility
{
    public class UygulamaDbContext:DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options){}
    }
}

miras aldı dbcontext i 
yeni bir nesne yarattık
constrator olusturduk 

burası mekanizma asp.net in sistemi böyle calısıyor

program.cs e gidelim 
 
 
 */

/*
 
 VİDEO 15. Entity Framework Kullanarak Koddan Tablo Olusturmak
 
program.cs den geldik

dbsetleri ekleyeceğiz

entity leri tablo olarak içeriye aktarmak için dbset ile kayıt etmek gerekiyor 

        DbSet<KitapTuru> KitapTurleri { get; set; }

efcore da KitapTuru ne denk gelen VT de KitapTurleri olacak

bunu dedıkten sonra bir tane migrations olusturmamız gerekiyor 

efcore de kod tarafında yapılanların VT nına yansıması için mig yapmamız gerekiyor 

update-database

yaptıgımız gibi package manager console dan 

add-migration KitapTurleriTablosuEkle

bunu yazıyoruz add-migration sonrası mig adı oluyo herhangi bişey olabilir 

PM> add-migration KitapTurleriTablosuEkle
Build started...
Build succeeded.
To undo this action, use Remove-Migration.
PM> 

ekledi ve Migrations klasörü geldi 

VT nına tablo olusması için de 

update-database yapmamız lazım 


PM> update-database
Build started...
Build succeeded.
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (12ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (10ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT OBJECT_ID(N'[__EFMigrationsHistory]');
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT OBJECT_ID(N'[__EFMigrationsHistory]');
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (9ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [MigrationId], [ProductVersion]
      FROM [__EFMigrationsHistory]
      ORDER BY [MigrationId];
Microsoft.EntityFrameworkCore.Migrations[20402]
      Applying migration '20260203174059_KitapTurleriTablosuEkle'.
Applying migration '20260203174059_KitapTurleriTablosuEkle'.
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (7ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [KitapTurleri] (
          [ID] int NOT NULL IDENTITY,
          [Ad] nvarchar(max) NOT NULL,
          CONSTRAINT [PK_KitapTurleri] PRIMARY KEY ([ID])
      );
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
      VALUES (N'20260203174059_KitapTurleriTablosuEkle', N'7.0.5');
Done.
PM> 

ekledı herhangi bir sorun yok 

VT nına tablo ekledi oraya da geldi 

birde bir tablo daha var 

__EFMigrationsHistory burda da migration versiyonu yazıyor 


KitapTurleri db sinin içinde de 
ID primary key not null
Ad nvarchar(max) not null olarak gelmiş

5. bölüm bitti

 
 */