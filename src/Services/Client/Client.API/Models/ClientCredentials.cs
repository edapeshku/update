namespace eSupport.Services.Client.API.Models
{
    public class ClientCredentials
    {
        public int ClientId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool Active { get; set; }
    }
}