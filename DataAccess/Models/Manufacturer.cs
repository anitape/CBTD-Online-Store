using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Manufacturer
    {
        [Key]
		[DisplayName("Manufacturer Name")]
		public int ManufacturerId { get; set; }

        public string ManufacturerName { get; set; }


    }
}
