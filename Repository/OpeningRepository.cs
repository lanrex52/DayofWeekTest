
using DayofWeekTest.Entities;
using System;
using System.Collections.Generic;

namespace DayofWeekTest.Repository;
public class OpeningRepository:IOpeningRepository
{
    public List<string> AddOpeningHour(DaysOfTheWeek model)
    {


        try
        {
            var monday = ComputeForDay(model.Monday);
            var tuesday = ComputeForDay(model.Tuesday);
            var wednesday = ComputeForDay(model.Wednesday);
            var thurday = ComputeForDay(model.Thursday);
            var friday = ComputeForDay(model.Friday);
            var saturday = ComputeForDay(model.Saturday);
            var sunday = ComputeForDay(model.Sunday);

            var data = new List<string>
            {
                $"Monday: {monday}",
                $"Tuesday: {tuesday}",
                $"Wednesday: {wednesday}",
                $"Thurday: {thurday}",
                $"Friday: {friday}",
                $"Saturday: {saturday}",
                $"Sunday: {sunday}"
            };

            return data;
        }
        catch (Exception)
        {
            throw;
        }
    }

    private string ComputeForDay(List<OpeningHours> openingHours)
    {
        var hours = string.Empty;
      
        if (openingHours.Count == 0)
        {
            hours += "closed";
        }

        foreach (var item in openingHours)
        {

           
            if (item.Type.ToLower() == "open")
            {
                

                hours += item.Hours;
            }
            else
            {
                

                if (openingHours[0] == item)
                {
                    hours += $"{item.Hours}, ";
                }
                else
                {
                    hours += $" - {item.Hours}";
                }

            }

        }

        return hours;
    }
}
