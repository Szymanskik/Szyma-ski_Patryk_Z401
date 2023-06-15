using System.ComponentModel.DataAnnotations;

namespace SystemZarzadzaniaPracownikami.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Pole Imie jest wymagane")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Pole Nazwisko jest wymagane")]
        public string Sname { get; set; }
        [Required(ErrorMessage ="Pole Wiek jest wymagane")]
        public int Wiek { get; set; }
        [Required(ErrorMessage ="Pole Stanowisko jest wymagane")]
        public string Rola { get; set; }

        
    }
}
