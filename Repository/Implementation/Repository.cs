using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> entity;
        
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            entity = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return this.entity.AsEnumerable();
        }

        public T GetById(Guid id)
        {
            return this.entity.FirstOrDefault(z => z.Id.Equals(id));
        }
    }
}