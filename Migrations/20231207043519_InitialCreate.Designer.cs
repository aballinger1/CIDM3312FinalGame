﻿// <auto-generated />
using AnotherNightmare.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CIDM3312FinalGame.Migrations
{
    [DbContext(typeof(GameContext))]
    [Migration("20231207043519_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("AnotherNightmare.Models.Choice", b =>
                {
                    b.Property<int>("ChoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("NextSceneID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SceneID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("ChoiceID");

                    b.HasIndex("SceneID");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("AnotherNightmare.Models.Scene", b =>
                {
                    b.Property<int>("SceneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("SceneID");

                    b.ToTable("Scenes");
                });

            modelBuilder.Entity("AnotherNightmare.Models.Choice", b =>
                {
                    b.HasOne("AnotherNightmare.Models.Scene", "Scene")
                        .WithMany("Choices")
                        .HasForeignKey("SceneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Scene");
                });

            modelBuilder.Entity("AnotherNightmare.Models.Scene", b =>
                {
                    b.Navigation("Choices");
                });
#pragma warning restore 612, 618
        }
    }
}
