﻿// <auto-generated />
using BulkWebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BulkWebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.2.24128.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BulkWebApi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Sci-Fi"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 8,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 9,
                            DisplayOrder = 9,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 10,
                            DisplayOrder = 10,
                            Name = "Documentary"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
