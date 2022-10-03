using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlDePersonal.Models;

public class Persona
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id_persona")]
    [Display(Name ="Id Persona")]
    public int intIdPersona { get; set;}

    [Display(Name ="Nombres")]
    [StringLength(150)]
    [Required(ErrorMessage ="{0} es obligatorio")]
    [Column("txt_nombre")]
    public string strNombre { get; set; }

    [Display(Name ="Apellidos")]
    [StringLength(150)]
    [Required(ErrorMessage ="{0} es obligatorio")]
    [Column("txt_apellido")]
    public string strApellido { get; set;}

    [Display(Name ="Fecha de Nacimiento")]
    [Required(ErrorMessage ="{0} es obligatorio")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
    [Column("fec_nac")]
    public DateTime dateFecNacimiento { get; set; }

    [Display(Name ="CUI")]
    [Required(ErrorMessage ="{0} es obligatorio")]
    [Column("cui")]
    public double dblCUI { get; set; }

    [Display(Name ="NIT")]
    [Required(ErrorMessage ="{0} es obligatorio")]
    [Column("nit")]
    public string strNIT { get; set; }

    [ForeignKey("Genero")]
    [Display(Name ="Género")]
    [Column("id_genero")]
    public int intIdGenero { get; set; } 
}
