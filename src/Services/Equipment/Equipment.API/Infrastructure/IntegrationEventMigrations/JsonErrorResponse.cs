namespace eSupport.Services.Equipment.API.Infrastructure.IntegrationEventMigrations
{
    public class JsonErrorResponse
    {
        public string[] Messages { get; set; }

        public object DeveloperMessage { get; set; }
    }
}