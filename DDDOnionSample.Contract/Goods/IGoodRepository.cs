using DDDOnionSample.Entities.Goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDOnionSample.Contract.Goods
{
    public interface IGoodRepository
    {
        List<Good> Goods();
        Good Find(int id);
    }
}
