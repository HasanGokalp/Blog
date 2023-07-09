using AutoMapper;
using Blog.Domain.DTO;
using Blog.Presentation.Models;

namespace Blog.Presentation.Mappings
{
    public class BlogMapping : Profile
    {
        public BlogMapping()
        {
            CreateMap<BlogVM, BlogDTO>();
            CreateMap<BlogDTO, BlogVM>();
        }
    }
}
