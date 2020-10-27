# hello-world
Hello world
Rajan Patil, Aundh, 1, Phone Cover, Rs 170, Cash
Mohit Gupta, Baner, 1, Samsung Battery, Rs 900, Credit Card
Rajan Patil, Aundh, 3, Samsung Battery, Rs 1000, Cash
Nina Kothari, Baner, 4, Earphones, Rs 500, Credit Card
T Sunitha, Shivajinagar, 5, Earphones, Rs 550, Credit Card
Rohan Gade, Aundh, 10, Motorola Battery, Rs 1000, Credit Card
Rajan Patil, Shivajinagar, 21, Earphones, Rs 550, Credit Card
Rajan Patil, Aundh, 22, USB Cable, Rs 150, UPI
Meena Kothari, Baner, 23, USB Cable, Rs 100, Cash
Nina Kothari, Baner, 24, USB Cable, Rs 200, UPI
Mohit Gupta, Baner, 25, USB Cable, Rs 150, UPI


The first column is customer name, the second column is store location, the third column is date (just day of the month is captured), the fourth column is product name, fifth is price, and sixth is payment type.


var result = data.GroupBy(l => l.Player)
             .Select(cl => new Foo()
             {
                Index = string.Join(", ", data.Where(d => d.Player == cl.Key).Select(d => d.Index).ToArray()),
                Player = cl.Key,
                Score = cl.Sum(c => c.Score)
             }).ToList();

    public static List<String> processData(IEnumerable<string> lines)
        {
            List<ProductModel> productlist = new List<ProductModel>();
            ProductModel objProduct = new ProductModel();
            foreach (var item in lines)
            {
                string[] split = item.Split(',');
                objProduct.CustomerName = split[0];
                //  objProduct.StoreLocation = split[1];
                //   objProduct.Day = Convert.ToInt16(split[2]);
                objProduct.ProductName = split[3];
                objProduct.Price = Convert.ToInt16(split[4].Replace("Rs", string.Empty));
                //  objProduct.PaymentType = split[5];
                productlist.Add(objProduct);
                objProduct = new ProductModel();
            }
            var results = productlist
                .GroupBy(x => new { objProduct.ProductName, objProduct.Price}).ToList();

            foreach (var item in results)
            {
                foreach (var user in item)
                {
                    int price = user.Price;
                }
            }

            List<String> retVal = new List<String>();
            return retVal;
        }
