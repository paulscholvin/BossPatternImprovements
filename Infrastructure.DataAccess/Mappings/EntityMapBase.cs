using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DomainModel.Entities;

namespace Infrastructure.DataAccess.Mappings
{
    public abstract class EntityMapBase<T> : EntityTypeConfiguration<T> where T : Entity
    {
        protected EntityMapBase()
        {
            HasKey(e => e.Id);
            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
