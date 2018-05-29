using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Models;

namespace WebStore.BL.Context
{
    public interface IEmployeesData
    {
        /// <summary>
        /// Get employees
        /// </summary>
        /// <returns></returns>
        IEnumerable<EmployeeView> GetAll();

        /// <summary>
        /// Get employee by id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        EmployeeView GetById(int id);

        /// <summary>
        /// Add new employee
        /// </summary>
        /// <param name="model"></param>
        void AddNew(EmployeeView model);

        /// <summary>
        /// Remove 
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }
}
