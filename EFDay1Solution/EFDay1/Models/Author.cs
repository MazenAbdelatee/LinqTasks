using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDay1.Models
{
    [Table("Writers")]
    internal class Author
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
