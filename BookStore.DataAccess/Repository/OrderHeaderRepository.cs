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
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDBContxt _db;

        public OrderHeaderRepository(ApplicationDBContxt db):base(db) 
        {
            _db = db;
        }
      

        public void Update(OrderHeader obj)
        {
            _db.Update(obj);
        }
    }
}
