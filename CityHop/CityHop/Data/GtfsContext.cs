using CityHop.Models;
using Microsoft.EntityFrameworkCore;


namespace CityHop.Data;

public class GtfsContext(DbContextOptions<GtfsContext> options) : DbContext(options)
{
    public DbSet<Stop> Stops { get; set; }
    public DbSet<Models.Route> Routes { get; set; }
    public DbSet<Trip> Trips { get; set; }
    public DbSet<StopTime> StopTimes { get; set; }
    public DbSet<Agency> Agencies { get; set; }
    public DbSet<Calendar> Calendars { get; set; }
    public DbSet<Shape> Shapes { get; set; }
}