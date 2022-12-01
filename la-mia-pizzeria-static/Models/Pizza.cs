using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "E' obbligatorio inserire il nome della pizza")]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        [Required(ErrorMessage = "E' obbligatorio inserire la descrizione della pizza")]
        public string Description { get; set; }
        public string Image { get; set; }

        [Required(ErrorMessage = "E' obbligatorio inserire il prezzo della pizza")]
        public float Price { get; set; }

        public Pizza()
        {

        }

        public Pizza(int id, string name, string description, string image, float price)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Price = price;
        }
    }
}
