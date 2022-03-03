using BD_Exemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace BD_Exemplo.Persistencia
{
    public class PetshopContext : DbContext
    {
        public DbSet<Animal> Animais { get; set; }

        public PetshopContext(DbContextOptions op) : base(op) { }
    }
}
