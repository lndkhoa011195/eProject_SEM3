//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineAptitudeTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Score
    {
        public int ScoreID { get; set; }
        public int CandidateID { get; set; }
        public double Part1Score { get; set; }
        public double Part2Score { get; set; }
        public double Part3Score { get; set; }
    
        public virtual Candidate Candidate { get; set; }
    }
}
