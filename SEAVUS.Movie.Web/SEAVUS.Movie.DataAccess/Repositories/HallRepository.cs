using Microsoft.EntityFrameworkCore;
using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEAVUS.Movie.DataAccess.Repositories
{
    public class HallRepository : BaseRepository, IRepository<Hall>
    {
        public HallRepository(MovieDbContext context) : base(context) { }

        public int Delete(int id)
        {
            Hall hall = _db.Halls.SingleOrDefault(x => x.Id == id);
            if (hall == null)
                return -1;
            _db.Halls.Remove(hall);
            int hallId = _db.SaveChanges();
            return hallId;
        }

        public IEnumerable<Hall> GetAll()
        {

            IEnumerable<Hall> halls = _db.Halls
                                         .Include(x => x.Seats)
                                         .Include(x => x.Shows)
                                         .ThenInclude(x => x.Movie);
            return halls;
        }

        public Hall GetById(int id)
        {
            Hall hall = _db.Halls
                           .Include(x => x.Seats)
                           .Include(x => x.Shows)
                           .ThenInclude(x => x.Movie)
                          .SingleOrDefault(x => x.Id == id);

            return hall;
        }

        public int Insert(Hall entity)
        {
            _db.Halls.Add(entity);
            int hallId = _db.SaveChanges();
            return hallId;
        }

        public int Update(Hall entity)
        {
            Hall hall = _db.Halls.SingleOrDefault(x => x.Id == entity.Id);
            if (hall != null)
                _db.Halls.Update(entity);
            int hallId = _db.SaveChanges();
            return hallId;
        }
    }
}
