using System.ComponentModel.DataAnnotations;

namespace WebTest.Models
{
    public class Model
    {
        public int BrandId { get; set; }
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле Name обязательно для заполнения")]
        [RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "Поле Name не должно содержать спецсимволы")]
        public string? Name { get; set; }
        public int? Active { get; set; }
        public Brand? Brand { get; set; }
    }
}
