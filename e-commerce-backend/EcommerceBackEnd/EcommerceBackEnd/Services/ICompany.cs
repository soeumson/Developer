using Ecommerce.Core.Model.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Services
{
    public interface ICompany
    {
        IEnumerable<CompanyProfile> GetCompanyProfiles(string companyId);
        Task CompanyProfile(CompanyProfile company,string currentUser,ClaimsIdentity claimsIdentity);
        CompanyProfile FindById(string key);
        void Edit(CompanyProfile company, string currentUser);
    }
}
