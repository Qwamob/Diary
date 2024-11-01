using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        //[Key] do not need to use key anotation as long as
        //the property is named Id any other name needs the key anotation.
        public int Id { get; set; }
        [Required] // this is a data annotation that makes the title required / not nullamble property
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty; 
        [Required]
        public DateTime Created { get; set; } = DateTime.Now;

    }
}
