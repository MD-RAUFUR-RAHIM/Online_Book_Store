using OnlinBookStore.DataAccess.Repository.IRepository;
using OnlineBookStore.DataAccess.Data;
using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinBookStore.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public ICategoryRepo Category { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
