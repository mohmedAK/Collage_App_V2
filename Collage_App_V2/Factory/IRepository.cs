using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collage_App_V2.Factory
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string sqlstr);
        IEnumerable<T> GetByParam(string sqlstr, object param);

        void ExcParam(string sqlstr, object param);
        void ExecQuery(string sqlstr);
        T GetSingle(string sqlstr, object param);
        T GetSingle(string sqlstr);
    }
}
