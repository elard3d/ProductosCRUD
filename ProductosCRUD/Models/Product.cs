using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosCRUD.Models
{
    public class Product
    {
        public int id { get; set; }
        [Required(ErrorMessage = "es Obligatorio")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "es Obligatorio")]
        public int categoria { get; set; }
        [Required(ErrorMessage = "es Obligatorio")]
        public string provedor { get; set; }
        [Required]
        public decimal costo { get; set; }
    }
}
