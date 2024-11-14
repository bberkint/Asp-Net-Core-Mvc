using System.Collections.Generic;

namespace ViewStructure.Models
{
    public class WorkChart
    {

        public WorkChart(string _teacherName, List<bool> _chart) { 
            TeacherName = _teacherName;
            Chart = _chart; 
        }

        public string TeacherName { get; set; }
        public List<bool> Chart { get; set; }
    }
}
