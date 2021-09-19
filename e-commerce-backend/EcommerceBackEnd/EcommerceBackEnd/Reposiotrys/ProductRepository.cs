using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Product;
using EcommerceBackEnd.Services;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;


namespace EcommerceBackEnd.Reposiotrys
{
    
    public class ProductRepository : IProduct
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public void Delete(Product product , string currentUser)
        {
            try
            {
                var data = _context.Product.FirstOrDefault(x => x.ProductID.Equals(product.ProductID));
                if (data == null)
                {
                    Log.Warning("Product id not found" + product.ProductID);
                }
                else
                {
                    _context.Product.Remove(data);
                    _context.SaveChanges();

                    Log.Information("Product delete  successfully " + "data" + JsonConvert.SerializeObject(data) + "By user id" + currentUser);
                }
               
            }catch(Exception ex)
            {
                Log.Error("Something went wrong while delete product" + ex + "Id " + product.ProductID);
                throw new Exception("Something went wrong.");
            }
        }
        public Product FindById(string productId)
        {
            var lsProduct = from product in _context.Product
                          
                            join cat1 in _context.Category on product.CategoryID equals cat1.CategoryID into p_cat from cat in p_cat.DefaultIfEmpty()
                            join sub in _context.SubCategory.DefaultIfEmpty() on product.SubCategoryID equals sub.SubCategoryID into pro_sub from p_s in pro_sub.DefaultIfEmpty()
                            join model in _context.ModelProduct.DefaultIfEmpty() on product.ModelID equals model.ModelID into pro_model from p_m in pro_model.DefaultIfEmpty()
                            join uom1 in _context.Uom on product.UomID equals uom1.UomID into p_uom from uom in p_uom.DefaultIfEmpty()

                            join x in _context.Users on product.CreateBy equals x.Id into xx from c_b in xx.DefaultIfEmpty()
                            join y in _context.Users on product.UpdateBy equals y.Id into yy from u_b in yy.DefaultIfEmpty()
                            join z in _context.CompanyProfile on product.CompanyID equals z.CompanyID into zz from com in zz.DefaultIfEmpty()
                            where product.ProductID ==productId 
                            select new Product
                            {
                                ProductID = product.ProductID,
                                ProductCode = product.ProductCode,
                                CodeTemp=product.ProductCode,
                                ProductName = product.ProductName,
                                CategoryID = product.CategoryID,
                                CategoryName = cat.CategoryName ?? product.CategoryID,
                                SubCategoryID = product.SubCategoryID,
                                SubCategoryName = p_s.SubCategoryName ?? product.SubCategoryID,
                                ModelID = product.ModelID,
                                ModelName = p_m.ModelName ?? product.ModelID,
                                UomID = product.UomID,
                                UomName = uom.UomName ?? product.UomID,
                                Qty = product.Qty,
                                Price = product.Price,
                                TotalOrder=product.TotalOrder,
                                Description = product.Description,
                                Images = product.Images,
                                ManageStock = product.ManageStock,
                                StatusAvailable = product.StatusAvailable,
                                DiscountActive = product.DiscountActive,
                                DiscountValue = product.DiscountValue,
                                DiscountType = product.DiscountType,
                                FeeIncluded = product.FeeIncluded,
                                VatIncluded = product.VatIncluded,
                                CreateDate = product.CreateDate,
                                CreateBy = c_b.FullName ?? product.CreateBy,
                                CompanyID=com.CompanyName ?? product.CompanyID,
                                Status=product.Status,
                                UpdateBy=u_b.FullName ?? product.UpdateBy,
                                UpdateDate=product.UpdateDate,
                                Favourite=product.Favourite
                              
                            };
            return lsProduct==null ? null : lsProduct.First();
        }

