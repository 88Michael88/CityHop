using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityHop.Models.GTFS;

[Table("routes")]
public class Route
{
    [Key] public int Id { get; set; }
    [Required] [MaxLength(64)] [Column("route_id")] public string RouteId { get; set; }
    [MaxLength(32)] [Column("agency_id")] public string? AgencyId { get; set; }
    public int? AgencyIdNEW { get; set; }
    [MaxLength(16)] [Column("route_short_name")] public string RouteShortName { get; set; }
    [MaxLength(32)] [Column("route_long_name")] public string? RouteLongName { get; set; }
    [MaxLength(32)] [Column("route_desc")] public string? RouteDesc { get; set; }
    [Column("route_type")] public int RouteType { get; set; }
    [MaxLength(32)] [Column("route_url")] public string? RouteUrl { get; set; }
    [MaxLength(6)] [Column("route_color")] public string? RouteColor { get; set; }
}