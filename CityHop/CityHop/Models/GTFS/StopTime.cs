using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityHop.Models.GTFS;

[Table("stop_times")]
public class StopTime
{
    [Key] public int Id { get; set; }
    [Required][MaxLength(64)] [Column("trip_id")] public string TripId { get; set; }
    public int? TripIdNew { get; set; }
    [Required] [MaxLength(8)] [Column("arrival_time")] public string ArrivalTime { get; set; }
    [Required] [MaxLength(8)] [Column("departure_time")] public string DepartureTime { get; set; }
    [Required] [MaxLength(64)] [Column("stop_id")] public string StopId { get; set; }
    public int? StopIdNEW { get; set; }
    [Column("stop_sequence")] public int StopSequence { get; set; }
    [MaxLength(200)] [Column("stop_headsign")] public string? StopHeadsign { get; set; }
    [Column("pickup_type")] public int? PickupType { get; set; }
    [Column("drop_off_type")] public int? DropOffType { get; set; }
    [Column("shape_dist_traveled")] public double? ShapeDistTraveled { get; set; }
    [Column("timepoint")] public int? Timepoint { get; set; }
}