using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DocGenerationAPI2.Entites
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<InvoiceLine> InvoiceLines { get; set; }
         = new List<InvoiceLine>();


        public DateTime CreationDate { get; set; } = DateTime.UtcNow;


        [ForeignKey("ClientId")]
        public Client? Client { get; set; }
        public int ClientId { get; set; }




        public Invoice(string name)
        {
            Name = name;
        }
    }
}

