using desafioBrunSker.Models;
using Microsoft.EntityFrameworkCore;

namespace desafioBrunSker.Repositories
{
    public class MysqlContext : DbContext
    {
        public DbSet<Imobiliaria> Imobiliarias {get; set;}

        public MysqlContext() : base() {}

        public MysqlContext(DbContextOptions<MysqlContext> options) : base(options){}
        
    }
}