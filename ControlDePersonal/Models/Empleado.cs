using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlDePersonal.Models;

public class Empleado
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id_empleado")]
    public int intIdEmpleado { get; set;}

    [ForeignKey("Persona")]
    [Display(Name ="Persona")]
    [Required(ErrorMessage ="{0} es obligatorio")]
    [Column("id_persona")]
    public int intIdPersona { get; set; }

    [ForeignKey("Puesto")]
    [Display(Name ="Puesto")]
    [Required(ErrorMessage ="{0} es obligatorio")]
    [Column("id_puesto")]
    public int intIdPuesto { get; set; }

    [Display(Name ="Fecha de Contratación")]
    [Required(ErrorMessage ="{0} es obligatorio")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
    [Column("fec_contratacion")]
    public DateTime dateFecContratacion { get; set; }

    [Display(Name ="Salario")]
    [Required(ErrorMessage ="{0} es obligatorio")]
    [Column("salario")]
    public decimal dcmSalario { get; set; }

}