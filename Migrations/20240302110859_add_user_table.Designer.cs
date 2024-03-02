﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using idflApp.Data;

#nullable disable

namespace idflApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240302110859_add_user_table")]
    partial class add_user_table
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("idflApp.Core.Models.UserModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Roles")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("47d50a18-7e30-4d6c-afe4-b44f81368e20"),
                            CreatedAt = new DateTime(2024, 3, 2, 18, 8, 59, 56, DateTimeKind.Local).AddTicks(1192),
                            Email = "test_1@gmail.com",
                            IsActive = true,
                            IsVerified = true,
                            Name = "Test 1",
                            Password = "m9fUsQskgQAZZPVNkXc3ag==",
                            Roles = 0
                        },
                        new
                        {
                            Id = new Guid("2c1f78fa-b861-4a86-adde-3d4408b4c93f"),
                            CreatedAt = new DateTime(2024, 3, 2, 18, 8, 59, 56, DateTimeKind.Local).AddTicks(8862),
                            Email = "test_2@gmail.com",
                            IsActive = true,
                            IsVerified = true,
                            Name = "Test 1",
                            Password = "m9fUsQskgQAZZPVNkXc3ag==",
                            Roles = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
