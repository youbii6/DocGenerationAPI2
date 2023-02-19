using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DocGenerationAPI2.Entites
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Provider { get; set; }
        public int  Price { get; set; }

       

        public Service(string provider,int price)
        {
            Provider = provider;
            Price = price;
        }
    }
}
