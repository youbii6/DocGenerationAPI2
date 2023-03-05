using DocGenerationAPI2.Entites;
using Microsoft.EntityFrameworkCore;

namespace DocGenerationAPI2.DbContexts
{
    public class DocGenerationAPI2Context : DbContext
    {
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Invoice> Invoices { get; set; } = null!;
        public DbSet<InvoiceLine> InvoiceLines { get; set; } = null!;
        public DbSet<Service> Services { get; set; } = null!;
        public DbSet<Template> Templates { get; set; } = null!;


        public DocGenerationAPI2Context(DbContextOptions<DocGenerationAPI2Context> options)
          : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client("client 1")
                {
                    Id = 1,
                  
                },
                new Client("client 2")
                {
                    Id = 2,
                   
                },
                new Client("client 3")
                {
                    Id = 3,
                   
                });

            modelBuilder.Entity<Invoice>().HasData(
                new Invoice("invoice 1")
                {
                    Id = 1,
                    ClientId= 1,

                },
                new Invoice("invoice 2")
                {
                    Id = 2,
                    ClientId = 1,

                },
                new Invoice("invoice 3")
                {
                    Id = 3,
                    ClientId = 2,

                }, 
                new Invoice("invoice 4")
                {
                    Id = 4,
                    ClientId = 2,

                }, 
                new Invoice("invoice 5")
                {
                    Id = 5,
                    ClientId = 3,

                });


            modelBuilder.Entity<InvoiceLine>().HasData(
                new InvoiceLine(3)
                {
                    Id = 1,
                    ServiceId = 2,
                    InvoiceId = 1

                },
                new InvoiceLine(1)
                {
                    Id = 2,
                    ServiceId = 3,
                    InvoiceId = 1


                },
                new InvoiceLine(2)
                {
                    Id = 3,
                    ServiceId = 1,
                    InvoiceId = 1


                },
                new InvoiceLine(2)
                {
                    Id = 4,
                    ServiceId = 1,
                    InvoiceId = 1


                },
                new InvoiceLine(2)
                {
                    Id = 5,
                    ServiceId = 1,
                    InvoiceId = 2


                },
                new InvoiceLine(2)
                {
                    Id = 6,
                    ServiceId = 1,
                    InvoiceId = 2


                },
                new InvoiceLine(2)
                {
                    Id = 7,
                    ServiceId = 1,
                    InvoiceId = 3


                },
                new InvoiceLine(2)
                {
                    Id = 8,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 9,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 10,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 11,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 12,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 13,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 14,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 15,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 16,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 17,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 18,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 19,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 20,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id =21,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 22,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 23,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 24,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 25,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 26,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 27,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 28,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 29,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 30,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 31,
                    ServiceId = 1,
                    InvoiceId = 3


                }, new InvoiceLine(2)
                {
                    Id = 32,
                    ServiceId = 1,
                    InvoiceId = 3


                });
            modelBuilder.Entity<Service>().HasData(
                new Service("Provider x",30)
                {
                    Id = 1,

                },
                new Service("Provider x", 40)
                {
                    Id = 2,

                },
                new Service("Provider y",30)
                {
                    Id = 3,

                },
                new Service("Provider y", 40)
                {
                    Id = 4,

                },
                new Service("Provider z", 20)
                {
                    Id = 5,

                },
                new Service("Provider z", 85)
                {
                    Id = 6,

                });
            base.OnModelCreating(modelBuilder);



        }
    }
}
