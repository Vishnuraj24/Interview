using AutoMapper;
using LazyLoading.DTOs;
using LazyLoading.Models;

namespace LazyLoading.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<Author, AuthorDto>();
        }
    }
}
