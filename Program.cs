
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/* Don't change anything here.
 * Do not add any other imports. You need to write
 * this program using only these libraries 
 */

namespace ProgramNamespace
{
    /* You may add helper classes here if necessary */

    public class ProductModel
    {
        public string CustomerName { get; set; }
        public string StoreLocation { get; set; }
        public int Day { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string PaymentType { get; set; }
    }


    public class Program
    {
        public static List<String> processData(IEnumerable<string> lines)
        {
            List<ProductModel> ListOFProducts = new List<ProductModel>();
            ProductModel objProduct = new ProductModel();
            foreach (var item in lines)
            {
                string[] split = item.Split(',');
                objProduct.CustomerName = split[0];
                objProduct.StoreLocation = split[1];
                objProduct.Day = Convert.ToInt16(split[2]);
                objProduct.ProductName = split[3];
                objProduct.Price = Convert.ToInt16(split[4].Replace("Rs", string.Empty));
                objProduct.PaymentType = split[5];
                ListOFProducts.Add(objProduct);
                objProduct = new ProductModel();
            }
            List<String> retVal = new List<String>();
            List<ProductModel> listOfMaxPriceCustomer = ListOFProducts.OrderByDescending(o => o.Price).GroupBy(o => o.ProductName).Select(o => o.First()).ToList();
            retVal = ListOFProducts.Select(x => x.CustomerName).Except(listOfMaxPriceCustomer.Select(x => x.CustomerName)).ToList();
            return retVal;
        }

        static void Main(string[] args)
        {
            try
            {
                String line;
                var inputLines = new List<String>();
                while ((line = Console.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (line != "")
                        inputLines.Add(line);
                }
                var retVal = processData(inputLines);
                foreach (var res in retVal)
                    Console.WriteLine(res);

                //Console.ReadLine();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}