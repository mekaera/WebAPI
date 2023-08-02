using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{// Ienetityrepository sadece class olan ve Ientity ve implementasyonu olan
 // ve newlenebılen yanı Ientity olmayan bırsey olmalı product customer gıbı
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        //interfacede fonksıyonları tanımlıyoruz
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
