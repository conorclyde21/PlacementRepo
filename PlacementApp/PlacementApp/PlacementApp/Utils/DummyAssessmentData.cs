using System;
using System.Collections.Generic;
using PlacementApp.Models;

namespace PlacementApp.Utils
{
    public static class DummyAssessmentData
    {
        public static List<Assessment> GetAssessments()
        {
            var data = new List<Assessment>();
            var person = new Assessment()
            {
                AssessmentID = "1",
                AssessmentDate = "2020-09-11",
                AssessmentType = "Knowledge",
                AssessmentScore = "4"
            };

            for (int i = 0; i < 7; i++)
            {
                data.Add(person);
            }
            return data;
        }
    }
}