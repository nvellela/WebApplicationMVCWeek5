using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVCW5._BLL.Models;
using WebApplicationMVCW5._DAL.Models;

namespace WebApplicationMVCW5._DAL.Services
{

    public interface IDALService
    {
        List<EmployeeBLLModel> FetchAllEmployee();
        void DeleteEmployee(long id);
        void UpdateEmployee(EmployeeBLLModel model);
        void AddEmployee(EmployeeBLLModel model);


        //CategoryBLLModel FetchCategory(long id);
        //CategoryBLLModel FetchCategory(string codeValue);
        //List<CategoryBLLModel> FetchAllCategory();
        //void DeleteCategory(long id);
        //void UpdateCategory(CategoryBLLModel model);
        //void AddCategory(CategoryBLLModel model);


    }    

    public class DALService : IDALService
    {
        private readonly DALContext context;

        public DALService(DALContext _context)
        {
            this.context = _context;
        }

        public List<EmployeeBLLModel> FetchAllEmployee()
        {
            var efModel = context.Employees.ToList();
            var returnObject = new List<EmployeeBLLModel>();

            foreach (var item in efModel)
            {
                returnObject.Add(new EmployeeBLLModel()
                {
                    EmployeeId = item.EmployeeId,
                    Name = item.Name,
                    Salary = item.Salary,
                    IsRetired = item.IsRetired
                });
            }

            return returnObject;
        }

        public void DeleteEmployee(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(EmployeeBLLModel model)
        {
            throw new NotImplementedException();
        }

        public void AddEmployee(EmployeeBLLModel model)
        {
            var efModel = new Employee()
            {
                Name = model.Name,
                Salary = model.Salary,
                IsRetired = model.IsRetired
            };
            context.Employees.Add(efModel);
            context.SaveChanges();
        }






        //public CategoryBLLModel FetchCategory(long id)
        //{
        //    var efModel = context.Categories.Find(id);
        //    var returnObject = new CategoryBLLModel()
        //    {
        //        CategoryDescription = efModel.CategoryDescription,
        //        CategoryName = efModel.CategoryName,
        //        CategoryId = efModel.CategoryId
        //    };

        //    return returnObject;
        //}

        //public CategoryBLLModel FetchCategory(string codeValue)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<CategoryBLLModel> FetchAllCategory()
        //{
        //    var efModel = context.Categories.ToList();
        //    var returnObject = new List<CategoryBLLModel>();

        //    foreach (var item in efModel)
        //    {
        //        returnObject.Add(new CategoryBLLModel()
        //        {
        //            CategoryDescription = item.CategoryDescription,
        //            CategoryName = item.CategoryName,
        //            CategoryId = item.CategoryId
        //        });
        //    }

        //    return returnObject;
        //}

        //public void DeleteCategory(long id)
        //{
        //    var efModel = context.Categories.Find(id);
        //    context.Categories.Remove(efModel);
        //    context.SaveChanges();
        //}

        //public void UpdateCategory(CategoryBLLModel model)
        //{
        //    var efModel = context.Categories.Find(model.CategoryId);
        //    efModel.CategoryDescription = model.CategoryDescription;
        //    efModel.CategoryName = model.CategoryName;
        //    context.SaveChanges();
        //}

        //public void AddCategory(CategoryBLLModel model)
        //{
        //    var efModel = new Category()
        //    {
        //        CategoryDescription = model.CategoryDescription,
        //        CategoryName = model.CategoryName,
        //        CategoryId = model.CategoryId
        //    };
        //    context.Categories.Add(efModel);
        //    context.SaveChanges();
        //}
    }
}
