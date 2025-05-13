using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityHop.Models.GTFS;

[Table("trips")]
public class Trip
{
    [Key] public int Id { get; set; }
    [Required][MaxLength(64)] [Column("trip_id")] public string TripId { get; set; }
    [Required][MaxLength(64)][Column("route_id")] public string RouteId { get; set; }
    public int? RouteIdNEW { get; set; }
    [Required][MaxLength(64)][Column("service_id")] public string ServiceId { get; set; }
    public int? ServiceIdNEW { get; set; }
    [Required][MaxLength(64)][Column("trip_headsign")] public string? TripHeadsign { get; set; }
    [MaxLength(4)][Column("trip_short_name")] public string? TripShortName { get; set; }
    [Column("direction_id")] public int? DirectionId { get; set; }
    [Column("block_id")] public string? BlockId { get; set; }
    [Required][MaxLength(64)][Column("shape_id")] public string? ShapeId { get; set; }
    public int ShapeIdNEW { get; set; }
    [Column("wheelchair_accessible")] public int? WheelchairAccessible { get; set; }
}