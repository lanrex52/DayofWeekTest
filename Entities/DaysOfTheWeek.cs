
using System.Collections.Generic;

namespace DayofWeekTest.Entities;
public class DaysOfTheWeek
{
    public List<OpeningHours> Monday { get; set; } = new List<OpeningHours>();
    public List<OpeningHours> Tuesday { get; set; } = new List<OpeningHours>();
    public List<OpeningHours> Wednesday { get; set; } = new List<OpeningHours>();
    public List<OpeningHours> Thursday { get; set; } = new List<OpeningHours>();
    public List<OpeningHours> Friday { get; set; } = new List<OpeningHours>();
    public List<OpeningHours> Saturday { get; set; } = new List<OpeningHours>();
    public List<OpeningHours> Sunday { get; set; } = new List<OpeningHours>();
}
