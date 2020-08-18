using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVCW5._BLL.Models;
using WebApplicationMVCW5._DAL.Services;

namespace WebApplicationMVC._BLL.Services
{
    public interface ICategoryService
    {
        //CategoryBLLModel FetchById(long id);
        //CategoryBLLModel FetchByCode(string codeValue);
        //List<CategoryBLLModel> FetchAll();
        //void Update(CategoryBLLModel model);
        //void Add(CategoryBLLModel model);
        //void Delete(long id);
    }

    public class CategoryService : ICategoryService
    {
        private readonly IDALService _DALService;

        public CategoryService(IDALService dalService)
        {
            // _DALService = new DALService();
            _DALService = dalService;
        }

        //public CategoryBLLModel FetchById(long id)
        //{
        //    var result = new CategoryBLLModel();
        //    try
        //    {
        //        result = _DALService.FetchCategory(id);

        //    }
        //    catch (Exception e)
        //    {
        //        //
        //    }

        //    return result;
        //}

        //public CategoryBLLModel FetchByCode(string codeValue)
        //{
        //    var result = new CategoryBLLModel();
        //    try
        //    {
        //        result = _DALService.FetchCategory(codeValue);
        //    }
        //    catch (Exception e)
        //    {

        //    }

        //    return result;
        //}

        //public List<CategoryBLLModel> FetchAll()
        //{
        //    var result = new List<CategoryBLLModel>();
        //    try
        //    {
        //        result = _DALService.FetchAllCategory(); //.OrderBy(x => x.Sequence);
        //    }
        //    catch (Exception e)
        //    {
        //        //result.Errors.Add(e.BuildExceptionMessage());
        //    }
        //    return result;
        //}

        //public void Update(CategoryBLLModel model)
        //{
        //    try
        //    {
        //        //var checkResults = CheckForDuplicates(model);
        //        //if (checkResults.Any())
        //        //{
        //        //    result.Errors = checkResults;
        //        //}
        //        //else
        //        //{
        //        _DALService.UpdateCategory(model);
        //        //}
        //    }
        //    catch (Exception e)
        //    {
        //        // result.Errors.Add(e.BuildExceptionMessage());
        //    }

        //}

        //public void Add(CategoryBLLModel model)
        //{

        //    try
        //    {
        //        //var checkResults = CheckForDuplicates(model);
        //        //if (checkResults.Any())
        //        //{
        //        //    result.Errors = checkResults;
        //        //}
        //        //else
        //        //{
        //        _DALService.AddCategory(model);

        //        //}
        //    }
        //    catch (Exception e)
        //    {
        //        //result.Errors.Add(e.BuildExceptionMessage());
        //    }

        //}

        //public void Delete(long id)
        //{
        //    _DALService.DeleteCategory(id);
        //}

        //private List<string> CheckForDuplicates(CategoryBLLModel model)
        //{
        //    var errors = new List<string>();
        //    var duplicateModel = _DALService.FetchAllCategory()
        //        .FirstOrDefault(x => x.CategoryName.Equals(model.CategoryName,
        //                                 StringComparison.CurrentCultureIgnoreCase) &&
        //                             x.CategoryId != model.CategoryId);
        //    if (duplicateModel != null)
        //    {
        //        errors.Add(duplicateModel.CategoryName.Equals(model.CategoryName, StringComparison.OrdinalIgnoreCase)
        //            ? "Errors.CategoryNameExists"
        //            : "Errors.CategoryCodeExists");

        //    }
        //    return errors;
        //}

    }

}
