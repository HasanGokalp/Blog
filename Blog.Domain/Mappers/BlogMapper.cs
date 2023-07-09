using AutoMapper;
using Blog.Domain.Concrete;
using Blog.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Mappers
{
    public class BlogMapper : Profile
    {
        public BlogMapper()
        {
            CreateMap<Concrete.Blog, BlogDTO>();
            CreateMap<BlogDTO, Concrete.Blog>();
        }
    }
}
