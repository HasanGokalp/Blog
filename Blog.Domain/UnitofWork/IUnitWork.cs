using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Domain.Repositories;

namespace Blog.Domain.UnitofWork
{
    //Database bağlantısını açıcağı için Disposable
    public interface IUnitWork : IDisposable
    {
        IBlogRepository BlogRepository { get; }
        bool Commit();
        Task<bool> CommitAsync();
    }
}
