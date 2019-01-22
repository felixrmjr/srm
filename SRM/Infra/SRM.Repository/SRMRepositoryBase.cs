using SRM.Domain.Entities;
using SRM.Domain.Interfaces.Repositories;
using SRM.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRM.Repository
{
    public class SRMRepositoryBase<TContext, TEntity, TIdentity> : ISRMRepositoryBase<TContext, TEntity, TIdentity>
        where TEntity : EntityBase
        where TContext : IUnitOfWork<TContext>
    {

        public IUnitOfWork<TContext> UnitOfWork { get; }

        public SRMRepositoryBase(IUnitOfWork<TContext> unitOfWork) => this.UnitOfWork = unitOfWork;

        protected DbSet<TEntity> DbSet => ((DbContext)UnitOfWork).Set<TEntity>();

        public virtual TEntity Save(TEntity entity)
        {
            DbSet.Add(entity);
            return entity;
        }

        public virtual TEntity Update(TEntity entity)
        {
            var result = DbSet.Attach(entity);
            //result.State = EntityState.Modified;

            return entity;
        }

        public virtual void Delete(TIdentity id)
        {
            TEntity entity = Get(id);
            DbSet.Remove(entity);
        }

        public virtual TEntity Get(TIdentity id) => DbSet.Find(id);
        public virtual List<TEntity> GetAll()
        {
            var result = DbSet.AsQueryable();

            //if (filter != null)
            //    result = AddQueryFilter(filter, result);

            return result.ToList();
        }
        //public virtual IPagedList<TEntity> GetPaginated(QueryFilter filter, int start = 0, int limit = 10, bool orderByDescending = true, params Expression<Func<TEntity, object>>[] includes)
        //{
        //    var result = DbSet.AsQueryable();

        //    if (includes != null)
        //        foreach (var include in includes)
        //            result = result.Include(include);


        //    return GetPagedList(result, filter, start, limit, orderByDescending);
        //}
        //protected IPagedList<TEntity> GetPagedList(IQueryable<TEntity> result, QueryFilter filter, int start, int limit, bool orderByDescending)
        //{
        //    if (filter != null)
        //        result = AddQueryFilter(filter, result);

        //    if (orderByDescending)
        //        result = result.OrderByDescending(x => x.Id);

        //    var total = result.Count();

        //    if (limit > 0)
        //    {
        //        result = result
        //            .Skip(start)
        //            .Take(limit);
        //    }

        //    return result.ToPagedList(total);
        //}
        //public ICollection<T> FromSql<T>(string sql, params object[] parameters) where T : class
        //{
        //    var result = ((DbContext)UnitOfWork).Set<T>().FromSql(sql, parameters).ToList();
        //    return result;
        //}

        #region Bulk Insert

        public virtual async Task BulkInsertAsync(ICollection<TEntity> dados, string[] colunas, string table)
        {
            //var connectionString = ((DbContext)UnitOfWork).Database.GetDbConnection().ConnectionString;

            //using (var sqlCopy = new SqlBulkCopy(connectionString, SqlBulkCopyOptions.Default))
            //{
            //    sqlCopy.DestinationTableName = table;

            //    using (var reader = ObjectReader.Create(dados, colunas))
            //        await sqlCopy.WriteToServerAsync(reader);
            //}
        }
        public virtual void BulkInsert(ICollection<TEntity> dados, string[] colunas, string table)
        {
            //var connectionString = ((DbContext)UnitOfWork).Database.GetDbConnection().ConnectionString;

            //using (var sqlCopy = new SqlBulkCopy(connectionString, SqlBulkCopyOptions.Default))
            //{
            //    sqlCopy.DestinationTableName = table;

            //    using (var reader = ObjectReader.Create(dados, colunas))
            //        sqlCopy.WriteToServer(reader);
            //}
        }

        #endregion

    }
}
