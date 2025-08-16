using Business.Abstract;
using Data_Access.Abstract;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        public void Delete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void Insert(Customer entity)
        {
            if(entity.CustomerName != "" && entity.CustomerName.Length>=3 && 
                entity.CustomerCity!=null && entity.CustomerSurname != "" && entity.CustomerName.Length <= 30)
            {
                _customerDal.Insert(entity);
            }
            else
            {

            }
        }

        public void Update(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
