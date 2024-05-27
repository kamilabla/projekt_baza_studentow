using System.ComponentModel.DataAnnotations;


namespace MvcStrona.Models
{
    public class Pracownik
    {
        [Key]
        public int IDpracownika { get; set; }
        [Display(Name = "Imię")]
        public String Imie { get; set; }
        [Display(Name = "Nazwisko")]
        public String Nazwisko { get; set; }
        [Display(Name = "Płaca")]
        public int Placa { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data zatrudnienia")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataZatrudnienia { get; set; }

    }
}