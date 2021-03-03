using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.Services.Interfaces
{
    public interface ISeatService
    {
        List<SeatViewModel> GetAllSeats();
    }
}
