using Cadastro_Petshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_Petshop.Persistencia
{
    public class Cadastro_PetshopContext : DbContext
    {
        public DbSet<Animal> Animais { get; set; }

        public DbSet<Veterinario> Veterinarios { get; set; }

        public DbSet<AnimalVeterinario> AnimaisVeterinarios { get; set; }

        public DbSet<Plano> Planos { get; set; }

        public DbSet<ContratoTrabalho> ContratosTrabalhos { get; set; }
        public Cadastro_PetshopContext(DbContextOptions op) : base(op) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Chave composta da associativa
            modelBuilder.Entity<AnimalVeterinario>().HasKey(av => new {av.AnimalId, av.VeterinarioId, av.Data});

            //Relacionamento da associativa com o animal
            modelBuilder.Entity<AnimalVeterinario>()
                .HasOne(av => av.Animal)
                .WithMany(av => av.AnimaisVeterinarios)
                .HasForeignKey(av => av.AnimalId);

            //Relacionamento da associativa com o veterinario
            modelBuilder.Entity<AnimalVeterinario>()
                .HasOne(av => av.Veterinario)
                .WithMany(av => av.AnimaisVeterinarios)
                .HasForeignKey(av => av.VeterinarioId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
