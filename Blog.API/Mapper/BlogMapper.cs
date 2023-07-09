using AutoMapper;
using Blog.API.Models;
using Blog.Domain.DTO;

namespace Blog.API.Mapper
{
    public class BlogMapper : Profile
    {
        public BlogMapper()
        {
            CreateMap<BlogDTO, BlogVM>();
            CreateMap<BlogVM, BlogDTO>();
        }
    }
}
