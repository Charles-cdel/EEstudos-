using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppAlunos.Models;

public class Aluno{
    
    [Key]
    public int Id {get; set;}

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(30, MinimumLength = 2, 
    ErrorMessage = "O campo {0} precisa estar entre {1} e {2} caracteres")]
    public string? Nome {get; set;}

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [DataType(DataType.DateTime, ErrorMessage = "O campo {0} está em formato incorreto")]
    [Display(Name = "Data de Nascimento")]

    public DateTime DatadeNascimento {get; set;}

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(60, MinimumLength = 2, 
    ErrorMessage = "O campo {0} precisa ter no máximo {1} caracteres")] 
    [RegularExpression (@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", 
    ErrorMessage = "O campo {0} está em formato inválido.")]
    public string? Email {get; set;}


    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [Display(Name = "Confirme o e-mail")]
    [Compare("Email" , ErrorMessage = "Os e-mails não correspondem")]
    [NotMapped]
    public string? ConfirmarEmail {get; set;}
}