using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastracture
{
    //IDisposable : Cho phép những cái nào kế thừa từ nó có thể cài đặt các phương thức tự động hủy  
    // cho phép chương trình thực hiện các công việc dọn dẹp hay giải phóng tài nguyên mong muốn
    public class Disposable : IDisposable
    {
        private bool isDisposed;
        ~Disposable()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            //Thực hiện công việc dọn dẹp
            Dispose(true);
            //Yêu cầu bộ thu dọc GC trong thực hiện kết thúc
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }
        //Overide this to dispose custom objects
        protected virtual void DisposeCore()
        {

        }
    }
}
