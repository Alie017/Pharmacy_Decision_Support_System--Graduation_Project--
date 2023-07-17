using System.ComponentModel.DataAnnotations;

namespace phadec.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}