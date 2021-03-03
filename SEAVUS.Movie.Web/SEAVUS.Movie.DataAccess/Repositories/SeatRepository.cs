using Microsoft.EntityFrameworkCore;
using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEAVUS.Movie.DataAccess.Repositories
{
    public class SeatRepository : BaseRepository, IRepository<Seat>
    {
        public SeatRepository(MovieDbContext context) : base(context) { }
        public int Delete(int id)
        {
            Seat seat = _db.Seats.SingleOrDefault(x => x.Id == id);
            if (seat == null)
                return -1;
            _db.Seats.Remove(seat);
            int seatId = _db.SaveChanges();
            return seatId;
        }

        public IEnumerable<Seat> GetAll()
        {

            IEnumerable<Seat> seats = _db.Seats
                                         .Include(x => x.Hall)
                                         .ThenInclude(x => x.Seats);
            return seats;
        }

        public Seat GetById(int id)
        {
            Seat seat = _db.Seats
                           .Include(x => x.Hall)
                           .ThenInclude(x => x.Shows)
                           .ThenInclude(x => x.Movie)
                           .SingleOrDefault(x => x.Id == id);

            return seat;
        }

        public int Insert(Seat entity)
        {
            _db.Seats.Add(entity);
            int seatId = _db.SaveChanges();
            return seatId;
        }

        public int Update(Seat entity)
        {
            Seat seat = _db.Seats.SingleOrDefault(x => x.Id == entity.Id);
            if (seat != null)
                _db.Seats.Update(entity);
            int seatId = _db.SaveChanges();
            return seatId;
        }
    }
}
