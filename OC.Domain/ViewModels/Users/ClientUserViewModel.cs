namespace OC.Domain.ViewModels.Users
{
    public class ClientUserViewModel
    {
        public long Id { get; set; }
        // FK Client
        public long ClientId { get; set; }
        public ClientViewModel ClientViewModel { get; set; }
        // FK User
        public long UserId { get; set; }
        public UserViewModel UserViewModel { get; set; }
    }
}
