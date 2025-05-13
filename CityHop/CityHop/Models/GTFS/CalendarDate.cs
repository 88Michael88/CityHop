using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityHop.Models.GTFS;

[Table("calendar_dates")]
public class CalendarDate
{
    [Key] public int Id { get; set; }

    [Required]
    [MaxLength(64)]
    [Column("service_id")]
    public string ServiceId { get; set; }

    [Required] [Column("date")] public DateTime Date { get; set; }
    [Required] [Column("exception_type")] public int ExceptionType { get; set; }
}