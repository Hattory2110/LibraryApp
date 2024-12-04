using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApp.Shared;

public class Olvaso
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid OSz { get; set; }

    [Required] 
    public string Name { get; set; }

    [Required] 
    public string Address { get; set; }

    [Range(typeof(DateOnly), "1900-01-01", "2000-12-31")]
    public DateOnly BirthDate { get; set; }
}