        public IEnumerable<Product> GetProducts(string companyId) 
        {
            var lsProduct = from product in _context.Product
                          
                            join cat1 in _context.Category on product.CategoryID equals cat1.CategoryID into p_cat from cat in p_cat.DefaultIfEmpty()
                            join sub in _context.SubCategory.DefaultIfEmpty() on product.SubCategoryID equals sub.SubCategoryID into pro_sub from p_s in pro_sub.DefaultIfEmpty()
                            join model in _context.ModelProduct.DefaultIfEmpty() on product.ModelID equals model.ModelID into pro_model from p_m in pro_model.DefaultIfEmpty()
                            join uom1 in _context.Uom on product.UomID equals uom1.UomID into p_uom from uom in p_uom.DefaultIfEmpty()

                            join x in _context.Users on product.CreateBy equals x.Id into xx from c_b in xx.DefaultIfEmpty()
                            join y in _context.Users on product.UpdateBy equals y.Id into yy from u_b in yy.DefaultIfEmpty()
                            join z in _context.CompanyProfile on product.CompanyID equals z.CompanyID into zz from com in zz.DefaultIfEmpty()
                            where product.CompanyID ==companyId 
                            select new Product
                            {
                                ProductID = product.ProductID,
                                ProductCode = product.ProductCode,
                                CodeTemp=product.ProductCode,
                                ProductName = product.ProductName,
                                CategoryID = product.CategoryID,
                                CategoryName = cat.CategoryName ?? product.CategoryID,
                                SubCategoryID = product.SubCategoryID,
                                SubCategoryName = p_s.SubCategoryName ?? product.SubCategoryID,
                                ModelID = product.ModelID,
                                ModelName = p_m.ModelName ?? product.ModelID,
                                UomID = product.UomID,
                                UomName = uom.UomName ?? product.UomID,
                                Qty = product.Qty,
                                Price = product.Price,
                                TotalOrder=product.TotalOrder,
                                Description = product.Description,
                                Images = product.Images,
                                ManageStock = product.ManageStock,
                                StatusAvailable = product.StatusAvailable,
                                DiscountActive = product.DiscountActive,
                                DiscountValue = product.DiscountValue,
                                DiscountType = product.DiscountType,
                                FeeIncluded = product.FeeIncluded,
                                VatIncluded = product.VatIncluded,
                                CreateDate = product.CreateDate,
                                CreateBy = u_b.FullName ?? product.CreateBy,
                                CompanyID=com.CompanyName ?? product.CompanyID,
                                Status=product.Status,
                                UpdateBy=u_b.FullName ?? product.UpdateBy,
                                UpdateDate=product.UpdateDate,
                                Favourite=product.Favourite
                              
                            };
            return lsProduct;
        }
        public void Create(Product product, string currentUser, string companyId)
        {
            try
            {
                product.CompanyID = companyId;
                product.CreateBy = currentUser;
                product.CreateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                _context.Add(product);
                _context.SaveChanges();
                Log.Information("Create product successfully." + "Id " + product.ProductID);
            }
            catch(Exception ex)
            {
                Log.Error("Something went wrong while create prodcut " + ex + "data " + JsonConvert.SerializeObject(product));
                throw new Exception("Something went wrong.");
            }
        }
        public void Edit(Product product, string currentUser, string companyId)
        {
            try
            {
                var findProduct = _context.Product.FirstOrDefault(x => x.ProductID.Equals(product.ProductID));
                if (findProduct == null)
                {
                    Log.Warning("Porduct id not found " + product.ProductID);
                }
                else
                {
                    findProduct.ProductCode = product.ProductCode;
                    findProduct.ProductName = product.ProductName;
                    findProduct.CategoryID = product.CategoryID;
                    findProduct.SubCategoryID = product.SubCategoryID;
                    findProduct.ModelID = product.ModelID;
                    findProduct.UomID = product.UomID;
                    findProduct.Qty = product.Qty;
                    findProduct.Price = product.Price;
                    findProduct.Description = product.Description;
                    findProduct.Images = product.Images==null? findProduct.Images:product.Images;
                    findProduct.ManageStock = product.ManageStock;
                    findProduct.StatusAvailable = product.StatusAvailable;
                    findProduct.DiscountActive = product.DiscountActive;
                    findProduct.DiscountValue = product.DiscountValue;
                    findProduct.DiscountType = product.DiscountType;
                    findProduct.FeeIncluded = product.FeeIncluded;
                    findProduct.VatIncluded = product.VatIncluded;
                    findProduct.UpdateBy = currentUser;
                    findProduct.UpdateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                    _context.Update(findProduct);
                    _context.SaveChanges();
                    Log.Information("Update product successfully." + "data" + "Id " + product.ProductID);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong while update prodcut " + ex + "data " + JsonConvert.SerializeObject(product));
                throw new Exception("Something went wrong.");
            }
        }

        public string GetCurrency(string companyId)
        {
            string currency = "";
            var company = _context.CompanyProfile.FirstOrDefault(x => x.CompanyID.Equals(companyId));
            if (company != null)
            {
                var cur = _context.Currency.FirstOrDefault(x => x.CurrencyID == company.CurrencyID);
                if (cur != null)
                {
                    currency = cur.CurrencyName;
                }
            }
            return currency;
        }
    }
}
