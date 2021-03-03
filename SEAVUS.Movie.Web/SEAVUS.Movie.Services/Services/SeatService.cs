using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using SEAVUS.Movie.Services.Interfaces;
using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEAVUS.Movie.Services.Services
{
    public class SeatService : ISeatService
    {
        private readonly IRepository<Seat> _seatRepository;

        public SeatService(IRepository<Seat> seatRepository)
        {
            _seatRepository = seatRepository;
        }
        public List<SeatViewModel> GetAllSeats()
        {
            List<Seat> seats = _seatRepository.GetAll().ToList();

            List<SeatViewModel> seatList = (from s in seats
                                            select new SeatViewModel
                                            {
                                                Id = s.Id,
                                                Available = s.Available,
                                                Type = s.Type,
                                                Price = s.Price,
                                                RowNumber = s.RowNumber,
                                                SeatNumber = s.SeatNumber
                                            }).ToList();
            return seatList;

        }
    }
}
