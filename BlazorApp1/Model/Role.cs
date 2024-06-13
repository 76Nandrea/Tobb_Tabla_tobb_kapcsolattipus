namespace BlazorApp1.Model
{
    public class Role
    {
        public int RoleId { get; set; }

        public string? RoleName { get; set; }

        //több a többhöz viszony kialakítása a User felé
        public virtual List<User> Users { get; set;} = new List<User>();

    }
}
