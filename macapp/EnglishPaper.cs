﻿using System;
namespace macapp
{
    public class EnglishPaper : IScored
    {
        public string Title { get; set; }
        public int MinimumWordCount { get; set; }
        public string PaperText { get; set; }
        public int WordCount {
            get { return PaperText.WordCount(); }
        }
        public float Score { get; set; }
        public float MaximumScore { get; set; }
    }
}
