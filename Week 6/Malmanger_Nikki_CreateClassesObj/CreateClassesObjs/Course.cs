using System.Configuration;

namespace CreateClassesObjs
{
    internal class Course
    {
        private string courseName;

        // constructor method
        public Course()
        {
            courseName = "";
        }
        
        // sets course name of object to the inputted name
        public void SetName(string incCourseName)
        {
            courseName = incCourseName;
        }

        // gets course name
        public string GetName()
        {
            return courseName;
        }

        // returns name as string (since it's already string we don't cast or parse anything)
        public override string ToString()
        {
            return GetName();
        }
    }
}