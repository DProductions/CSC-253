/**
* 10 SEP 2023Date
* CSC 253
* Daniel Parks
* Course Information / Dictionaries 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CourseInformation
{
    public class CourseDictionary
    {
        private Dictionary<string, (string room, string instructor, string time)> courseInfo;

        public CourseDictionary()
        {
            // Course Information dictionary
            courseInfo = new Dictionary<string, (string, string, string)>
            {
                { "CS101", ("3004", "Haynes", "8:00AM") },
                { "CS102", ("4501", "Alvarado", "9:00AM") },
                { "CS103", ("6755", "Rich", "10:00AM") },
                { "NT110", ("1244", "Burke", "11:00AM") },
                { "CM241", ("1411", "Lee", "1:00PM") }
            };
        }

        public bool TryGetCourseInfo(string courseCode, out (string room, string instructor, string time) info)
        {
            return courseInfo.TryGetValue(courseCode, out info);
        }

        public IEnumerable<string> GetAvailableCourses()
        {
            return courseInfo.Keys;
        }
    }
}