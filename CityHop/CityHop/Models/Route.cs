using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityHop.Models;

[Table("routes")]
public class Route
{
    [Key] public int Id { get; set; }
    [Required] [Column("route_id")] public string RouteId { get; set; }
    [Column("agency_id")] public string? AgencyId { get; set; }
    [Column("route_short_name")] public string RouteShortName { get; set; }
    [Column("route_long_name")] public string RouteLongName { get; set; }
    [Column("route_desc")] public string? RouteDesc { get; set; }
    [Column("route_type")] public int RouteType { get; set; }
    [Column("route_url")] public string? RouteUrl { get; set; }
    [Column("route_color")] public string? RouteColor { get; set; }
}