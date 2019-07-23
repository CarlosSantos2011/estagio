using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebLoja2.Context;

namespace WebLoja2.Migrations
{
    [DbContext(typeof(LojaContext))]
    [Migration("20190723115126_TabelaCliente")]
    partial class TabelaCliente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebLoja2.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pessoa");
                });

            modelBuilder.Entity("WebLoja2.Models.Clientes", b =>
                {
                    b.HasBaseType("WebLoja2.Models.Pessoa");

                    b.Property<string>("Cpf");

                    b.Property<int>("PessoaId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Clientes");

                    b.HasDiscriminator().HasValue("Clientes");
                });

            modelBuilder.Entity("WebLoja2.Models.Clientes", b =>
                {
                    b.HasOne("WebLoja2.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
