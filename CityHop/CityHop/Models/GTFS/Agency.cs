using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CityHop.Models.GTFS;

[Table("agency")]
public class Agency
{
    [Key] public int Id { get; set; }

    [Required]
    [MaxLength(64)]
    [Column("agency_id")]
    public string AgencyId { get; set; }
    
    [Required]
    [MaxLength(200)]
    [Column("agency_name")]
    public string AgencyName { get; set; }

    [Required]
    [MaxLength(200)]
    [Column("agency_url")]
    public string AgencyUrl { get; set; }

    [Required]
    [MaxLength(50)]
    [Column("agency_timezone")]
    public string AgencyTimezone { get; set; }

    [MaxLength(10)]
    [Column("agency_lang")]
    public string? AgencyLang { get; set; }

    [MaxLength(50)]
    [Column("agency_phone")]
    public string? AgencyPhone { get; set; }

    [MaxLength(200)]
    [Column("agency_fare_url")]
    public string? AgencyFareUrl { get; set; }
}