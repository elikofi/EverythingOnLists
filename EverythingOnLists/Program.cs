using EverythingOnLists;
using System.Collections.Generic;
using System.Linq;

//var productList = new List<string>
//{
//    "Product 001",
//    "Product 002",
//    "Product 003",
//    "Product 004"
//};


//productList.Add("Product 005");

//var newProductList = new List<string>
//{
//    "Product A",
//    "Product B",
//    "Product C"
//};
//productList.AddRange(newProductList);

//productList.Insert(2, "Product Inserted");

//productList.Remove("Product 001");

//var result = productList.Contains("Product 003");
////Console.WriteLine(result);







//for (int i = 0; i < productList.Count; i++)
//{
//    var productName = productList[i];
//    Console.WriteLine(productName);
//}


/*  USING THE CLASS PRODUCT    */


var productList = new List<Product>
{
    new Product
    {
        ProductCode = "101",
        ProductName = "Product 101",
        Price = 100
    },
    new Product
    {
        ProductCode = "102",
        ProductName = "Product 102",
        Price = 200
    },
    new Product
    {
        ProductCode = "103",
        ProductName = "Product 103",
        Price = 300
    }

};
////using the exists method
//var result = productList.Exists(x => x.Price > 300);
//Console.WriteLine(result); //will return false.
////using the find method
//var pFind = productList.FindAll(x => x.Price > 100);
//Console.WriteLine(pFind);

/*adding a new product   */
productList.Add(new Product
{
    ProductCode = "104",
    ProductName = "Product 104",
    Price = 400
});
//removing some products
productList.RemoveAt(2);

//using the remove all method to remove some products.
//productList.RemoveAll(x => x.Price > 200);

// using the the sum method to sum up the prices of all the products
var priceSum = productList.Sum(x => x.Price);
Console.WriteLine(priceSum);


foreach (var product in productList) 
{
    Console.WriteLine($"Name: {product.ProductName} | Code: {product.ProductCode} | Price: {product.Price}");
}


Console.ReadLine();