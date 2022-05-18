using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArteNaPraia.Models
{
    public class Arte
    {
        [Key]
        public int IdArte { get; set; }
        [Required(ErrorMessage ="O nome da arte é obrigatório")]
        public String  Nome { get; set; }
        [Required(ErrorMessage ="O preço da arte é obrigatório (use 0) caso seja amostra")]
        public float Preco { get; set; }
        public string Descricao { get; set; }   
        [ForeignKey("Artista")]
        public int IdArtista { get; set; }
        public virtual Artista Artista { get; set; }

    }
}