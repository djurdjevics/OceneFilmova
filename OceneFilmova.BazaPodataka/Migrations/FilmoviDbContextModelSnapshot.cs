﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OceneFilmova.BazaPodataka;

#nullable disable

namespace OceneFilmova.BazaPodataka.Migrations
{
    [DbContext(typeof(FilmoviDbContext))]
    partial class FilmoviDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FilmGlumac", b =>
                {
                    b.Property<Guid>("FilmoviID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GlumciID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FilmoviID", "GlumciID");

                    b.HasIndex("GlumciID");

                    b.ToTable("FilmGlumac");
                });

            modelBuilder.Entity("FilmTag", b =>
                {
                    b.Property<Guid>("FilmoviID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TagoviID")
                        .HasColumnType("int");

                    b.HasKey("FilmoviID", "TagoviID");

                    b.HasIndex("TagoviID");

                    b.ToTable("FilmTag");
                });

            modelBuilder.Entity("OceneFilmova.Domen.Entieti.Film", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Deskripcija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GodinaIzdanja")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Ocena")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Filmovi");
                });

            modelBuilder.Entity("OceneFilmova.Domen.Entieti.Glumac", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Glumci");
                });

            modelBuilder.Entity("OceneFilmova.Domen.Entieti.Tag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Tagovi");
                });

            modelBuilder.Entity("FilmGlumac", b =>
                {
                    b.HasOne("OceneFilmova.Domen.Entieti.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmoviID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OceneFilmova.Domen.Entieti.Glumac", null)
                        .WithMany()
                        .HasForeignKey("GlumciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FilmTag", b =>
                {
                    b.HasOne("OceneFilmova.Domen.Entieti.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmoviID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OceneFilmova.Domen.Entieti.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagoviID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
