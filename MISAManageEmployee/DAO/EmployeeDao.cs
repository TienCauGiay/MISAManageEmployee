using MISAManageEmployee.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MISAManageEmployee.DAO
{
    public class EmployeeDao : ICommonFrame<Employee>
    {
        ManageEmployeeDbContext db = null;

        public EmployeeDao()
        {
            db = new ManageEmployeeDbContext();
            db.Configuration.ProxyCreationEnabled = false;
        }

        /**
         * Mô tả: Hàm trả về danh sách tất cả nhân viên
         * Created By: bntien
         * Created Date: 30-05/2023
         */
        public IEnumerable<Employee> GetAll()
        {
            return db.Employees;
        }

        /**
         * Mô tả: Hàm trả về nhân viên theo EmployeeCode
         * Created By: bntien
         * Created Date: 30-05/2023
         */
        public Employee GetById(string employeeCode)
        {
            return db.Employees.FirstOrDefault(x => x.EmployeeCode == employeeCode);
        }

        /**
         * Mô tả: Hàm thêm 1 nhân viên mới
         * Created By: bntien
         * Created Date: 30-05/2023
         */
        public int Create(Employee entity)
        {
            db.Employees.Add(entity);
            db.SaveChanges();
            return entity.EmployeeID;
        }

        /**
         * Mô tả: Hàm sửa thông tin 1 nhân viên
         * Created By: bntien
         * Created Date: 30-05/2023
         */
        public int Update(Employee entity)
        {
            db.Employees.AddOrUpdate(entity);
            db.SaveChanges();
            return entity.EmployeeID;
        }

        /**
         * Mô tả: Hàm xóa 1 nhân viên
         * Created By: bntien
         * Created Date: 30-05/2023
         */
        public int Delete(int employeeId)
        {
            var employee = db.Employees.FirstOrDefault(x => x.EmployeeID== employeeId);
            if (employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
                return employee.EmployeeID;
            }
            return 0;
        }
    }
}