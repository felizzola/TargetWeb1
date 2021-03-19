using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TargetWeb1.Models
{
    public class Articulo
    {

        public Guid Id { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "FechaAlta")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy H:mm}")]
        public DateTime FechaAlta { get; set; }

        [Required(ErrorMessage = "El campo {0} es mandatorio")]
        [MaxLength(200, ErrorMessage = "El campo {0} admite un máximo de {1} caracteres")]
        [Url(ErrorMessage = "El campo {0} debe ser una url válida")]
        [Display(Name = "Url")]
        public string UrlImagen { get; set; }


      
        [Required(ErrorMessage ="El código es requerido")]
        [MaxLength(8, ErrorMessage = "El código debe ser de 8 dígitos")]
        [Display(Name = "Codigo")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El Nombre es requerido")]
        [MaxLength(30, ErrorMessage = "Máximo de caracteres: 30")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar una descripción del artículo")]
        [MaxLength(120, ErrorMessage = "Máximo 120 caracteres")]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Sock en unidades: es requerido")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres")]
        [Display(Name = "StockUnidades")]
        public int StockUnidades { get; set; }

        [Required(ErrorMessage = "Stock en Bultos: es requerido")]
        [MaxLength(30, ErrorMessage = "Máximo de caracteres: 30")]
        [Display(Name = "StockEnBulto")]
        public int StockEnBulto { get; set; }

        [Required(ErrorMessage = "Debe sugerir un precio minorístas")]
        [MaxLength(30, ErrorMessage = "Máximo de caracteres: 30")]
        [Display(Name = "PrecioSugMinorista")]
        public decimal PrecioSugMinorista { get; set; }

        [Required(ErrorMessage = "Debe sugerir un precio mayorísta")]
        [MaxLength(30, ErrorMessage = "Máximo de caracteres: 30")]
        [Display(Name = "PrecioSugMayorista")]
        public decimal PrecioSugMayorista { get; set; }

        [Required(ErrorMessage = "Debe sugerir un precio para la plataforma de MercadoLibre")]
        [MaxLength(30, ErrorMessage = "Máximo de caracteres: 30")]
        [Display(Name = "PrecioSugMeLi")]
        public decimal PrecioSugMeLi { get; set; }

    }
}
