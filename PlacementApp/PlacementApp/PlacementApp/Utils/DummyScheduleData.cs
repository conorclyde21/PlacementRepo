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
                ScheduleID = "1",
                PlacementID = "1",
                WorkDate = "2020-09-04",
                WorkStartTime = "09:00:00.0000000",
                WorkEndTime = "14:00:00.0000000"
            };

            for (int i = 0; i < 10; i++)
            {
                data.Add(person);

            }
            return data;
        }
    }
}