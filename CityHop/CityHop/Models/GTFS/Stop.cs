using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityHop.Models.GTFS;

//Database naming GTFS standard accurate
[Table("stops")]
public class Stop
{
    [Key] public int Id { get; set; }
    [Required][MaxLength(64)] [Column("stop_id")] public string StopId { get; set; }
    [MaxLength(32)][Column("stop_code")] public string? StopCode { get; set; }
    [MaxLength(32)][Column("stop_desc")] public string? StopDesc { get; set; }
    [Column("stop_lat")] public double StopLat { get; set; }
    [Column("stop_lon")] public double StopLon { get; set; }
    [MaxLength(32)][Column("zone_id")] public string? ZoneId { get; set; }
    [MaxLength(100)][Column("stop_url")] public string? StopUrl { get; set; }
    [Column("location_type")] public int? LocationType { get; set; }
    [MaxLength(64)][Column("parent_station")] public string? ParentStation { get; set; }
    [MaxLength(40)][Column("stop_timezone")] public string? StopTimezone { get; set; }
    [Column("wheelchair_boarding")] public int? WheelchairBoarding { get; set; }
}