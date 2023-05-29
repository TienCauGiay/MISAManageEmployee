using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MISAManageEmployee.DAO
{
    internal interface ICommonFrame<T>
    {
        IEnumerable<T> GetAll();
        T GetById(string employeeCode);
        int Create(T entity);
        int Update(T entity);
        int Delete(int employeeId);
    }
}
