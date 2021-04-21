using System;
namespace PlacementApp.Models
{
    public class Schedule
    {
        public string ScheduleID { get; set; }
        public string PlacementID { get; set; }
        public string WorkDate { get; set; }
        public string WorkStartTime { get; set; }
        public string WorkEndTime { get; set; }
    }
}