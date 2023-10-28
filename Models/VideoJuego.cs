using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    
    public class VideoJuego
    {
        [Key]
        public int idVideoJuego { get; set; }
        public string Nombre { get; set; }
        public string tipoDePago { get; set; }
        public bool esGrupal { get; set; }
        public string tipo { get; set; }
        public int idUsuario { get; set; }
        
    }
   
}