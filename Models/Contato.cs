using System.ComponentModel.DataAnnotations;

namespace AgendaContatos.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Telefone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public string Sexo { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }
    }
}
