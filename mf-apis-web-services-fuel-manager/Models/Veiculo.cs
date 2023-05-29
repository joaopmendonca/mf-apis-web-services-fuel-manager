using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_apis_web_services_fuel_manager.Models
{
    [Table("Veiculos")]

    public class Veiculo
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string marca { get; set; }
        [Required]
        public string modelo { get; set; }
        [Required]
        public string placa { get; set; }
        [Required]
        public int anoFabricacao { get; set; }
        [Required]
        public int anoModelo { get; set; }
        public ICollection<Consumo> Consumos { get; set; }
    }

}
