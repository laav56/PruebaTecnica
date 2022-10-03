using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlDePersonal.Models;

public class Departamento
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id_depto")]
    public int intIdDepto { get; set;}

    [Display(Name ="Nombre Departamento")]
    [StringLength(150)]
    [Required(ErrorMessage ="{0} es obligatorio")]
    [Column("txt_desc")]
    public string strDepartamento { get; set; }

}