using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Model
{
    public class UserSetting
    {
        public int UserSettingId { get; set; }

        [MaxLength(20)]
        public string? Theme { get; set;}

        [MaxLength(100)]
        public string? Notificationpreferences { get; set; }

        //idegen kulcs (Foreign key) felvétele
        public int Userid { get; set; }
        public virtual User? User { get; set; }
    }
}
