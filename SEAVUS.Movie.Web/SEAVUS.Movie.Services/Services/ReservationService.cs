using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using SEAVUS.Movie.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.Services.Services
{
    public class ReservationService : IReservationService
    {
        protected readonly IRepository<Reservation> _reservationRepository;
        protected readonly IRepository<Show> _showRepository;
        protected readonly IRepository<Seat> _seatRepository;
        protected readonly IUserRepository _userRepository;

        public ReservationService(IRepository<Show> showRepository, 
                                  IRepository<Seat> seatRepository,
                                  IUserRepository userRepository,
                                  IRepository<Reservation> reservationRepository)
        {
            _reservationRepository = reservationRepository;
            _seatRepository = seatRepository;
            _showRepository = showRepository;
            _userRepository = userRepository;
        }
        public int AddReservation(int showId, int seatId, string userId)
        {
            throw new NotImplementedException();
        }

        public int CreateReservation(Reservation reservation, string userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            IEnumerable<Reservation> reservations = _reservationRepository.GetAll();
            return reservations;
        }

        public Reservation GetCurrentReservation(string userId)
        {
            throw new NotImplementedException();
        }

        public Reservation GetReservationById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
