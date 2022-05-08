using System.ComponentModel.DataAnnotations;

namespace MVC_08.Models
{
    public class Person
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }


    }
}