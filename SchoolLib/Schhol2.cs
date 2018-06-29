using System;
using System.Text;
namespace macapp;


{
    public class SchoolLibClass
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            // make sure twitter address starts with @
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The Twitter address must begin with @");
                }
            }
        }
        public School()
        {
            Name = "Untiled School";
            PhoneNumber = "555-1234";
        }

        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        // Same as above but as a function body expression new since c# version 6
        // for very simple returns

        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.AppendLine(City);
            sb.AppendLine(" , ");
            sb.AppendLine(State);
            sb.AppendLine("  ");
            sb.AppendLine(Zip);

            return base.ToString();
        }
    }
}