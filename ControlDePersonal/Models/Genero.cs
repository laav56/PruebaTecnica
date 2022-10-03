using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlDePersonal.Models;

public class Genero
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id_genero")]
    public int intIdGenero { get; set;}

    [Display(Name ="Género")]
    [StringLength(30)]
    [Required(ErrorMessage ="{0} es obligatorio")]
    [Column("txt_desc")]
    public string strGenero { get; set; }

}