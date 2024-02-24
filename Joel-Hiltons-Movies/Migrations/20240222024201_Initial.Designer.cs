﻿// <auto-generated />
using System;
using Joel_Hiltons_Movies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Joel_Hiltons_Movies.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240222024201_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("Joel_Hiltons_Movies.Models.Application", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool?>("edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lent_to")
                        .HasColumnType("TEXT");

                    b.Property<string>("notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("JoelsMovies");
                });

            modelBuilder.Entity("Joel_Hiltons_Movies.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("Joel_Hiltons_Movies.Models.Application", b =>
                {
                    b.HasOne("Joel_Hiltons_Movies.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });
#pragma warning restore 612, 618
        }
    }
}