
using System.Text.Json.Serialization;

namespace DayofWeekTest.Entities;
public class OpeningHours
{
    public string Type { get; set; }
   
    public Double Value { get; set; }

    public string Hours
    {
        get
        {
            string hours;
           DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(Value).ToLocalTime();
            hours = dtDateTime.ToString("H:mm tt");
            return hours;
        }

    }

}
