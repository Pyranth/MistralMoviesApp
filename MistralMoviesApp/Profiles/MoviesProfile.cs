using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Models;
using MistralMoviesApp.Models;

namespace MistralMoviesApp.Profiles
{
    public class MoviesProfile : Profile
    {
        public MoviesProfile()
        {
            CreateMap<Movie, MovieListViewModel>()
                .ForMember(m => m.Actors, opt => opt.MapFrom(src => src.Cast.Select(m => m.Actor)));
        }
    }
}
