using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taxi.Web.Data.Entities
{
    public class TaxiEntity
    {
        public int Id { get; set; }

        [StringLength(6, MinimumLength = 6, ErrorMessage = "El campo {0} nopuede tener menos de {1} caracter")]
        [RegularExpression(@"^([A-Za-z]{3}\d{3})$",ErrorMessage ="El campo {0} debe tener 3 caracteres y 3 numeros")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Patente { get; set; }
    }
}
