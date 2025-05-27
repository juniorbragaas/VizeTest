using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using Modelo;

public class AppDbContext : DbContext
{
    public AppDbContext() : base("name=DefaultConnection") { }

    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Installment> Installments { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("public");

        // Configuração da chave primária do Contract
        modelBuilder.Entity<Contract>()
            .HasKey(c => c.ContractId)
            .ToTable("contracts");

        // Configuração da chave primária e relacionamento em Installments
        modelBuilder.Entity<Installment>()
            .HasKey(i => i.InstallmentId)
            .ToTable("installments");

        modelBuilder.Entity<Installment>()
            .HasRequired(i => i.Contract)
            .WithMany(c => c.Installments)
            .HasForeignKey(i => i.ContractId);

        base.OnModelCreating(modelBuilder);
    }
}

