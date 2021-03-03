using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.WebModels.ViewModels
{
    public class SeatViewModel
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public string RowNumber { get; set; }
        public sbyte Available { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }


    }
}
