namespace Persistence.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public DatabaseSettings()
        {
            CollectionName = "WeightGoals";
            ConnectionString = AppConfig.GetConnectionString();
            DatabaseName = "BeefitMember";
        }
        public string CollectionName { get; }
        public string ConnectionString { get; }
        public string DatabaseName { get; }
    }
}