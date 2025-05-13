using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CityHop.Models.GTFS;

[Table("calendar")]
public class Calendar
{
    [Key] public int Id { get; set; }

    [Required]
    [MaxLength(64)]
    [Column("service_id")]
    public required string ServiceId { get; set; }
    [Required] [Column("monday")] public bool Monday { get; set; }
    [Required] [Column("tuesday")] public bool Tuesday { get; set; }
    [Required] [Column("wednesday")] public bool Wednesday { get; set; }
    [Required] [Column("thursday")] public bool Thursday { get; set; }
    [Required] [Column("friday")] public bool Friday { get; set; }
    [Required] [Column("saturday")] public bool Saturday { get; set; }
    [Required] [Column("sunday")] public bool Sunday { get; set; }
    [Required] [Column("start_date")] public DateTime StartDate { get; set; }
    [Required] [Column("end_date")] public DateTime EndDate { get; set; }
}