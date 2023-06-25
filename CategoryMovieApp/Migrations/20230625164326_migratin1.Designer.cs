﻿// <auto-generated />
using System;
using CategoryMovieApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CategoryMovieApp.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230625164326_migratin1")]
    partial class migratin1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CategoryMovieApp.Models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorId"), 1L, 1);

                    b.Property<string>("ActorImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ActorStatu")
                        .HasColumnType("bit");

                    b.Property<string>("ActorTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.ActorMovie", b =>
                {
                    b.Property<int>("ActorMovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorMovieId"), 1L, 1);

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int?>("ActorMovieId1")
                        .HasColumnType("int");

                    b.HasKey("ActorMovieId");

                    b.HasIndex("ActorId");

                    b.HasIndex("ActorMovieId1");

                    b.ToTable("ActorMovies");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"), 1L, 1);

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AdminStatu")
                        .HasColumnType("bit");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryNameEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryNameTR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CategoryStatu")
                        .HasColumnType("bit");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"), 1L, 1);

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CommentStatu")
                        .HasColumnType("bit");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"), 1L, 1);

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ContactStatu")
                        .HasColumnType("bit");

                    b.Property<string>("ContactText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("CountryNameEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryNameTR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CountryStatu")
                        .HasColumnType("bit");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LanguageId"), 1L, 1);

                    b.Property<string>("LanguageNameEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageNameTR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LanguageStatu")
                        .HasColumnType("bit");

                    b.HasKey("LanguageId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"), 1L, 1);

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("MovieAddDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MovieDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("MovieIMDB")
                        .HasColumnType("real");

                    b.Property<string>("MovieImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieLength")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieNameEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieNameTR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MovieStatu")
                        .HasColumnType("bit");

                    b.Property<int>("MovieViewCount")
                        .HasColumnType("int");

                    b.Property<int>("YearId")
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.HasIndex("ActorId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CountryId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("YearId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UserStatu")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Year", b =>
                {
                    b.Property<int>("YearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YearId"), 1L, 1);

                    b.Property<string>("YearName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("YearStatu")
                        .HasColumnType("bit");

                    b.HasKey("YearId");

                    b.ToTable("Years");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Actor", b =>
                {
                    b.HasOne("CategoryMovieApp.Models.Movie", null)
                        .WithMany("Actors")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.ActorMovie", b =>
                {
                    b.HasOne("CategoryMovieApp.Models.Actor", "Actor")
                        .WithMany("ActorMovies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CategoryMovieApp.Models.ActorMovie", null)
                        .WithMany("ActorMovies")
                        .HasForeignKey("ActorMovieId1");

                    b.Navigation("Actor");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Comment", b =>
                {
                    b.HasOne("CategoryMovieApp.Models.Movie", "Movie")
                        .WithMany("Comments")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CategoryMovieApp.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Movie", b =>
                {
                    b.HasOne("CategoryMovieApp.Models.Actor", "Actor")
                        .WithMany()
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CategoryMovieApp.Models.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CategoryMovieApp.Models.Country", "Country")
                        .WithMany("Movies")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CategoryMovieApp.Models.Language", "Language")
                        .WithMany("Movies")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CategoryMovieApp.Models.Year", "Year")
                        .WithMany("Movies")
                        .HasForeignKey("YearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Category");

                    b.Navigation("Country");

                    b.Navigation("Language");

                    b.Navigation("Year");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Actor", b =>
                {
                    b.Navigation("ActorMovies");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.ActorMovie", b =>
                {
                    b.Navigation("ActorMovies");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Category", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Country", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Language", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Movie", b =>
                {
                    b.Navigation("Actors");

                    b.Navigation("Comments");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.User", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("CategoryMovieApp.Models.Year", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
