using DocGenerationAPI2.Entites;

namespace DocGenerationAPI2.Models
{
    public class InvoiceLineDto
    {
        public int Id { get; set; }
        public int Qte { get; set; }
        public int ServiceId { get; set; }
        public int PageNumber { get; set; } 

        public Service Service { get; set; }

        

       
    }
}
