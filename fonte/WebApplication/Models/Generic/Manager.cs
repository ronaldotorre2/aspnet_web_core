using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace WebApplication.model.Generic
{
    public class Manager<E> :IDisposable where E:class
    {
        public AppDbContext db;

        public Manager(AppDbContext context)
        {
            db = context;
        }

        public IQueryable<E> FindAll()
        {
            try
            {
                return db.Set<E>();
            }
            catch (Exception ex)
            {
                throw new System.Exception("Failed to get list of data! " + ex.Message);
            }
        }

        public E FindById(int id)
        {
            try
            {
                return db.Set<E>().Find(id);
            }
            catch (Exception ex)
            {
                throw new System.Exception("Failed to get data by id " + ex.Message);
            }
        }

        public IQueryable<E> FindByParam(Func<E,bool> predicate)
        {
            try
            {
                return db.Set<E>().Where(predicate).AsQueryable();
            }
            catch (Exception ex)
            {
                throw new System.Exception("Failed to get data by param " + ex.Message);
            }
        }

        public void Create(E entity)
        {
            try
            {
                db.Set<E>().Add(entity);
                this.Save();
            }
            catch(Exception ex)
            {
                throw new System.Exception("Failed to create entity! "+ex.Message);
            }
        }

        public void Change(E entity)
        {
            try
            {
                if(db.Entry<E>(entity).State == EntityState.Detached)
                {
                    db.Set<E>().Attach(entity);
                }
                                
                db.Entry<E>(entity).State = EntityState.Modified;
                this.Save();
            }
            catch (Exception ex)
            {
                throw new System.Exception("Failed to update entity! " + ex.Message);
            }
        }

        public void Remove(E entity)
        {
            try
            {
                db.Set<E>().Remove(entity);
                this.Save();
            }
            catch (Exception ex)
            {
                throw new System.Exception("Failed to delete entity! " + ex.Message);
            }
        }

        public void Save()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new System.Exception("Failed to save! " + ex.Message);
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
        
    }
}