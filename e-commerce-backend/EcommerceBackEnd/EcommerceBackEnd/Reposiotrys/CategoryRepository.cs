using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Category;
using Ecommerce.Core.Model.Uom;
using EcommerceBackEnd.Services;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace EcommerceBackEnd.Reposiotrys
{
    public class CategoryRepository : ICategory
    {
        private readonly DataContext _context;
        private string UserID;
        private string CompanyID;
        public CategoryRepository(DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            UserID = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            CompanyID = httpContextAccessor.HttpContext.User.FindFirst("CompanyID").Value;
        }
        public void Delete(Category category)
        {
            try
            {
                var data = _context.Category.FirstOrDefault(x => x.CategoryID.Equals(category.CategoryID));
                if (data == null)
                {
                    Log.Warning("Category id not found" + category.CategoryID);
                }
                else
                {
                    _context.Category.Remove(data);
                    _context.SaveChanges();
                    Log.Information("Delete category successfully " + "data" + JsonConvert.SerializeObject(data) + "By user id" + UserID);
                }
               
            }catch(Exception ex)
            {
                Log.Error("Something went wrong while delete category." + ex + "Id " + category.CategoryID );
                throw new Exception("Something went wrong.");
            }
        }

        public Category FindById(string categoryId)
        {
            var lsCategory = from cat in _context.Category
                             join x in _context.Users on cat.CreateBy equals x.Id into xx from c_b in xx.DefaultIfEmpty()
                             join y in _context.Users on cat.UpdateBy equals y.Id into yy from u_b in yy.DefaultIfEmpty()
                             join z in _context.CompanyProfile on cat.CompanyID equals z.CompanyID into zz from com in zz.DefaultIfEmpty()
                             where cat.CategoryID == categoryId
                             select new Category
                             {
                                 CategoryID = cat.CategoryID,
                                 CreateBy = c_b.FullName ?? cat.CreateBy,
                                 CreateDate = cat.CreateDate,
                                 CategoryName = cat.CategoryName,
                                 CompanyID = com.CompanyName ?? cat.CompanyID,
                                 UpdateBy = u_b.FullName ?? cat.UpdateBy,
                                 UpdateDate = cat.UpdateDate
                             };
            return lsCategory.Count() > 0 ? lsCategory.First() : null;
        }

        public IEnumerable<Category> GetCategory()
        {
            var lsCategory = from cat in _context.Category
                          join x in _context.Users on cat.CreateBy equals x.Id into xx from c_b in xx.DefaultIfEmpty()
                          join y in _context.Users on cat.UpdateBy equals y.Id into yy from u_b in yy.DefaultIfEmpty()
                          join z in _context.CompanyProfile on cat.CompanyID equals z.CompanyID into zz from com in zz.DefaultIfEmpty()
                          where cat.CompanyID == CompanyID
                          select new Category
                          {
                                CategoryID = cat.CategoryID,
                                CreateBy = c_b.FullName ?? cat.CreateBy,
                                CreateDate = cat.CreateDate,
                                CategoryName = cat.CategoryName,
                                CompanyID=com.CompanyName ?? cat.CompanyID,
                                UpdateBy= u_b.FullName ?? cat.UpdateBy,
                                UpdateDate= cat.UpdateDate
                          };
            return lsCategory;
        }

        public void Save(Category category, string type)
        {
            if (type == "C")
            {
                try
                {
                    category.CompanyID = CompanyID;
                    category.CreateBy = UserID;
                    category.CreateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                    _context.Add(category);
                    _context.SaveChanges();
                    Log.Information("Create category successfully." + "Id " + category.CategoryID);
                }
                catch(Exception ex)
                {
                    Log.Error("Something went wrong while create category " + ex + "data " + JsonConvert.SerializeObject(category));
                    throw new Exception("Something went wrong.");
                }
            }
            else
            {
                var findCate = _context.Category.FirstOrDefault(x => x.CategoryID == category.CategoryID);
                if (findCate != null)
                {
                    try
                    {
                        findCate.CategoryName = category.CategoryName;
                        findCate.UpdateBy = UserID;
                        findCate.UpdateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                        _context.Update(findCate);
                        _context.SaveChanges();
                        Log.Information("Update category successfully." + "Id " + category.CategoryID);
                    }
                    catch(Exception ex)
                    {
                        Log.Error("Something went wrong while update category " + ex + "data " + JsonConvert.SerializeObject(category));
                        throw new Exception("Something went wrong.");
                    }
                }
                else
                {
                    Log.Error("Category id not found" + "data " + JsonConvert.SerializeObject(category));
                }
            }
        }
    }
}
