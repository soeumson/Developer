using EcommercApi.Models.Products;
using EcommercApi.Services;
using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Category;
using Ecommerce.Core.Model.Company;
using Ecommerce.Core.Model.Model;
using Ecommerce.Core.Model.Product;
using Ecommerce.Core.Model.Uom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercApi.Repositories
{
    public class MasterDataRepository : IMasterData
    {
        private readonly DataContext _context;
        public MasterDataRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetProducts()
        {
            var lsProduct = from product in _context.Product

                            join cat1 in _context.Category on product.CategoryID equals cat1.CategoryID into p_cat
                            from cat in p_cat.DefaultIfEmpty()
                            join sub in _context.SubCategory.DefaultIfEmpty() on product.SubCategoryID equals sub.SubCategoryID into pro_sub
                            from p_s in pro_sub.DefaultIfEmpty()
                            join model in _context.ModelProduct.DefaultIfEmpty() on product.ModelID equals model.ModelID into pro_model
                            from p_m in pro_model.DefaultIfEmpty()
                            join uom1 in _context.Uom on product.UomID equals uom1.UomID into p_uom
                            from uom in p_uom.DefaultIfEmpty()

                            join x in _context.Users on product.CreateBy equals x.Id into xx
                            from c_b in xx.DefaultIfEmpty()
                            join y in _context.Users on product.UpdateBy equals y.Id into yy
                            from u_b in yy.DefaultIfEmpty()
                            join z in _context.CompanyProfile on product.CompanyID equals z.CompanyID into zz
                            from com in zz.DefaultIfEmpty()
                            join cr in _context.Currency on com.CurrencyID equals cr.CurrencyID into cc 
                            from cur in cc.DefaultIfEmpty()
                            select new Product
                            {
                                ProductID = product.ProductID,
                                ProductCode = product.ProductCode,
                                CodeTemp = product.ProductCode,
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
                                TotalOrder = product.TotalOrder,
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
                                CompanyID = product.CompanyID,
                                Status = product.Status,
                                UpdateBy = u_b.FullName ?? product.UpdateBy,
                                UpdateDate = product.UpdateDate,
                                Favourite = product.Favourite,
                                CompanyName= com.CompanyName ?? product.CompanyID,
                                Currency=cur.CurrencyName
                            };
            return lsProduct;
        }
        public Product GetProductById(string productId)
        {
            var lsProduct = from product in _context.Product

                            join cat1 in _context.Category on product.CategoryID equals cat1.CategoryID into p_cat
                            from cat in p_cat.DefaultIfEmpty()
                            join sub in _context.SubCategory.DefaultIfEmpty() on product.SubCategoryID equals sub.SubCategoryID into pro_sub
                            from p_s in pro_sub.DefaultIfEmpty()
                            join model in _context.ModelProduct.DefaultIfEmpty() on product.ModelID equals model.ModelID into pro_model
                            from p_m in pro_model.DefaultIfEmpty()
                            join uom1 in _context.Uom on product.UomID equals uom1.UomID into p_uom
                            from uom in p_uom.DefaultIfEmpty()

                            join x in _context.Users on product.CreateBy equals x.Id into xx
                            from c_b in xx.DefaultIfEmpty()
                            join y in _context.Users on product.UpdateBy equals y.Id into yy
                            from u_b in yy.DefaultIfEmpty()
                            join z in _context.CompanyProfile on product.CompanyID equals z.CompanyID into zz
                            from com in zz.DefaultIfEmpty()
                            join cr in _context.Currency on com.CurrencyID equals cr.CurrencyID into cc
                            from cur in cc.DefaultIfEmpty()
                            where product.ProductID== productId
                            select new Product
                            {
                                ProductID = product.ProductID,
                                ProductCode = product.ProductCode,
                                CodeTemp = product.ProductCode,
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
                                TotalOrder = product.TotalOrder,
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
                                CompanyID = product.CompanyID,
                                Status = product.Status,
                                UpdateBy = u_b.FullName ?? product.UpdateBy,
                                UpdateDate = product.UpdateDate,
                                Favourite = product.Favourite,
                                CompanyName = com.CompanyName ?? product.CompanyID,
                                Currency = cur.CurrencyName
                            };
            return lsProduct.Count() > 0 ? lsProduct.First() : null;
        }
        public IEnumerable<CompanyProfile> GetShop()
        {
            var company = from c in _context.CompanyProfile
                          join x in _context.Users on c.CreateBy equals x.Id into xx
                          from c_b in xx.DefaultIfEmpty()
                          join y in _context.Users on c.UpdateBy equals y.Id into yy
                          from u_b in yy.DefaultIfEmpty()
                          join z in _context.Currency on c.CurrencyID equals z.CurrencyID into zz
                          from cur in zz.DefaultIfEmpty()
                          select new CompanyProfile
                          {
                            
                              BannerImage = c.BannerImage,
                              CompanyID = c.CompanyID,
                              CompanyAddress = c.CompanyAddress,
                              CompanyDescription = c.CompanyDescription,
                              CompanyEmail = c.CompanyEmail,
                              CompanyName = c.CompanyName,
                              CompanyPhone = c.CompanyPhone,
                              CreateBy = c_b.FullName ?? c.CreateBy,
                              CreateDate = c.CreateDate,
                              CurrencyID = c.CurrencyID,
                              CurrencyName = cur.CurrencyName ?? c.CurrencyID,
                              Logo = c.Logo,
                              UpdateBy = u_b.FullName ?? c.UpdateBy,
                              UpdateDate = c.UpdateDate,
                              UserID = c.UserID,
                              Status = c.Status
                          };
            return company;
        }
        public IEnumerable<Category> GetCategories()
        {
            var lsCategory = from cat in _context.Category
                             join x in _context.Users on cat.CreateBy equals x.Id into xx
                             from c_b in xx.DefaultIfEmpty()
                             join y in _context.Users on cat.UpdateBy equals y.Id into yy
                             from u_b in yy.DefaultIfEmpty()
                             join z in _context.CompanyProfile on cat.CompanyID equals z.CompanyID into zz
                             from com in zz.DefaultIfEmpty()
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
            return lsCategory;
        }
        public OtherProducts GetOtherProducts()
        {
            var product_arrival = GetProducts().Take(10).Where(x=>Convert.ToDateTime(x.CreateDate).AddDays(90) >= DateTime.Now).ToList();
            var product_bestseller = GetProducts().Take(10).OrderByDescending(x => x.TotalOrder).ToList();
            var producct_feature = GetProducts().Take(10).OrderByDescending(x => x.Price).ToList();
            var product_sepcial = GetProducts().Take(3).OrderByDescending(x => x.Favourite).ToList();
            var otherProduct = new OtherProducts
            {
                ProductArrival=product_arrival,
                ProductBestseller=product_bestseller,
                FeatureProduct=producct_feature,
                SpecialProduct=product_sepcial
            };
            return otherProduct;
        }
        public SingleProduct GetSingleProduct(string productId)
        {
            var result = new SingleProduct();
            var productById = GetProductById(productId);
            if (productById != null)
            {
                result.Product = productById;
                result.ModelProducts = GetProducts().Where(x => x.ModelID !=null && x.ModelID == productById.ModelID && x.CompanyID ==productById.CompanyID).ToList();
                result.RelateProducts = GetProducts().Where(x => x.CategoryName.Contains(productById.CategoryName) && x.ProductID != productId).ToList();
            }
            return result;
        }
        public IEnumerable<SubCategory> GetSubCategories()
        {
            var lsSub = from sub in _context.SubCategory
                        join cat1 in _context.Category on sub.CategoryID equals cat1.CategoryID into s_cat
                        from cat in s_cat.DefaultIfEmpty()
                        join x in _context.Users on sub.CreateBy equals x.Id into xx
                        from c_b in xx.DefaultIfEmpty()
                        join y in _context.Users on sub.UpdateBy equals y.Id into yy
                        from u_b in yy.DefaultIfEmpty()
                        join z in _context.CompanyProfile on sub.CompanyID equals z.CompanyID into zz
                        from com in zz.DefaultIfEmpty()
                        select new SubCategory
                        {
                            SubCategoryID = sub.SubCategoryID,
                            CreateBy = c_b.FullName ?? sub.CreateBy,
                            CreateDate = sub.CreateDate,
                            SubCategoryName = sub.SubCategoryName,
                            CategoryID = sub.CategoryID,
                            CategroyName = cat.CategoryName ?? sub.CategoryID,
                            CompanyID = com.CompanyName ?? sub.CompanyID,
                            Status = sub.Status,
                            UpdateBy = u_b.FullName ?? sub.UpdateBy,
                            UpdateDate = sub.UpdateDate
                        };
            return lsSub;
        }
        public IEnumerable<Uom> GetUoms()
        {
            var lsUom = from uom in _context.Uom
                        join x in _context.Users on uom.CreateBy equals x.Id into xx
                        from c_b in xx.DefaultIfEmpty()
                        join y in _context.Users on uom.UpdateBy equals y.Id into yy
                        from u_b in yy.DefaultIfEmpty()
                        join z in _context.CompanyProfile on uom.CompanyID equals z.CompanyID into zz
                        from com in zz.DefaultIfEmpty()
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
            return lsUom;
        }
        public IEnumerable<ModelProduct> GetModelProducts()
        {
            var lsModel = from model in _context.ModelProduct
                          join x in _context.Users on model.CreateBy equals x.Id into xx
                          from c_b in xx.DefaultIfEmpty()
                          join y in _context.Users on model.UpdateBy equals y.Id into yy
                          from u_b in yy.DefaultIfEmpty()
                          join z in _context.CompanyProfile on model.CompanyID equals z.CompanyID into zz
                          from com in zz.DefaultIfEmpty()
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
            return lsModel;
        }
        public MoreProducts GetMoreProducts()
        {
            return null;
        }
    }
}
