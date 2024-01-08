using DDDOnionSample.Entities.SalesMan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDOnionSample.Contract.SalesMan
{
    public interface ISalemanRepository
    {
        List<Saleman> Salemans();
        Saleman Find(int id);
    }
}
