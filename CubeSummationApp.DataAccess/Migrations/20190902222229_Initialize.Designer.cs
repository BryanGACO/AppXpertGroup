﻿// <auto-generated />
using System;
using CubeSummationApp.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CubeSummationApp.DataAccess.Migrations
{
    [DbContext(typeof(CubeSummationDbContext))]
    [Migration("20190902222229_Initialize")]
    partial class Initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CubeSummationApp.DataAccess.Contracts.Entities.CoordinateEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CubeId");

                    b.Property<int>("Value");

                    b.Property<int>("X");

                    b.Property<int>("Y");

                    b.Property<int>("Z");

                    b.HasKey("Id");

                    b.HasIndex("CubeId");

                    b.ToTable("Coordinates");
                });

            modelBuilder.Entity("CubeSummationApp.DataAccess.Contracts.Entities.CubeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Dimension");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Cubes");
                });

            modelBuilder.Entity("CubeSummationApp.DataAccess.Contracts.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Name");

                    b.Property<int?>("UserEntityId");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CubeSummationApp.DataAccess.Contracts.Entities.CoordinateEntity", b =>
                {
                    b.HasOne("CubeSummationApp.DataAccess.Contracts.Entities.CubeEntity", "Cube")
                        .WithMany("Coordinates")
                        .HasForeignKey("CubeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CubeSummationApp.DataAccess.Contracts.Entities.CubeEntity", b =>
                {
                    b.HasOne("CubeSummationApp.DataAccess.Contracts.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CubeSummationApp.DataAccess.Contracts.Entities.UserEntity", b =>
                {
                    b.HasOne("CubeSummationApp.DataAccess.Contracts.Entities.UserEntity")
                        .WithMany("Users")
                        .HasForeignKey("UserEntityId");
                });
#pragma warning restore 612, 618
        }
    }
}
