using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityHop.Models;

    [Table("shapes")]
public class Shape
{
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("shape_id")]
        public string ShapeId { get; set; }
        [Required]
        [Column("shape_pt_lat")]
        public double ShapePtLat { get; set; }
        [Required]
        [Column("shape_pt_lon")]
        public double ShapePtLon { get; set; }
        [Required]
        [Column("shape_pt_sequence")]
        public int ShapePtSequence { get; set; }
        [Column("shape_dist_traveled")]
        public double? ShapeDistTraveled { get; set; }
        
}
