using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandUpdateDto
    {
        //public int Id { get; set; } It creates by the DB

        [Required]//Indicates CommType is a NOT NULL field for the reference of EF Core Migration
        [MaxLength(50)]//Indicated CommType variable size is 250 EF Core Migration
        public string CommType { get; set; }

        [Required]//Indicated CommString is a required field for the reference of EF Core Migration
        //[MaxLength(250)]//Indicated CommString variable size is 250 EF Core Migration
        public string CommString { get; set; }

        [Required]//Indicated Platform is a required field for the reference of EF Core Migration
        //[MaxLength(50)]//Indicated Platform variable size is 250 EF Core Migration
        public string Platform { get; set; }

    }
}