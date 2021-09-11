
using DayofWeekTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace DayofWeekTest.Data;
public class DayOfWeekContext:DbContext
{
    public DbSet<DaysOfTheWeek> DaysOfTheWeek { get; set; }

    public DayOfWeekContext(DbContextOptions<DayOfWeekContext> options) : base(options)
    {

    }
}
