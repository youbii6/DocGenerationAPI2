using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DocGenerationAPI2.Entites
{
    public class Template
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


        [ForeignKey("ClientId")]
        public Client? Clinet { get; set; }
        public int ClinetId { get; set; }


        public Template(string name)
        {
            Name= name;

        }

    }
}
