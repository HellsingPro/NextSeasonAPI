using System.Configuration;

namespace NS.Domain.Contracts.Repositories
{
    public interface IConnectionFactory
    {

        ConnectionStringSettings GetConnectionString(string name);

        string ConnectionString { get; }
    }
}
