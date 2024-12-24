﻿using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }
        public List<Customer> TGetAll()
        {
            //if(yetki varsa)
            //{
            //listeleme yap
            //}
            //else
            //{
            //uyarı var
            //}
            return _customerDal.GetAll();
        }    
        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);  
        }
        public void Tinsert(Customer entity)
        {
            if(entity.CustomerName!="" && entity.CustomerName.Length>=3 &&
                entity.CustomerCity!=null && entity.CustomerSurname!="" && entity.CustomerName.Length<=30)
            {
                _customerDal.insert(entity);
            }
            else
            {
                //hata mesajı ver
            }
        }
        public void Tupdate(Customer entity)
        {
            if(entity.CustomerId!=0 && entity.CustomerCity.Length >=3)
            {
                _customerDal.update(entity);
            }
            else
            {
                //hata mesajı
            }
        }
    }
}