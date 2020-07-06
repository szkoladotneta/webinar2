using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webinar2Todo.Application.Mapping
{
    public interface IMapFrom
    {
        public interface IMapFrom<T>
        {
            void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());

        }
    }
}
