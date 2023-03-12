using System.ComponentModel.DataAnnotations;

namespace NetCoreProject.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Lütfen rol adı giriniz")]
        public string name { get; set; }
    }
}
