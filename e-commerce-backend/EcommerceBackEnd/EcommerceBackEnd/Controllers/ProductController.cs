using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Category;
using Ecommerce.Core.Model.ContractClass;
using Ecommerce.Core.Model.Product;
using Ecommerce.Core.Model.Uom;
using EcommerceBackEnd.Extension;
using EcommerceBackEnd.Models;
using EcommerceBackEnd.PathFiles;
using EcommerceBackEnd.PermissionUser;
using EcommerceBackEnd.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Serilog;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Controllers
{
    [Authorize]
    public class ProductController : BaseController
    {
        private readonly IProduct _product;
        private readonly DataContext _context;
        private readonly IPathConfiguation _pathConfiguation;

        public ProductController(IPathConfiguation pathConfiguation, IProduct product,
                                  DataContext context) : base(context)
        {
            _product = product;
            _context = context;
            _pathConfiguation = pathConfiguation;
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Product, AccessRightContract.List)]
        public IActionResult Index()
        {
            var lsProduct = _product.GetProducts(User.FindFirst("CompanyID").Value).Select(x => {
                x.Encryted = x.ProductID.Protection();
                return x;
            });
            ViewBag.Currency = _product.GetCurrency(User.FindFirst("CompanyID").Value);
            return View(lsProduct);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Product, AccessRightContract.Create)]
        public IActionResult Create(string respons)
        {
            if (respons == "T")
                ViewBag.Success = "Success";
            ViewData["Category"] = new SelectList(_context.Category.Where(x => x.Delete == false), "CategoryID", "CategoryName");
            ViewData["SubCategory"] = new SelectList(_context.SubCategory.Where(x => x.Delete == false), "SubCategoryID", "SubCategoryName");
            ViewData["Model"] = new SelectList(_context.ModelProduct.Where(x => x.Delete == false), "ModelID", "ModelName");
            ViewData["Uom"] = new SelectList(_context.Uom.Where(x => x.Delete == false), "UomID", "UomName");
            ViewBag.Currency = _product.GetCurrency(User.FindFirst("CompanyID").Value);
            return View();
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Product, AccessRightContract.Create)]
        public async Task<IActionResult> Create(Product model)
        {
            if (model.FormFile == null)
            {
                ViewBag.Error = "Product images is required.";
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var pro_code = _context.Product.FirstOrDefault(x => x.CompanyID == User.FindFirst("CompanyID").Value && x.ProductCode==model.ProductCode);
                    if (pro_code == null)
                    {
                        string fileName = null;
                        try
                        {   
                            if(model.FormFile!=null && model.FormFile.Count() > 0)
                            {
                                foreach (var Image in model.FormFile)
                                {
                                    string extension = Path.GetExtension(Image.FileName);
                                    string file = Guid.NewGuid() + extension;

                                    if (fileName == null)
                                        fileName = file;
                                    else
                                        fileName += "," + file;

                                    using (var fileStream = new FileStream(Path.Combine(_pathConfiguation.ProductPath, file), FileMode.Create))
                                    {
                                        await Image.CopyToAsync(fileStream);
                                    }
                                }
                                model.Images = fileName;
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.Error("Something went wrong save images product " + ex);
                        }
                        _product.Create(model, User.FindFirstValue(ClaimTypes.NameIdentifier), User.FindFirst("CompanyID").Value);

                        return RedirectToAction("create", "product", new { respons = "T" });
                    }
                    else
                    {
                        ViewBag.Error = "Product code has already.";
                    }
                } catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            ViewData["Category"] = new SelectList(_context.Category.Where(x => x.Delete == false), "CategoryID", "CategoryName");
            ViewData["SubCategory"] = new SelectList(_context.SubCategory.Where(x => x.Delete == false), "SubCategoryID", "SubCategoryName");
            ViewData["Model"] = new SelectList(_context.ModelProduct.Where(x => x.Delete == false), "ModelID", "ModelName");
            ViewData["Uom"] = new SelectList(_context.Uom.Where(x => x.Delete == false), "UomID", "UomName");
            ViewBag.Currency = _product.GetCurrency(User.FindFirst("CompanyID").Value);
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Product, AccessRightContract.Edit)]
        public IActionResult Edit(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var product = _product.FindById(key.UnProtection());
            if (product == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            product.CodeTemp = product.ProductCode;
            ViewData["Category"] = new SelectList(_context.Category.Where(x => x.Delete == false), "CategoryID", "CategoryName");
            ViewData["SubCategory"] = new SelectList(_context.SubCategory.Where(x => x.Delete == false), "SubCategoryID", "SubCategoryName");
            ViewData["Model"] = new SelectList(_context.ModelProduct.Where(x => x.Delete == false), "ModelID", "ModelName");
            ViewData["Uom"] = new SelectList(_context.Uom.Where(x => x.Delete == false), "UomID", "UomName");
            ViewBag.Currency = _product.GetCurrency(User.FindFirst("CompanyID").Value);
            return View(product);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Product, AccessRightContract.Edit)]
        public async Task<IActionResult> Edit(Product model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var pro_code = _context.Product.FirstOrDefault(x => x.CompanyID == User.FindFirst("CompanyID").Value && x.ProductCode == model.ProductCode && x.ProductCode!=model.CodeTemp);
                    if (pro_code == null)
                    {
                        string fileName = null;
                        try
                        {
                            if (model.FormFile != null && model.FormFile.Count() > 0)
                            {
                                foreach (var Image in model.FormFile)
                                {
                                    string extension = Path.GetExtension(Image.FileName);
                                    string file = Guid.NewGuid() + extension;

                                    if (fileName == null)
                                        fileName = file;
                                    else
                                        fileName += "," + file;

                                    using (var fileStream = new FileStream(Path.Combine(_pathConfiguation.ProductPath, file), FileMode.Create))
                                    {
                                        await Image.CopyToAsync(fileStream);
                                    }
                                }
                                model.Images = fileName;
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.Error("Something went wrong save images product " + ex);
                        }
                        _product.Edit(model, User.FindFirstValue(ClaimTypes.NameIdentifier), User.FindFirst("CompanyID").Value);

                        return RedirectToAction("index", "product");
                    }
                    else
                    {
                        ViewBag.Error = "Product code has already.";
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            ViewData["Category"] = new SelectList(_context.Category.Where(x => x.Delete == false), "CategoryID", "CategoryName");
            ViewData["SubCategory"] = new SelectList(_context.SubCategory.Where(x => x.Delete == false), "SubCategoryID", "SubCategoryName");
            ViewData["Model"] = new SelectList(_context.ModelProduct.Where(x => x.Delete == false), "ModelID", "ModelName");
            ViewData["Uom"] = new SelectList(_context.Uom.Where(x => x.Delete == false), "UomID", "UomName");
            ViewBag.Currency = _product.GetCurrency(User.FindFirst("CompanyID").Value);
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Product, AccessRightContract.Delete)]
        public IActionResult Delete(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var product = _product.FindById(key.UnProtection());
            if (product == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            ViewBag.Currency = _product.GetCurrency(User.FindFirst("CompanyID").Value);
            return View(product);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Product, AccessRightContract.Delete)]
        public IActionResult Delete(Product model)
        {
            try
            {
                _product.Delete(model, User.FindFirstValue(ClaimTypes.NameIdentifier));
                return RedirectToAction("index", "product");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult FilterCategory(string CateId)
        {
            var sub = _context.SubCategory.Where(x => x.CategoryID == CateId);
            return Ok(sub);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Product, AccessRightContract.List)]
        public IActionResult ProductCatalogue()
        {
            return View();
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Product, AccessRightContract.List)]
        public IActionResult GetDataCatalogue(int pageIndex,int pageSize)
        {
            var currency = _product.GetCurrency(User.FindFirst("CompanyID").Value);
            var lsProduct = _product.GetProducts(User.FindFirst("CompanyID").Value).Skip(pageIndex*pageSize).Take(pageSize).Select(x =>
            {
                x.Encryted = x.ProductID.Protection();
                x.Currency = currency;
                return x;
            });
            return Ok(JsonConvert.SerializeObject(lsProduct.ToList()));
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Product, AccessRightContract.See)]
        public IActionResult See(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var product = _product.FindById(key.UnProtection());
            if (product == null)
            {
                Log.Error("Product id not found" + key.UnProtection());
                return RedirectToAction("PageNotFound", "Home");
            }
            ViewBag.Currency = _product.GetCurrency(User.FindFirst("CompanyID").Value);
            return View(product);
        }
        [HttpGet]
        public IActionResult GetItemById(string ItemId)
        {
            if (ItemId == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var product = _product.FindById(ItemId.UnProtection());
            if (product == null)
            {
                Log.Error("Product id not found" + ItemId.UnProtection());
                return RedirectToAction("PageNotFound", "Home");
            }
            product.Currency = _product.GetCurrency(User.FindFirst("CompanyID").Value);
            return Ok(JsonConvert.SerializeObject(product));
        }
    }
}
