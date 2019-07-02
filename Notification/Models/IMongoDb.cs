namespace Notification.Models
{
    public interface IMongoDb
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}