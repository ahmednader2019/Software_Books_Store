﻿using BookStore.Data;
using BookStore.DataAccess.Repository.IRepository;
using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private  ApplicationDBContxt _db;

        public ICategoryRepository Category{ get; private set; }

        public IProductRepository Product { get; private set; } 

        public ICompanyRepository Company { get; private set; }

        public IShoppingCartRepository ShoppingCart { get; private set; }

        public IApplicationUserRepository ApplicationUser { get; private set; }


        public IOrderHeaderRepository OrderHeader { get; private set; }

        public IOrderDetailRepository OrderDetail { get; private set; } 


        public UnitOfWork(ApplicationDBContxt db)
        {
            _db = db;
            ShoppingCart = new ShoppingCartRepository(_db);

            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            Company = new CompanyRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);

            OrderHeader = new OrderHeaderRepository(_db);

            OrderDetail = new OrderDetailRepository(_db);

        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
