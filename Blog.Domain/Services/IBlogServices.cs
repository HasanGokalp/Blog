using Blog.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Services
{
    public interface IBlogServices
    {
        IEnumerable<BlogDTO> GetAllBlogs();

        void AddCategory(BlogDTO blogDTO);

        BlogDTO GetCategoryById(int? blogDTOId, bool isTracking = true);

        void UpdateCategory(BlogDTO blogDTOId);

        void DeleteCategory(int? categoryId);
    }
}
