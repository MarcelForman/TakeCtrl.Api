using System.ComponentModel.DataAnnotations;

namespace TakeCtrl.Api.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string userName { get; set; }
        public string Password { get; set; } 
        public Boolean IsAdmin { get; set; }
    }
}
