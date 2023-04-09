using System.ComponentModel.DataAnnotations;

namespace Softify.Tourism.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}