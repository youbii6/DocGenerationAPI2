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
    [Migration("20230215154612_MoreSeeding")]
    partial class MoreSeeding
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 1,
                            CreationDate = new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9543),
                            Name = "invoice 1"
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 1,
                            CreationDate = new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9545),
                            Name = "invoice 2"
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 2,
                            CreationDate = new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9546),
                            Name = "invoice 3"
                        },
                        new
                        {
                            Id = 4,
                            ClientId = 2,
                            CreationDate = new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9547),
                            Name = "invoice 4"
                        },
                        new
                        {
                            Id = 5,
                            ClientId = 3,
                            CreationDate = new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9548),
                            Name = "invoice 5"
                        });
                });

            modelBuilder.Entity("DocGenerationAPI2.Entites.InvoiceLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Qte")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ServiceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("InvoiceLines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InvoiceId = 1,
                            Qte = 3,
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 2,
                            InvoiceId = 1,
                            Qte = 1,
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 3,
                            InvoiceId = 1,
                            Qte = 2,
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 4,
                            InvoiceId = 1,
                            Qte = 2,
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 5,
                            InvoiceId = 2,
                            Qte = 2,
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 6,
                            InvoiceId = 2,
                            Qte = 2,
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 7,
                            InvoiceId = 3,
                            Qte = 2,
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 8,
                            InvoiceId = 3,
                            Qte = 2,
                            ServiceId = 1
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 30,
                            Provider = "Provider x"
                        },
                        new
                        {
                            Id = 2,
                            Price = 40,
                            Provider = "Provider x"
                        },
                        new
                        {
                            Id = 3,
                            Price = 30,
                            Provider = "Provider y"
                        },
                        new
                        {
                            Id = 4,
                            Price = 40,
                            Provider = "Provider y"
                        },
                        new
                        {
                            Id = 5,
                            Price = 20,
                            Provider = "Provider z"
                        },
                        new
                        {
                            Id = 6,
                            Price = 85,
                            Provider = "Provider z"
                        });
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
                    b.HasOne("DocGenerationAPI2.Entites.Invoice", "Invoice")
                        .WithMany("invoiceLines")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DocGenerationAPI2.Entites.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

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