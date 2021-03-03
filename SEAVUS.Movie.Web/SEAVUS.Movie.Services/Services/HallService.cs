using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using SEAVUS.Movie.Services.Interfaces;
using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.Services.Services
{
    public class HallService : IHallService
    {
        private readonly IRepository<Hall> _hallRepository;
        private readonly ISeatService _seatService;

        public HallService(IRepository<Hall> hallRepository, ISeatService seatService)
        {
            _hallRepository = hallRepository;
            _seatService = seatService;
        }
        public HallViewModel GetHallById(int id)
        {
            Hall hall = _hallRepository.GetById(id);

            if (hall != null)
            {
                HallViewModel model = new HallViewModel
                {
                    Id = hall.Id,
                    HallName = hall.Name,
                    Seats = _seatService.GetAllSeats()
                };

                return model;
            }
            else
            {
                throw new Exception($"Hall with id: {id} is not found");
            }
        }
    }
}
