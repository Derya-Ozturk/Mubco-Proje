using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mubco_Proje.Models
{
    public class Map
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string CityName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }
    }
}
