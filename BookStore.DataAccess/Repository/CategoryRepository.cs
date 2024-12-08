using BookStore.Data;
using BookStore.DataAccess.Repository.IRepository;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        private readonly ApplicationDBContxt _db;

        public CategoryRepository(ApplicationDBContxt db):base(db) 
        {
            _db = db;
        }
      

        public void Update(Category obj)
        {
            _db.Update(obj);
        }
    }
}
