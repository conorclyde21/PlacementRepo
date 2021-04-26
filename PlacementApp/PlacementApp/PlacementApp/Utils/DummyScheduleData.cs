using System;
using System.Collections.Generic;
using PlacementApp.Models;

namespace PlacementApp.Utils
{
    public static class DummyScheduleData
    {
        public static List<Schedule> GetSchedules()
        {
            var data = new List<Schedule>();
            var person = new Schedule()
            {
                WorkDay = "Monday",
                WorkStartTime = "09:00",
                WorkEndTime = "14:00"
            };

            for (int i = 0; i < 7; i++)
            {
                data.Add(person);

            }
            return data;
        }
    }
}