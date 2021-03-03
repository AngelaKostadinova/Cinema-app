using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.WebModels.ViewModels
{
    public class HallViewModel
    {
        public int Id { get; set; }
        public string HallName { get; set; }
        public List<SeatViewModel> Seats { get; set; }
    }
}
