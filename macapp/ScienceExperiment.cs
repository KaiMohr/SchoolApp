using System;
namespace macapp
{
    public class ScienceExperiment : IScored
    {
        public string Hypothesis { get; set; }
        public string Materials { get; set; }
        public string Method { get; set; }
        public string Conclusion { get; set; }
        public float Score { get; set; } // definded by 
        public float MaximumScore { get; set; } // the Iscored interface
    }
}
