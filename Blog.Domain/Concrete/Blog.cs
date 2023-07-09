using Blog.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Concrete
{
    // Makale gibi düşünülebilir.
    public class Blog : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Contextt { get; set; }
    }
}
