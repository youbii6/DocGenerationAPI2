﻿// <auto-generated />
using System;
using DocGenerationAPI2.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DocGenerationAPI2.Migrations
{
    [DbContext(typeof(DocGenerationAPI2Context))]
    [Migration("20230215144252_seedData")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("DocGenerationAPI2.Entites.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "client 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "client 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "client 3"
                        });
                });

            modelBuilder.Entity("DocGenerationAPI2.Entites.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("DocGenerationAPI2.Entites.InvoiceLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Qte")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ServiceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("InvoiceLines");
                });

            modelBuilder.Entity("DocGenerationAPI2.Entites.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("DocGenerationAPI2.Entites.Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClinetId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("DocGenerationAPI2.Entites.Invoice", b =>
                {
                    b.HasOne("DocGenerationAPI2.Entites.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("DocGenerationAPI2.Entites.InvoiceLine", b =>
                {
                    b.HasOne("DocGenerationAPI2.Entites.Invoice", null)
                        .WithMany("invoiceLines")
                        .HasForeignKey("InvoiceId");

                    b.HasOne("DocGenerationAPI2.Entites.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");
                });

            modelBuilder.Entity("DocGenerationAPI2.Entites.Template", b =>
                {
                    b.HasOne("DocGenerationAPI2.Entites.Client", "Clinet")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.Navigation("Clinet");
                });

            modelBuilder.Entity("DocGenerationAPI2.Entites.Invoice", b =>
                {
                    b.Navigation("invoiceLines");
                });
#pragma warning restore 612, 618
        }
    }
}
