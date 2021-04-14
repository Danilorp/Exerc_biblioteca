﻿// <auto-generated />
using Exerc_biblioteca.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Exerc_biblioteca.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Exerc_biblioteca.Models.livro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("capa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edicao")
                        .HasColumnType("int");

                    b.Property<string>("editora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idioma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pagina")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("livros");
                });
#pragma warning restore 612, 618
        }
    }
}
