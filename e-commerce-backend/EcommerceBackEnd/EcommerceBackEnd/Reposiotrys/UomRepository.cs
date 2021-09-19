using Ecommerce.Core.AppContext;
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
    public class UomRepository : IUom
    {
        private readonly DataContext _context;
        public UomRepository(DataContext context)
        {
            _context = context;
        }
        public void Delete(Uom uom, string currentUser)
        {
            try
            {
                var data = _context.Uom.FirstOrDefault(x => x.UomID.Equals(uom.UomID));
                if (data == null)
                {
                    Log.Warning("Uom id not found." + uom.UomID);
                }
                else
                {
                    _context.Uom.Remove(data);
                    _context.SaveChanges();
                    Log.Information("Delete uom successfully. " + "data " + JsonConvert.SerializeObject(data) + "By user id" + currentUser);
                }
               
            }catch(Exception ex)
            {
                Log.Error("Something went wrong while delete uom." + ex + "Id " + uom.UomID);
                throw new Exception("Something went wrong.");
            }
        }

        public Uom FindById(string uomId)
        {
            var lsUom = from uom in _context.Uom
                        join x in _context.Users on uom.CreateBy equals x.Id into xx
                        from c_b in xx.DefaultIfEmpty()
                        join y in _context.Users on uom.UpdateBy equals y.Id into yy
                        from u_b in yy.DefaultIfEmpty()
                        join z in _context.CompanyProfile on uom.CompanyID equals z.CompanyID into zz
                        from com in zz.DefaultIfEmpty()
                        where uom.UomID == uomId
                        select new Uom
                        {
                            UomID = uom.UomID,
                            CreateBy = c_b.FullName ?? uom.CreateBy,
                            CreateDate = uom.CreateDate,
                            UomName = uom.UomName,
                            CompanyID = com.CompanyName ?? uom.CompanyID,
                            UpdateBy = u_b.FullName ?? uom.UpdateBy,
                            UpdateDate = uom.UpdateDate
                        };
            return lsUom.Count() > 0 ? lsUom.First() :null;
        }

        public IEnumerable<Uom> GetUoms(string companyId)
        {
            var lsUom = from uom in _context.Uom
                        join x in _context.Users on uom.CreateBy equals x.Id into xx from c_b in xx.DefaultIfEmpty()
                        join y in _context.Users on uom.UpdateBy equals y.Id into yy from u_b in yy.DefaultIfEmpty()
                        join z in _context.CompanyProfile on uom.CompanyID equals z.CompanyID into zz from com in zz.DefaultIfEmpty()
                        where uom.CompanyID == companyId
                        select new Uom
                        {
                            UomID = uom.UomID,
                            CreateBy = c_b.FullName ?? uom.CreateBy,
                            CreateDate = uom.CreateDate,
                            UomName = uom.UomName,
                            CompanyID=com.CompanyName ?? uom.CompanyID,
                            UpdateBy=u_b.FullName ?? uom.UpdateBy,
                            UpdateDate=uom.UpdateDate
                        };
            return lsUom;
        }

        public void Save(Uom uom, string currentUser, string companyId, string type) 
        {
            try
            {
                if (type == "C")
                {
                    uom.CompanyID = companyId;
                    uom.CreateBy = currentUser;
                    uom.CreateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                    _context.Add(uom);
                }
                else
                {
                    var findUom = _context.Uom.FirstOrDefault(x => x.UomID == uom.UomID);
                    if (findUom != null)
                    {
                        findUom.UomName = uom.UomName;
                        findUom.UpdateBy = currentUser;
                        findUom.UpdateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                        _context.Update(findUom);
                    }
                    else
                    {
                        Log.Error("Uom id not found" + "Id " + uom.UomID);
                    }
                }
                _context.SaveChanges();
                Log.Information("Create and update uom successfully." + "Id " + uom.UomID);
            }
            catch(Exception ex)
            {
                Log.Error("Something went wrong while create and update uom." + ex + "data " + JsonConvert.SerializeObject(uom));
                throw new Exception("Something went wrong.");
            }
        }
    }
}
