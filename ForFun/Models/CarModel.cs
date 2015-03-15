
using System.ComponentModel;
namespace CodeForFun.Models
{
    public class CarModel
    {
        [DisplayName( "Make" )]
        public string Make { get; set; }

        [DisplayName( "Model" )]
        public string Model { get; set; }

        [DisplayName( "Year" )]
        public string Year { get; set; }

        [DisplayName( "Color" )]
        public string Color { get; set; }
    }

}