using Data_Access.Abstract;
using Data_Access.Repositories;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.EntityFramework
{
    public class EFOrder:Generic<Order>,IOrderDal
    {
    }
}
