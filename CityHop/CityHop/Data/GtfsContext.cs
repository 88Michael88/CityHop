using CityHop.Models.GTFS;
using Microsoft.EntityFrameworkCore;
using Route = CityHop.Models.GTFS.Route;


namespace CityHop.Data;

public class GtfsContext: DbContext
{
    public GtfsContext(DbContextOptions<GtfsContext> options) : base(options)
    {
    }
    public DbSet<Stop> Stops { get; set; }
    public DbSet<Route> Routes { get; set; }
    public DbSet<Trip> Trips { get; set; }
    public DbSet<StopTime> StopTimes { get; set; }
    public DbSet<Agency> Agencies { get; set; }
    public DbSet<Calendar> Calendars { get; set; }
    public DbSet<CalendarDate> CalendarDates { get; set; }
    public DbSet<Shape> Shapes { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GtfsDb;Trusted_Connection=True;");
        }
    }
}