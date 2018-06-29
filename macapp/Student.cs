using System;
namespace macapp
{
    public class Student : Person
    {
        public enum GradeLevels { Freshman, Sophomore, Junior, Senior}
        public GradeLevels GradeLevel { get; set; }

        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }
    }
}
