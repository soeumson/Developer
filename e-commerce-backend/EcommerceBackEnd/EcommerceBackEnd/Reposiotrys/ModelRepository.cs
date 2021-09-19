using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Model;
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
    public class ModelRepository : IModel
    {
        private readonly DataContext _context;
        public ModelRepository(DataContext context)
        {
            _context = context;
        }
        public void Delete(ModelProduct model, string currentUser)
        {
            try
            {
                var data = _context.ModelProduct.FirstOrDefault(x => x.ModelID.Equals(model.ModelID));
                if (data == null)
                {
                    Log.Warning("Model id not found" + model.ModelID);
                }
                else
                {
                    _context.ModelProduct.Remove(data);
                    _context.SaveChanges();
                    Log.Information("Delete model successfully " + "data" + JsonConvert.SerializeObject(data) + "By user id" + currentUser);
                }
               
            }catch(Exception ex)
            {
                Log.Error("Something went wrong delete model" + ex + "Id " + model.ModelID);
                throw new Exception("Something went wrong.");
            }
        }

        public ModelProduct FindById(string modelId)
        {
            var lsModel = from model in _context.ModelProduct
                          join x in _context.Users on model.CreateBy equals x.Id into xx
                          from c_b in xx.DefaultIfEmpty()
                          join y in _context.Users on model.UpdateBy equals y.Id into yy
                          from u_b in yy.DefaultIfEmpty()
                          join z in _context.CompanyProfile on model.CompanyID equals z.CompanyID into zz
                          from com in zz.DefaultIfEmpty()
                          where model.ModelID == modelId 
                          select new ModelProduct
                          {
                              ModelID = model.ModelID,
                              CreateBy = c_b.FullName ?? model.CreateBy,
                              CreateDate = model.CreateDate,
                              ModelName = model.ModelName,
                              Status = model.Status,
                              UpdateBy = u_b.FullName ?? model.UpdateBy,
                              UpdateDate = model.UpdateDate,
                              CompanyID = com.CompanyName ?? model.CompanyID
                          };
            return lsModel.Count() > 0 ? lsModel.First() :null;
        }

        public IEnumerable<ModelProduct> GetModels(string companyId)
        {
            var lsModel = from model in _context.ModelProduct
                          join x in _context.Users on model.CreateBy equals x.Id into xx from c_b in xx.DefaultIfEmpty()
                          join y in _context.Users on model.UpdateBy equals y.Id into yy from u_b in yy.DefaultIfEmpty()
                          join z in _context.CompanyProfile on model.CompanyID equals z.CompanyID into zz from com in zz.DefaultIfEmpty()
                          where model.CompanyID == companyId
                          select new ModelProduct
                          {
                             ModelID = model.ModelID,
                             CreateBy = c_b.FullName ?? model.CreateBy,
                             CreateDate = model.CreateDate,
                             ModelName = model.ModelName,
                             Status=model.Status,
                             UpdateBy=u_b.FullName ?? model.UpdateBy,
                             UpdateDate=model.UpdateDate,
                             CompanyID =com.CompanyName ?? model.CompanyID
                          };
            return lsModel;
        }

        public void Save(ModelProduct model, string currentUser, string companyId, string type)
        {
            try
            { 
                if (type == "C") 
                {
                    model.CompanyID = companyId;
                    model.CreateBy = currentUser;
                    model.CreateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                    _context.Add(model);
                }
                else
                {
                    var findModel = _context.ModelProduct.FirstOrDefault(x => x.ModelID == model.ModelID);
                    if (findModel != null)
                    {
                        findModel.ModelName = model.ModelName;
                        findModel.UpdateBy = currentUser;
                        findModel.UpdateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                        _context.Update(findModel);
                    }
                    else
                    {
                        Log.Error("Model id not found" + "Id" + model.ModelID);
                    }
                }
                _context.SaveChanges();
                Log.Information("Create and update model successfully" + "Id" + model.ModelID);
            }
            catch(Exception ex)
            {
                Log.Error("Something went wrong while create and update model " + ex +"data " + JsonConvert.SerializeObject(model));
                throw new Exception("Something went wrong.");
            }
        }
    }
}
