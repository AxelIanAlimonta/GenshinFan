﻿// <auto-generated />
using GenshinFan.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GenshinFan.Data.Migrations
{
    [DbContext(typeof(GenshinImpactContext))]
    partial class GenshinImpactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GenshinFan.Data.Elemento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagenURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Elemento", (string)null);
                });

            modelBuilder.Entity("GenshinFan.Data.Personaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AtkBase")
                        .HasColumnType("int");

                    b.Property<int?>("DefBase")
                        .HasColumnType("int");

                    b.Property<int?>("Id_Elemento")
                        .HasColumnType("int");

                    b.Property<int?>("Id_Region")
                        .HasColumnType("int");

                    b.Property<int?>("Id_TipoDeArma")
                        .HasColumnType("int");

                    b.Property<string>("ImgDisenio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgTarjeta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rareza")
                        .HasColumnType("int");

                    b.Property<int?>("VidaBase")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Elemento");

                    b.HasIndex("Id_Region");

                    b.HasIndex("Id_TipoDeArma");

                    b.ToTable("Personaje", (string)null);
                });

            modelBuilder.Entity("GenshinFan.Data.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagenURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Region", (string)null);
                });

            modelBuilder.Entity("GenshinFan.Data.TipoDeArma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagenURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoDeArma", (string)null);
                });

            modelBuilder.Entity("GenshinFan.Data.Personaje", b =>
                {
                    b.HasOne("GenshinFan.Data.Elemento", "Elemento")
                        .WithMany("Personajes")
                        .HasForeignKey("Id_Elemento");

                    b.HasOne("GenshinFan.Data.Region", "Region")
                        .WithMany("Personajes")
                        .HasForeignKey("Id_Region");

                    b.HasOne("GenshinFan.Data.TipoDeArma", "TipoDeArma")
                        .WithMany("Personajes")
                        .HasForeignKey("Id_TipoDeArma");

                    b.Navigation("Elemento");

                    b.Navigation("Region");

                    b.Navigation("TipoDeArma");
                });

            modelBuilder.Entity("GenshinFan.Data.Elemento", b =>
                {
                    b.Navigation("Personajes");
                });

            modelBuilder.Entity("GenshinFan.Data.Region", b =>
                {
                    b.Navigation("Personajes");
                });

            modelBuilder.Entity("GenshinFan.Data.TipoDeArma", b =>
                {
                    b.Navigation("Personajes");
                });
#pragma warning restore 612, 618
        }
    }
}
