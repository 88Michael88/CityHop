using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityHop.Models;

//Database naming GTFS standard accurate
[Table("stops")]
public class Stop
{
    [Key] public int Id { get; set; }
    [Required] [Column("stop_id")] public string StopId { get; set; }
    [Column("stop_code")] public string? StopCode { get; set; }
    [Column("stop_desc")] public string? StopDesc { get; set; }
    [Column("stop_lat")] public double StopLat { get; set; }
    [Column("stop_lon")] public double StopLon { get; set; }
    [Column("zone_id")] public string? ZoneId { get; set; }
    [Column("stop_url")] public string? StopUrl { get; set; }
    [Column("location_type")] public int? LocationType { get; set; }
    [Column("parent_station")] public string? ParentStation { get; set; }
    [Column("stop_timezone")] public string? StopTimezone { get; set; }
    [Column("wheelchair_boarding")] public int? WheelchairBoarding { get; set; }
}