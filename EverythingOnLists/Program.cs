var productList = new List<string>
{
    "Product 001",
    "Product 002",
    "Product 003",
    "Product 004"
};

for (int i = 0; i < productList.Count; i++)
{
    var productName = productList[i];
    Console.WriteLine(productName);
}

Console.ReadLine();