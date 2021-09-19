using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Account;
using Ecommerce.Core.Model.Company;
using EcommerceBackEnd.Extension;
using EcommerceBackEnd.Models;
using EcommerceBackEnd.Services;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Reposiotrys
{
    public class CompanyRepository : ICompany
    {
        private readonly DataContext _context;
        public CompanyRepository(DataContext context )
        {
            _context = context;
        }
        public async Task CompanyProfile(CompanyProfile company, string currentUser, ClaimsIdentity claimsIdentity)
        {
            try
            {   
                company.UserID = currentUser;
                company.CreateBy = currentUser;
                company.CreateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                _context.CompanyProfile.Add(company);
                await _context.SaveChangesAsync();

                var findUser = _context.Users.FirstOrDefault(x => x.Id == currentUser);
                if(findUser!= null)
                {  
                    findUser.CompanyID = company.CompanyID;
                    claimsIdentity.AddClaim(new Claim("CompanyID", company.CompanyID ?? ""));
                    _context.Update(findUser);
                    _context.SaveChanges();
                }
                Log.Information("Successfully create shop profile.");

            }catch(Exception ex)
            {
                Log.Error("Something went wrong: " + ex.Message);
                throw new Exception("Something went wrong");
            }
        }
     
        public IEnumerable<CompanyProfile> GetCompanyProfiles(string companyId)
        {
            var company = from c in _context.CompanyProfile
                          join x in _context.Users on c.CreateBy equals x.Id into xx from c_b in xx.DefaultIfEmpty()
                          join y in _context.Users on c.UpdateBy equals y.Id into yy from u_b in yy.DefaultIfEmpty()
                          join z in _context.Currency on c.CurrencyID equals z.CurrencyID into zz from cur in zz.DefaultIfEmpty()
                          where c.CompanyID == companyId
                          select new CompanyProfile
                          {
                              Encryted=c.CompanyID.Protection(),
                              BannerImage=c.BannerImage,
                              CompanyID=c.CompanyID,
                              CompanyAddress=c.CompanyAddress,
                              CompanyDescription=c.CompanyDescription,
                              CompanyEmail=c.CompanyEmail,
                              CompanyName=c.CompanyName,
                              CompanyPhone=c.CompanyPhone,
                              CreateBy=c_b.FullName ?? c.CreateBy,
                              CreateDate=c.CreateDate,
                              CurrencyID = c.CurrencyID,
                              CurrencyName = cur.CurrencyName ?? c.CurrencyID,
                              Logo =c.Logo,
                              UpdateBy=u_b.FullName ?? c.UpdateBy,
                              UpdateDate=c.UpdateDate,
                              UserID=c.UserID,
                              Status=c.Status
                          };
            return company;
        }
        public CompanyProfile FindById(string key)
        {
           var company = from c in _context.CompanyProfile
                          join x in _context.Users on c.CreateBy equals x.Id into xx from c_b in xx.DefaultIfEmpty()
                          join y in _context.Users on c.UpdateBy equals y.Id into yy from u_b in yy.DefaultIfEmpty()
                          join z in _context.Currency on c.CurrencyID equals z.CurrencyID into zz from cur in zz.DefaultIfEmpty()
                          where c.CompanyID == key
                          select new CompanyProfile
                          {
                              Encryted=c.CompanyID.Protection(),
                              BannerImage=c.BannerImage,
                              CompanyID=c.CompanyID,
                              CompanyAddress=c.CompanyAddress,
                              CompanyDescription=c.CompanyDescription,
                              CompanyEmail=c.CompanyEmail,
                              CompanyName=c.CompanyName,
                              CompanyPhone=c.CompanyPhone,
                              CreateBy=c_b.FullName ?? c.CreateBy,
                              CreateDate=c.CreateDate,
                              CurrencyID =c.CurrencyID,
                              CurrencyName= cur.CurrencyName ?? c.CurrencyID,
                              Logo =c.Logo,
                              UpdateBy=u_b.FullName ?? c.UpdateBy,
                              UpdateDate=c.UpdateDate,
                              UserID=c.UserID,
                              Status=c.Status
                          };
            return company.Count() > 0 ? company.First():null;
        }

        public void Edit(CompanyProfile company, string currentUser)
        {
            try
            {
                var com = _context.CompanyProfile.FirstOrDefault(x => x.CompanyID == company.Encryted.UnProtection());
                if (com != null)
                {
                    com.CompanyName = company.CompanyName;
                    com.CompanyPhone = company.CompanyPhone;
                    com.CompanyEmail = company.CompanyEmail;
                    com.CompanyDescription = company.CompanyDescription;
                    com.CompanyAddress = company.CompanyAddress;
                    com.CurrencyID = company.CurrencyID;
                    com.Logo = company.Logo;
                    com.Status = company.Status;
                    com.UpdateBy = currentUser;
                    com.UpdateDate= Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                    
                    _context.Update(com);
                    _context.SaveChanges();
                }
               
            }catch(Exception ex)
            {
                Log.Error("Update shop something went wrong." + ex.Message);
                throw new Exception("Something went wrong");
            }
        }
    }
}
