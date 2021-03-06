﻿using DB;
using Interfaces.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Repository.Configs
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> dbSet;

        public GenericRepository(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
            this.dbSet = this.UnitOfWork.DbContext.Set<TEntity>();
        }

        public IUnitOfWork UnitOfWork { get; set; }

        public IEnumerable<TEntity> GetAllRecords()
        {
            return this.dbSet.ToList();
        }

        public TEntity GetFirstOrDefault(int recordId)
        {
            return this.dbSet.Find(recordId);
        }

        public void Add(TEntity entity)
        {
            this.dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            this.dbSet.Attach(entity);
            this.UnitOfWork.DbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            this.dbSet.Remove(entity);
        }

        public void SaveChanges()
        {
            this.UnitOfWork.SaveChanges();
        }
    }
}