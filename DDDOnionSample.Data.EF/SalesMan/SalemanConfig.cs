using DDDOnionSample.Entities.SalesMan;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDDOnionSample.Data.EF.SalesMan
{
    public class SalemanConfig : IEntityTypeConfiguration<Saleman>
    {
        public void Configure(EntityTypeBuilder<Saleman> builder)
        {
            throw new NotImplementedException();
        }
    }
}
