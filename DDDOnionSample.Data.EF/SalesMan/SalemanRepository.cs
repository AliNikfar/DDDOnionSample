using AutoMapper;
using DDDOnionSample.Contract.SalesMan;
using DDDOnionSample.Data.EF.Commmon;
using DDDOnionSample.Entities.SalesMan;


namespace DDDOnionSample.Data.EF.SalesMan
{
    public class SalemanRepository : BaseEFRepository, ISalemanRepository
    {
        private readonly IMapper _mapper;
        public SalemanRepository(ApplicationDbContext ctx) : base(ctx)
        {
        }

        public Saleman Find(int id)
        {
            var result = _ctx.Salemans.Where(p => p.CustomerId == id).First();
            if (result is not null)
                return result;
            return null;
        }

        public List<SalemanDTO> Salemans()
        {
            var result = _ctx.Salemans.ToList();
            if (result.Count > 0)
            {
                var ResultDTO = _mapper.Map<List<SalemanDTO>>(result);
                return ResultDTO;
            }
            return null;

        }
    }
}
