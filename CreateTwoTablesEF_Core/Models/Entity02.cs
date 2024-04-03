using System.ComponentModel.DataAnnotations;

namespace CreateTwoTablesEF_Core.Models
{
    public class Entity02
    {
        [Key]
        public int Entity02_Id { get; set; }

        [Required]
        public string Description { get; set; }

        // Add other properties as needed
    }
}








