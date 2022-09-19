var productList = new List<string>
{
    "Product 001",
    "Product 002",
    "Product 003",
    "Product 004"
};


/* using the add method*/
productList.Add("Product 005");

var newProductList = new List<string>
{
    "Product A",
    "Product B",
    "Product C"
};
/*using addrange method*/
productList.AddRange(newProductList);

/*using insert method*/
productList.Insert(2, "Product Inserted");

/*using remove method*/
productList.Remove("Product 001");



for (int i = 0; i < productList.Count; i++)
{
    var productName = productList[i];
    Console.WriteLine(productName);
}






Console.ReadLine();