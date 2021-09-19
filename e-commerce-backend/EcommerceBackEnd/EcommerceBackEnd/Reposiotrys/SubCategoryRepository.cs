using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Category;
using Ecommerce.Core.Model.Uom;
using EcommerceBackEnd.Services;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Reposiotrys
{
    public class SubCategoryRepository : ISubCategory
    {
        private readonly DataContext _context;
        public SubCategoryRepository(DataContext context)
        {
            _context = context;
        }
        public void Delete(SubCategory sub , string currentUser)
        {
            try
            {
                var data = _context.SubCategory.FirstOrDefault(x => x.SubCategoryID.Equals(sub.SubCategoryID));
                if (data == null)
                {
                    Log.Warning("Sub category id not found." + sub.SubCategoryID);
                }
                else
                {
                    _context.SubCategory.Remove(data);
                    _context.SaveChanges(); 

                    Log.Information("Delete sub category successfully " + "data" + JsonConvert.SerializeObject(data) + "By user id" + currentUser);
                }
               
            }catch(Exception ex)
            {
                Log.Error("Something went wrong while delete sub category." + ex + "Id " + sub.SubCategoryID);
                throw new Exception("Something went wrong.");
            }
        }

        public SubCategory FindById(string subId)
        {
            var lsSub = from sub in _context.SubCategory
                        join cat1 in _context.Category on sub.CategoryID equals cat1.CategoryID into s_cat from cat in s_cat.DefaultIfEmpty()
                        join x in _context.Users on sub.CreateBy equals x.Id into xx from c_b in xx.DefaultIfEmpty()
                        join y in _context.Users on sub.UpdateBy equals y.Id into yy from u_b in yy.DefaultIfEmpty()
                        join z in _context.CompanyProfile on sub.CompanyID equals z.CompanyID into zz from com in zz.DefaultIfEmpty()
                        where sub.SubCategoryID == subId
                        select new SubCategory
                        {
                            SubCategoryID = sub.SubCategoryID,
                            CreateBy = c_b.FullName ?? sub.CreateBy,
                            CreateDate = sub.CreateDate,
                            SubCategoryName = sub.SubCategoryName,
                            CategoryID=sub.CategoryID,
                            CategroyName=cat.CategoryName ?? sub.CategoryID,
                            CompanyID=com.CompanyName  ?? sub.CompanyID,
                            Status=sub.Status,
                            UpdateBy=u_b.FullName ?? sub.UpdateBy,
                            UpdateDate=sub.UpdateDate
                        };
            return lsSub.Count() > 0 ? lsSub.First() :null;
        }

        public IEnumerable<SubCategory> GetSubCategories(string companyId) 
        {
            var lsSub = from sub in _context.SubCategory
                        join cat1 in _context.Category on sub.CategoryID equals cat1.CategoryID into s_cat from cat in s_cat.DefaultIfEmpty()
                        join x in _context.Users on sub.CreateBy equals x.Id into xx from c_b in xx.DefaultIfEmpty()
                        join y in _context.Users on sub.UpdateBy equals y.Id into yy from u_b in yy.DefaultIfEmpty()
                        join z in _context.CompanyProfile on sub.CompanyID equals z.CompanyID into zz from com in zz.DefaultIfEmpty()
                        where sub.CompanyID == companyId
                        select new SubCategory
                        {
                            SubCategoryID = sub.SubCategoryID,
                            CreateBy = c_b.FullName ?? sub.CreateBy,
                            CreateDate = sub.CreateDate,
                            SubCategoryName = sub.SubCategoryName,
                            CategoryID=sub.CategoryID,
                            CategroyName=cat.CategoryName ?? sub.CategoryID,
                            CompanyID=com.CompanyName  ?? sub.CompanyID,
                            Status=sub.Status,
                            UpdateBy=u_b.FullName ?? sub.UpdateBy,
                            UpdateDate=sub.UpdateDate
                        };
            return lsSub;
        }

        public void Save(SubCategory sub, string currentUser, string companyId, string type)
        {
            try
            {
                if (type == "C")
                {
                    sub.CompanyID = companyId;
                    sub.CreateBy = currentUser;
                    sub.CreateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                    _context.Add(sub);
                }
                else
                {
                    var findSub = _context.SubCategory.FirstOrDefault(x => x.SubCategoryID == sub.SubCategoryID);
                    if (findSub != null)
                    {
                        findSub.SubCategoryName = sub.SubCategoryName;
                        findSub.CategoryID = sub.CategoryID;
                        findSub.UpdateBy = currentUser;
                        findSub.UpdateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                        _context.Update(findSub);
                    }
                    else
                    {
                        Log.Error("Sub category id not found. " + "Id " + sub.SubCategoryID);
                    }
                }
                _context.SaveChanges();
                Log.Information("Create and update sub category successfully." + "Id " + sub.SubCategoryID);
            }
            catch(Exception ex)
            {
                Log.Error("Something went wrong while create and update sub category " + ex + "data "  + JsonConvert.SerializeObject(sub));
                throw new Exception("Something went wrong.");
            }
        }
    }
}
