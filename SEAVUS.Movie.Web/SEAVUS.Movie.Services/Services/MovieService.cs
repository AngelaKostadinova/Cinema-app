﻿using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using SEAVUS.Movie.Services.Interfaces;
using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEAVUS.Movie.Services.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Domain.Models.Movie> _movieRepository;

        public MovieService(IRepository<Domain.Models.Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public IEnumerable<MovieViewModel> GetAllMovies()
        {
            List<Domain.Models.Movie> movies = _movieRepository.GetAll().ToList();

            List<MovieViewModel> moviesList = (from m in movies
                              select new MovieViewModel
                              {
                                  Id = m.Id,
                                  MovieTitle = m.Title,
                                  Description = m.Description,
                                  Director = m.Director,
                                  ReleaseDate = m.ReleaseDate,
                                  Image = m.Image,
                                  Genre = m.Genre
                              }).ToList();
          
            return moviesList;
        }
        public MovieViewModel GetMovieById(int id)
        {
            Domain.Models.Movie movie = _movieRepository.GetById(id);

            List<Actor> movieActors = movie.MovieCast.Select(x => x.Actor).ToList();

            List<MovieCastViewModel> actorsList = (from a in movieActors
                                                   select new MovieCastViewModel
                                                   {
                                                       Id = a.Id,
                                                       FirstName = a.FirstName,
                                                       LastName = a.LastName
                                                   }).ToList();
            if (movie != null)
            {
                MovieViewModel model = new MovieViewModel()
                {
                    Id = movie.Id,
                    MovieTitle = movie.Title,
                    Description = movie.Description,
                    Image = movie.Image,
                    Genre = movie.Genre,
                    Director = movie.Director,
                    Language = movie.Language,
                    ReleaseDate = movie.ReleaseDate,
                    Technology = movie.Technology,
                    Actors = actorsList
                };

                return model;

            } else
            {
                throw new Exception($"Product with id: {id} is not found");
            }
        }
        public List<MovieViewModel> SearchMovies(string searchTerm)
        {
            List<MovieViewModel> movies = GetAllMovies().ToList();
            if (string.IsNullOrEmpty(searchTerm))
            {
                return movies;
            }
            if (DateTime.TryParse(searchTerm, out var dateTime))
            {
                return movies.Where(x => x.ReleaseDate.ToShortDateString() == dateTime.ToShortDateString()).ToList();
            }

            return movies.Where(m => m.MovieTitle.Contains(searchTerm) ||
                                m.ReleaseDate.ToString().Contains(searchTerm) ||
                                m.Genre.Contains(searchTerm) ||
                                m.Director.Contains(searchTerm)).ToList();
        }
        public List<MovieViewModel> Delete(int id)
        {
            int movieId = _movieRepository.Delete(id);
            List<MovieViewModel> movies = GetAllMovies().ToList();

            if (movieId == -1)
                throw new Exception("Movie not found!");
            return movies;
        }
        public void AddNewMovie(MovieViewModel model)
        {

           if(model != null)
            {
                Domain.Models.Movie movie = new Domain.Models.Movie()
                {
                    Id = model.Id,
                    Title = model.MovieTitle,
                    Description = model.Description,
                    Image = model.Image,
                    Genre = model.Genre,
                    Director = model.Director,
                    Language = model.Language,
                    ReleaseDate = model.ReleaseDate,
                    Technology = model.Technology,
                    MovieCast = new List<Cast> { },
                    Shows = new List<Show> { }
                };

                _movieRepository.Insert(movie);
            }
        }
        public void EditMovie(MovieViewModel model)
        {
            if (model != null)
            {
                Domain.Models.Movie movie = _movieRepository.GetById(model.Id);

                //List<Actor> actors = movie.MovieCast.Select(x => x.Actor).ToList();

                    movie.Id = model.Id;
                    movie.Title = model.MovieTitle;
                    movie.Description = model.Description;
                    movie.Image = model.Image;
                    movie.Genre = model.Genre;
                    movie.Director = model.Director;
                    movie.Language = model.Language;
                    movie.ReleaseDate = model.ReleaseDate;
                    movie.Technology = model.Technology;

                //foreach(var cast in movie.MovieCast)
                //{
                //    foreach(var actor in actors)
                //    {
                //        cast.ActorId = actor.Id;
                //        cast.Actor.FirstName = actor.FirstName;
                //        cast.Actor.LastName = actor.LastName;
                //        cast.Actor.Age = actor.Age;
                //    }
                //}
                _movieRepository.Update(movie);
            }
        }
    }
}
