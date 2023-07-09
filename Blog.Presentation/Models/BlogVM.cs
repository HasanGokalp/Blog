using System.ComponentModel.DataAnnotations;

namespace Blog.Presentation.Models
{
    public class BlogVM
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Display(Name = "İsmi")]
        public string Name { get; set; }
        [Display(Name = "Açıklaması")]
        public string Description { get; set; }
        [Display(Name = "Başlığı")]
        public string Title { get; set; }
        [Display(Name = "Yazarı")]
        public string Author { get; set; }
        [Display(Name = "İçeriği")]
        public string Contextt { get; set; }
    }
}
