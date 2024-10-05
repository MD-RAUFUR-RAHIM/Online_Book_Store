﻿using OnlinBookStore.DataAccess.Repository.IRepository;
using OnlineBookStore.DataAccess.Data;
using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlinBookStore.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>,ICategoryRepo
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
