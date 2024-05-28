﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using LMS.Data;

#nullable disable

namespace LMS.Migrations
{
    [DbContext(typeof(EntityDbContext))]
    partial class EntityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);


            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
            modelBuilder.Entity("LMS.Models.Librarian", b =>
            {
                b.Property<int>("LibrarianId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibrarianId"));

                b.Property<string>("LibrarianCode")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LibrarianName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Sex")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("Dob")
                    .IsRequired()
                    .HasColumnType("datetime2");

                b.Property<string>("Phone")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Address")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("LibrarianId");

                b.ToTable("Librarians");
            });

#pragma warning restore 612, 618
        }
    }
}
