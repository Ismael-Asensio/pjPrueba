using System.ComponentModel.DataAnnotations;

namespace pjPrueba.Models
{
    public class Details
    {
        [Key]
        public int ProductTypeID { get; set; }

        public int ProductWeight { get; set; }

        public string? ProductSection { get; set; }

        public List<Products> Products { get; set; }
    }
}