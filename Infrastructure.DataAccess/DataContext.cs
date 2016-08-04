using System.Data.Entity;
using System.Threading.Tasks;
using Application.Interfaces;
using DomainModel.Entities;
using Infrastructure.DataAccess.Mappings;
using Infrastructure.Interfaces;

namespace Infrastructure.DataAccess
{
    public class DataContext : DbContext, IDataContext, IUnitOfWork
    {
        public IDbSet<Quote> Quotes { get; set; }

        public DataContext(string connectionString): base(connectionString)
        { }

        public override Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new QuoteMap());
        }
    }
}
