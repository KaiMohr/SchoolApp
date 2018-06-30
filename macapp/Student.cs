using System;
using System.Text;
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
        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder();
            sb.AppendLine(original);
            sb.AppendLine(" This Message is privat and confidential");
            return sb.ToString();
        }
    }
}
