using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityHop.Models;

[Table("agency")]
public class Agency
{
    [Key] public int Id { get; set; }
    [Required] [Column("agency_id")] public string AgencyId { get; set; }
    [Required] [Column("agency_name")] public string AgencyName { get; set; }
    [Required] [Column("agency_url")] public string AgencyUrl { get; set; }
    [Required] [Column("agency_timezone")] public string AgencyTimezone { get; set; }
    [Column("agency_lang")] public string? AgencyLang { get; set; }
    [Column("agency_phone")] public string? AgencyPhone { get; set; }
    [Column("agency_fare_url")] public string? AgencyFareUrl { get; set; }
}