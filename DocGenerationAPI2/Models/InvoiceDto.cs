
using DocGenerationAPI2.Entites;

namespace DocGenerationAPI2.Models
{
    public class InvoiceDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateTime CreationDate { get; set; }
        public int ClientId { get; set; }

        public int NumberOfInvoiceLines
        {
            get
            {
                return InvoiceLines.Count;
            }
        }




        public ICollection<InvoiceLineDto> InvoiceLines { get; set; }
         = new List<InvoiceLineDto>();


    }
}
