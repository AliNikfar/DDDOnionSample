using AutoMapper;
using DDDOnionSample.Contract.Goods;
using DDDOnionSample.Data.EF.Commmon;
using DDDOnionSample.Entities.Goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDOnionSample.Data.EF.Goods
{
    public class GoodRepository : BaseEFRepository, IGoodRepository
    {
        private readonly IMapper _mapper;
        public GoodRepository(ApplicationDbContext ctx) : base(ctx)
        {
        }

        public Good Find(int id)
        {
            var result = _ctx.Goods.Where(p => p.GoodId == id).First();
            if (result is not null)
                return result;
            return null;
        }

        public List<Good> Goods()
        {
            var result = _ctx.Goods.ToList();
            if (result.Count > 0)
            {
                //var ResultDTO = _mapper.Map<List<GoodDTO>>(result);
                return result;
            }
            return null;
        }
    }
}
