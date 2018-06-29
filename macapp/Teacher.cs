using System;
namespace macapp
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override float ComputeGradeAverage()
        {
            return 0.0f;
        }
    }
}
