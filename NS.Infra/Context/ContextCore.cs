using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.Infra.Context
{
    public class ContextCore : DbContext
    {
        public ContextCore()
            : base("Name=ConexaoCore")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        //public DbSet<MENSAGEM> POST { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MSG_FEED");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           // modelBuilder.Configurations.Add(new MensagemMap());
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                if (Database.Connection.State != System.Data.ConnectionState.Closed)
                    Database.Connection.Close();
            }
            catch (Exception)
            {
            }

            base.Dispose(disposing);
        }
    }
}
