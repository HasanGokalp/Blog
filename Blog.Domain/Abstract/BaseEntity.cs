using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Abstract
{
    // türetilen nesnelerin idsi olmak zorundadır.
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }
}
