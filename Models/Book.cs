using System.ComponentModel.DataAnnotations;

namespace LibraryManegament.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Заглавието е задължително")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Авторът е задължителен")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Годината на издаване е задължителна")]
        [Range(1000, 2100, ErrorMessage = "Невалидна година")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Броят копия е задължителен")]
        [Range(1, int.MaxValue, ErrorMessage = "Броят копия трябва да бъде поне 1")]
        public int Copies { get; set; }
    }
}
