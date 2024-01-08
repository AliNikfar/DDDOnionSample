using DDDOnionSample.Entities.Goods;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDDOnionSample.Data.EF.Goods
{
    public class GoodConfig : IEntityTypeConfiguration<Good>
    {
        public void Configure(EntityTypeBuilder<Good> builder)
        {
            throw new NotImplementedException();
        }
    }
}
