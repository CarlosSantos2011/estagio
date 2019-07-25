using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebLoja2.Context;

namespace LojaWeb.Migrations
{
    [DbContext(typeof(LojaContext))]
    [Migration("20190724210348_dbo.clientes")]
    partial class dboclientes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebLoja2.Models.Contatos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular");

                    b.Property<string>("Comercial");

                    b.Property<string>("Email");

                    b.Property<string>("Residencial");

                    b.HasKey("Id");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("WebLoja2.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Logradouro");

                    b.Property<string>("NomeLogradouro");

                    b.Property<double>("Numero");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

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

            modelBuilder.Entity("WebLoja2.Models.Produtos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Modelo");

                    b.Property<string>("Nome");

                    b.Property<int>("Quantidade");

                    b.Property<int>("TempoGarantia");

                    b.Property<int>("Tipo");

                    b.Property<float>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
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
