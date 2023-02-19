using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DocGenerationAPI2.Entites
{
    public class InvoiceLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Qte { get; set; } = 1;
   

        [ForeignKey("ServiceId")]
        public Service? Service { get; set; }
        public int ServiceId { get; set; }

        [ForeignKey("InvoiceId")]
        public Invoice? Invoice { get; set; }
        public int InvoiceId { get; set; }



        public InvoiceLine(int qte)
        {
            Qte = qte;

        }

    }

    
   
}
