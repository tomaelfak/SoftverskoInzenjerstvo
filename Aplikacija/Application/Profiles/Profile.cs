using Domain;

namespace Application.Profiles
{
    public class Profile
    {
        public string Username { get; set; }

        public string DisplayName { get; set; }

        public string Image { get; set; }

        public string Bio { get; set; }

        public string Address { get; set; }

        public ICollection<Rating> ReceivedRatings { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
}