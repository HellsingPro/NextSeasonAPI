using NS.Domain.Contracts.Repositories;
using System.Collections;
using System.Configuration;
using System.Web.Configuration;

namespace NS.Infra.Utility
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ConexaoCore"].ConnectionString;

        public void Dispose()
        {
        }

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }

        public ConnectionStringSettings GetConnectionString(string name)
        {
            // Get the connectionStrings section.
            ConnectionStringsSection connectionStringsSection =
                WebConfigurationManager.GetSection("connectionStrings")
                as ConnectionStringsSection;
            // Get the connectionStrings key,value pairs collection.
            ConnectionStringSettingsCollection connectionStrings =
                connectionStringsSection.ConnectionStrings;

            // Get the collection enumerator.
            IEnumerator connectionStringsEnum =
                connectionStrings.GetEnumerator();

            int i = 0;
            while (connectionStringsEnum.MoveNext())
            {
                if (connectionStrings[i].Name.Equals(name))
                    return connectionStrings[i];

                i++;
            }
            return null;
        }
    }
}
