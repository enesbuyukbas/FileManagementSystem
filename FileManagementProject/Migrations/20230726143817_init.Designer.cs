﻿// <auto-generated />
using System;
using FileManagementProject.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FileManagementProject.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230726143817_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FileManagementProject.Entities.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int>("EmployeeDepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeManagerId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeePassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            EmployeeDepartmentId = 0,
                            EmployeeEmail = "enes_bykbss@hotmail.com",
                            EmployeeFirstName = "Enes",
                            EmployeeLastName = "Büyükbaş",
                            EmployeeManagerId = 0,
                            EmployeePassword = "1234"
                        },
                        new
                        {
                            EmployeeId = 2,
                            EmployeeDepartmentId = 1,
                            EmployeeEmail = "enes_buyukbas@hotmail.com",
                            EmployeeFirstName = "Emre",
                            EmployeeLastName = "Büyük",
                            EmployeePassword = "12345"
                        },
                        new
                        {
                            EmployeeId = 3,
                            EmployeeDepartmentId = 2,
                            EmployeeEmail = "beyzayuksel0111@gmail.com",
                            EmployeeFirstName = "Beyza",
                            EmployeeLastName = "Yüksel",
                            EmployeePassword = "123456789"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
