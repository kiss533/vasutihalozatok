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
    [Migration("20220215154901_table-creating")]
    partial class tablecreating
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

                    b.ToTable("City");
                });

            modelBuilder.Entity("Vasutihalozatok.Entity.Jaratok", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("idotartalom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("kiidnulo_varosid")
                        .HasColumnType("int");

                    b.Property<int?>("megerkezo_varosid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("kiidnulo_varosid");

                    b.HasIndex("megerkezo_varosid");

                    b.ToTable("Jaratok");
                });

            modelBuilder.Entity("Vasutihalozatok.Entity.Jaratok", b =>
                {
                    b.HasOne("Vasutihalozatok.Entity.City", "kiidnulo_varos")
                        .WithMany("osszjarat")
                        .HasForeignKey("kiidnulo_varosid");

                    b.HasOne("Vasutihalozatok.Entity.City", "megerkezo_varos")
                        .WithMany()
                        .HasForeignKey("megerkezo_varosid");

                    b.Navigation("kiidnulo_varos");

                    b.Navigation("megerkezo_varos");
                });

            modelBuilder.Entity("Vasutihalozatok.Entity.City", b =>
                {
                    b.Navigation("osszjarat");
                });
#pragma warning restore 612, 618
        }
    }
}
