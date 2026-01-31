
using Microsoft.EntityFrameworkCore;

namespace WebUygulama.Mvc.Utility
{
    public class UygulamaDbContext:DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options){}
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