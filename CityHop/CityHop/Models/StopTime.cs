using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityHop.Models;

[Table("stop_times")]
public class StopTime
{
    [Key] public int Id { get; set; }
    [Required] [Column("trip_id")] public string TripId { get; set; }
    [Required] [Column("arrival_time")] public string ArrivalTime { get; set; }
    [Required] [Column("departure_time")] public string DepartureTime { get; set; }
    [Required] [Column("stop_id")] public string StopId { get; set; }
    [Column("stop_sequence")] public int StopSequence { get; set; }
    [Column("stop_headsign")] public string? StopHeadsign { get; set; }
    [Column("pickup_type")] public int? PickupType { get; set; }
    [Column("drop_off_type")] public int? DropOffType { get; set; }
    [Column("shape_dist_traveled")] public double? ShapeDistTraveled { get; set; }
    [Column("timepoint")] public int? Timepoint { get; set; }
}