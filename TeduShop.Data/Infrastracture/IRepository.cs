using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Repositories
{
    public interface IRepository<T> where T: class
    {
        //Phương thức thêm
        void Add(T entity);
        //Phương thức sửa
        void Update(T entity);
        //Phương thức xóa
        void Delete(T entity);
        //Phương thức xóa nhiều Dl cùng lúc
        void DeleteMulti(Expression<Func<T, bool>> where);
        //Get an entity by int id
        T GetSingleById(int id);
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IQueryable<T> GetAll(string[] includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);
        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);
        int Count(Expression<Func<T, bool>> where);
        bool CheckContains(Expression<Func<T, bool>> predicate);


    }
}
