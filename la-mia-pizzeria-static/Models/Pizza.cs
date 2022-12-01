using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }

        

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
