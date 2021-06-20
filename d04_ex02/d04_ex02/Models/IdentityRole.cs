using System.ComponentModel;

namespace d04_ex02.Models
{
    public class IdentityRole
    {
        public IdentityRole()
        {
        }

        [Description("User name")]
        [DefaultValue("Me")]
        public string Name { get; set; }
        [Description("Description")]
        [DefaultValue("My description")]
        public string Description { get; set; }

        public override string ToString()
            => $"{Name}, {Description}";
    }

}