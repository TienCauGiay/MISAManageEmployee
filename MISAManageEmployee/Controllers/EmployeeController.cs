using MISAManageEmployee.DAO;
using MISAManageEmployee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MISAManageEmployee.Controllers
{
    public class EmployeeController : ApiController
    {
        /**
         * Mô tả: Gọi hàm trả về danh sách tất cả nhân viên
         * Created By: bntien
         * Created Date: 30-05/2023
         */
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployee()
        {
           var res = new EmployeeDao().GetAll();
            return res;
        }

        /**
         * Mô tả: Gọi hàm trả về nhân viên theo EmployeeCode
         * Created By: bntien
         * Created Date: 30-05/2023
         */
        [HttpGet]
        public Employee GetEmployeeByCode(string id) 
        {
            var res = new EmployeeDao().GetById(id);
            return res;
        }

        /**
         * Mô tả: Gọi hàm thêm mới nhân viên, nếu thành công trả về id của nhân viên được thêm mới
         * Created By: bntien
         * Created Date: 30-05/2023
         */
        [HttpPost]
        public int AddNewEmployee(Employee employee)
        {
            var res = new EmployeeDao().Create(employee);
            return res;
        }

        /**
         * Mô tả: Gọi hàm cập nhật thông tin nhân viên, nếu thành công trả về id của nhân viên được cập nhật
         * Created By: bntien
         * Created Date: 30-05/2023
         */
        [HttpPut]
        public int UpdateEmployee(Employee employee)
        {
            var res = new EmployeeDao().Update(employee);
            return res;
        }

        /**
         * Mô tả: Gọi hàm xóa 1 nhân viên, nếu thành công trả về id của nhân viên được xóa, nếu không thành công trả về 0
         * Created By: bntien
         * Created Date: 30-05/2023
         */
        [HttpDelete]
        public int DeleteEmployee(int id) 
        {
            var res = new EmployeeDao().Delete(id);
            return res;
        }
    }
}
