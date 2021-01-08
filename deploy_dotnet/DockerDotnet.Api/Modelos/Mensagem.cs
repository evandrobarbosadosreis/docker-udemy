using System.ComponentModel.DataAnnotations;

namespace DockerDotnet.Api.Modelos
{
    public class Mensagem
    {
        public int Id { get; set; }

        [Required]
        public string Texto { get; set; }
    }
}