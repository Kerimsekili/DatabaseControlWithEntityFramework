using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //Generic Constraint
    //Class : Referans Tip
    //IEntity : IEntity olabilir ya da Onu implement eden bir nesne olabilir.
    //new(): Newlenebilir olmalı.
    public interface IEntityRepository<T> where T : class ,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
