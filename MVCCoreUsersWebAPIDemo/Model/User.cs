using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCoreUsersWebAPIDemo.Model
{
    public class User 
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required(ErrorMessage = "User name should not be blank")]
        public string name { get; set; }
        [Required(ErrorMessage = "User username should not be blank")]
        public string username { get; set; }
        [Required(ErrorMessage = "User email should not be blank")]
        public string email { get; set; }
        [Required(ErrorMessage = "User phone should not be blank")]
        public string phone { get; set; }
        [Required(ErrorMessage = "User website should not be blank")]
        public string website { get; set; }

    }
}
