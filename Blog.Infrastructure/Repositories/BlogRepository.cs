using Blog.Domain.Repositories;
using Blog.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class BlogRepository : Repository<Domain.Concrete.Blog>, IBlogRepository
    {
        public BlogRepository(BlogContext context) : base(context)
        {

        }
    }
}
