using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityHop.Models;

[Table("trips")]
public class Trip
{
    [Key] public int Id { get; set; }
    [Required] [Column("trip_id")] public string TripId { get; set; }
    [Column("route_id")] public string RouteId { get; set; }
    [Column("service_id")] public string ServiceId { get; set; }
    [Column("trip_headsign")] public string? TripHeadsign { get; set; }
    [Column("trip_short_name")] public string? TripShortName { get; set; }
    [Column("direction_id")] public int? DirectionId { get; set; }
    [Column("block_id")] public string? BlockId { get; set; }
    [Column("shape_id")] public string? ShapeId { get; set; }
    [Column("wheelchair_accessible")] public int? WheelchairAccessible { get; set; }
}