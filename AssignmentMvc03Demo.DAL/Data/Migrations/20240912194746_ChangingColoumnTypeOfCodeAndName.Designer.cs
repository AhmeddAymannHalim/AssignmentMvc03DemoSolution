﻿// <auto-generated />
using System;
using AssignmentMvc03Demo.DAL.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssignmentMvc03Demo.DAL.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240912194746_ChangingColoumnTypeOfCodeAndName")]
    partial class ChangingColoumnTypeOfCodeAndName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AssignmentMvc03Demo.DAL.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 10L, 10);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateOnly>("CreationDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("date")
                        .HasComputedColumnSql("CAST((GETDATE())as date)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
