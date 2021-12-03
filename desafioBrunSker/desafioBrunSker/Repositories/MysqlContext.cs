using desafioBrunSker.Models;
using Microsoft.EntityFrameworkCore;

namespace desafioBrunSker.Repositories
{
    public class MysqlContext : DbContext
    {

        public MysqlContext(): base() {}

        public MysqlContext(DbContextOptions<MysqlContext> options): base(options){}

        public DbSet<Imobiliaria>? Imobiliarias {get; set;}
    }
}