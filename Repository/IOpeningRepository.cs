
using DayofWeekTest.Entities;

namespace DayofWeekTest.Repository;
public interface IOpeningRepository
{
    List<string> AddOpeningHour(DaysOfTheWeek model);
    
}
