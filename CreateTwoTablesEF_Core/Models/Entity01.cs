using System.ComponentModel.DataAnnotations;

namespace CreateTwoTablesEF_Core.Models
{
    public class Entity01
    {
        [Key]
        public int Entity01_Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Add other properties as needed
    }
}








