using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_apis_web_services_fuel_manager.Models
{
    [Table("Consumos")]

    public class Consumo    {
   
        [Key]
        public int id { get; set; }
        [Required]
        public string descricao { get; set; }
        [Required]
        public DateTime data { get; set; }
        [Required]
        public decimal valor { get; set; }
        [Required]
        public TipoCombustivel MyProperty { get; set; }
        [Required]
        public int veiculoId { get; set; }
        [Required]
        public Veiculo veiculo{ get; set; }
    }

    public enum TipoCombustivel{
        diesel,
        etanol,
        gasolina
    }
}
