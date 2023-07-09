using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Blog.Domain.DTO;
using Blog.Domain.Services;
using Blog.Domain.UnitofWork;

namespace Blog.Services.Services
{
    public class BlogService : IBlogServices
    {
        protected readonly IUnitWork Database;
        protected readonly IMapper Mapper;
        public BlogService(IUnitWork unitWork, IMapper mapper)
        {
            Database = unitWork;
            Mapper = mapper;
        }
        //Buraya bir daha bak mantığını anla.
        public IEnumerable<BlogDTO> GetAllBlogs()
        {
            var categories = Database.BlogRepository.GetAll();
            var categoryDtos = Mapper.Map<IEnumerable<Domain.Concrete.Blog>, IEnumerable<BlogDTO>>(categories);
            return categoryDtos;
            
        }

        public void AddCategory(BlogDTO blogDTO)
        {
           var mapper = Mapper.Map<BlogDTO, Domain.Concrete.Blog>(blogDTO);
           Database.BlogRepository.Insert(mapper);
        }

        public void DeleteCategory(BlogDTO blogDTO)
        {
            var mapper = Mapper.Map<BlogDTO, Domain.Concrete.Blog>(blogDTO);
            Database.BlogRepository.Delete(mapper);
        }

        public void UpdateCategory(BlogDTO blogDTO)
        {
            var mapper = Mapper.Map<BlogDTO, Domain.Concrete.Blog>(blogDTO);
            Database.BlogRepository.Update(mapper);
        }

        public BlogDTO GetCategoryById(int? blogDTOId, bool isTracking = true)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int? categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
