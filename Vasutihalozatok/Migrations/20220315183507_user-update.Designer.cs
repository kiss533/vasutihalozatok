﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vasutihalozatok.Entity;

namespace Vasutihalozatok.Migrations
{
    [DbContext(typeof(Datatextcontent))]
    [Migration("20220315183507_user-update")]
    partial class userupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Vasutihalozatok.Entity.City", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("varos")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Varosok");
                });

            modelBuilder.Entity("Vasutihalozatok.Entity.Jaratok", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Tavolsag")
                        .HasColumnType("int");

                    b.Property<int?>("kiidnulo_varosid")
                        .HasColumnType("int");

                    b.Property<int?>("megerkezo_varosid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("kiidnulo_varosid");

                    b.HasIndex("megerkezo_varosid");

                    b.ToTable("Jaratok");
                });

            modelBuilder.Entity("Vasutihalozatok.Entity.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("felhasznalonev")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jelszo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nev")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Felhasznalok");
                });

            modelBuilder.Entity("Vasutihalozatok.Entity.Jaratok", b =>
                {
                    b.HasOne("Vasutihalozatok.Entity.City", "kiidnulo_varos")
                        .WithMany()
                        .HasForeignKey("kiidnulo_varosid");

                    b.HasOne("Vasutihalozatok.Entity.City", "megerkezo_varos")
                        .WithMany()
                        .HasForeignKey("megerkezo_varosid");

                    b.Navigation("kiidnulo_varos");

                    b.Navigation("megerkezo_varos");
                });
#pragma warning restore 612, 618
        }
    }
}