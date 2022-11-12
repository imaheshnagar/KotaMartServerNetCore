namespace KotaMartApi.Entities
{
    public class KmAppUser
    {
        public int Id { get; set; }
        public string AppUser { get; set; }

        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }

        public string Password { get; set; }
        public string PasswordSalt { get; set; }
    }
}
