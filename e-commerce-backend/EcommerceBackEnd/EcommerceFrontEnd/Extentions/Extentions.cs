using Microsoft.AspNetCore.DataProtection;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceFrontEnd.Extentions
{
    public static class Extentions
    {
        public static double CalculateDiscountValue(this double? dis,double price,string typeDiscount)
        {
            double discountValue;
            if (typeDiscount == "Percent")
            {
                discountValue = price - (price* Convert.ToDouble(dis)) / 100;
            }
            else
            {
                discountValue = price - Convert.ToDouble(dis);
            }
            return discountValue;
        }
        public static double FormartToDouble(this double value,string currency)
        {

            try
            {
                if (currency == "KHR" || currency=="៛")
                {
                    var result_convert = Convert.ToDouble(string.Format("{0:n0}", value)).ToString();
                    if (result_convert.Length > 2)
                    {
                        var lastTowDigit = Convert.ToDouble(result_convert.Substring(result_convert.Length - 2, 2));
                        if (lastTowDigit > 49)
                        {
                            var result = Convert.ToDouble(result_convert) - lastTowDigit + 100;
                            return result;
                        }
                        else
                        {
                            var result = Convert.ToDouble(result_convert) - lastTowDigit;
                            return result;
                        }
                    }
                    else if (result_convert.Length == 2)
                    {
                        if (Convert.ToDouble(result_convert) > 49)
                        {
                            return 100;
                        }
                        else
                        {
                            return Convert.ToDouble(result_convert);
                        }
                    }
                    else
                    {
                        return Convert.ToDouble(result_convert);
                    }
                }
                else if (currency == "THB" || currency== "฿")
                {
                    var data = Convert.ToDouble(string.Format("{0:n1}", value));
                    return data;
                }
                else
                {
                    var data = Convert.ToDouble(string.Format("{0:n2} ", value));
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong while fomart currency." + ex);
                return value;
            }
        }
        public static string Protection(this string message)
        {
            IDataProtector protector;
            protector = DataProtectionProvider.Create("EcommerceFrontEnd").CreateProtector("RouteValue");
            message = protector.Protect(message);
            return message;
        }
        public static string UnProtection(this string message)
        {
            IDataProtector protector;
            protector = DataProtectionProvider.Create("EcommerceFrontEnd").CreateProtector("RouteValue");
            message = protector.Unprotect(message);
            return message;
        }
        public static bool CheckArriralItem(this string Date)
        {
            var check = Convert.ToDateTime(Date).AddDays(90) >= DateTime.Now;
            if (check)
                return true;
            else
                return false;
        }
    }
}
