
using DayofWeekTest.Entities;
using System.Collections.Generic;

namespace DayofWeekTest.Repository;
public interface IOpeningRepository
{
    List<string> AddOpeningHour(DaysOfTheWeek model);
    
}
