﻿// <auto-generated />
using System;
using LoomAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoomAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230307205057_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("LoomAPI.Models.Tear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Eficiencia")
                        .HasColumnType("TEXT");

                    b.Property<int>("FimDeTrama")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("QuebraDeTrama")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuebraDeUrdume")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TempoLigado")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TempoParado")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teares");
                });
#pragma warning restore 612, 618
        }
    }
}
