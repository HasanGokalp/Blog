using Blog.Domain.Repositories;
using Blog.Domain.UnitofWork;
using Blog.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.UnitofWork
{
    public class UnitWork : IUnitWork
    {
        public IBlogRepository BlogRepository { get; }
        public BlogContext BlogContext { get; }

        public UnitWork(BlogContext blogContext, IBlogRepository blogRepository)
        {
            BlogContext = blogContext;
            BlogRepository = blogRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool Commit()
        {
            throw new NotImplementedException();
        }

        public Task<bool> CommitAsync()
        {
            throw new NotImplementedException();
        }
    }
}
