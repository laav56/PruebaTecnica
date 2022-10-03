using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlDePersonal.Models;

public class Puesto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id_puesto")]
    public int intIdPuesto { get; set;}

    [Display(Name ="Puesto")]
    [StringLength(150)]
    [Required(ErrorMessage ="{0} es obligatorio")]
    [Column("txt_desc")]
    public string strPruesto { get; set; }

    [ForeignKey("Departamento")]
    [Display(Name ="Departamento")]
    [Required(ErrorMessage ="{0} es obligatorio")]
    [Column("id_depto")]
    public int intIdDepto { get; set; }

}