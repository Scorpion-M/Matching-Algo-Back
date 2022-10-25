﻿
using MatchingAlgo.Helpers;
using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using static MatchingAlgo.Helpers.Enums.Enums;

namespace MatchingAlgo.Data
{
    public class Customer
    {
        [Required]
        public DateTime Date  { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public double JobDuration { get; set; }
        [Required]
        public int Helpers { get; set; }
        [Required] 
        public Vehicle Vehicle { get; set; }
        [Required]
        public CoordinateXY StartLocation { get; set; }
        [Required]
        public CoordinateXY EndLocation { get; set; }
    }
}
