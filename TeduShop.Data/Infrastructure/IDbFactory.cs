using System;

namespace TeduShop.Data.Infrastracture
{
    //Giao tiếp khởi tạo các đối tượng Entitis
     public interface IDbFactory:IDisposable
    {
        //cần một phương thức để init Dbcontext
        TeduShopDbContext Init();
    }
}