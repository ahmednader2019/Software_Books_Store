using BookStore.Data;
using BookStore.DataAccess.Repository.IRepository;
using BookStore.Models;
using BookStore.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>,IShoppingCartRepository
    {
        private readonly ApplicationDBContxt _db;

        public ShoppingCartRepository(ApplicationDBContxt db):base(db) 
        {
            _db = db;
        }


        public void Update(ShoppingCart obj)
        {
            _db.Update(obj);
        }

       
    }
}
