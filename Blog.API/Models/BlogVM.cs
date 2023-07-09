using System.ComponentModel.DataAnnotations;

namespace Blog.API.Models
{
    public class BlogVM
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Display(Name = "İsim")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Başlık")]
        public string Title { get; set; }
        [Display(Name = "Yazar")]
        public string Author { get; set; }
        [Display(Name = "İçerik")]
        public string Contextt { get; set; }
    }
}
