﻿// <auto-generated />
using EngineersOffice_WebApi.ContextFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EngineersOffice_WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EngineersOffice_Library.Models.BendingCoefficient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Flexibility")
                        .HasColumnType("int");

                    b.Property<int>("R_200")
                        .HasColumnType("int");

                    b.Property<int>("R_220")
                        .HasColumnType("int");

                    b.Property<int>("R_240")
                        .HasColumnType("int");

                    b.Property<int>("R_260")
                        .HasColumnType("int");

                    b.Property<int>("R_280")
                        .HasColumnType("int");

                    b.Property<int>("R_300")
                        .HasColumnType("int");

                    b.Property<int>("R_320")
                        .HasColumnType("int");

                    b.Property<int>("R_340")
                        .HasColumnType("int");

                    b.Property<int>("R_360")
                        .HasColumnType("int");

                    b.Property<int>("R_380")
                        .HasColumnType("int");

                    b.Property<int>("R_400")
                        .HasColumnType("int");

                    b.Property<int>("R_440")
                        .HasColumnType("int");

                    b.Property<int>("R_480")
                        .HasColumnType("int");

                    b.Property<int>("R_520")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BendingCoefficient_Guide");
                });

            modelBuilder.Entity("EngineersOffice_Library.Models.MetalAssortment.Beam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("F")
                        .HasColumnType("real");

                    b.Property<float>("Ix")
                        .HasColumnType("real");

                    b.Property<float>("Iy")
                        .HasColumnType("real");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Standart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Sx")
                        .HasColumnType("real");

                    b.Property<float>("Wx")
                        .HasColumnType("real");

                    b.Property<float>("Wy")
                        .HasColumnType("real");

                    b.Property<float>("b")
                        .HasColumnType("real");

                    b.Property<float>("h")
                        .HasColumnType("real");

                    b.Property<float>("i_x")
                        .HasColumnType("real");

                    b.Property<float>("i_y")
                        .HasColumnType("real");

                    b.Property<float>("lineDensity")
                        .HasColumnType("real");

                    b.Property<float>("r")
                        .HasColumnType("real");

                    b.Property<float>("s")
                        .HasColumnType("real");

                    b.Property<float>("t")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Beam_Guide");
                });

            modelBuilder.Entity("EngineersOffice_Library.Models.SteelGrade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Contraction")
                        .HasColumnType("int");

                    b.Property<int>("Elongation")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HB")
                        .HasColumnType("int");

                    b.Property<int>("TensileStrength")
                        .HasColumnType("int");

                    b.Property<int>("YieldStress")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SteelGrade_Guide");
                });
#pragma warning restore 612, 618
        }
    }
}