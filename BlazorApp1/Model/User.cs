using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Model
{
    public class User
    {
       
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Email { get; set; }

        //egy-egy kapcsolat kiépítése a Usersetting osztállyal 
        public virtual UserProfile? UserProfile { get; set; }


        //egy a többhöz kapcsolat kialakítása a post osztály felé:
        public virtual ICollection<Post> Post { get; set;} = new List<Post>();

        //Több a többhöz kapcsolat kiépítése a role-felé
        public virtual ICollection<Role> Role { get; set; } =new List<Role>();
    }
}
