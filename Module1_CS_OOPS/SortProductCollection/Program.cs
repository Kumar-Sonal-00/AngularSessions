namespace SortProductCollection
{
    enum SortChoice
    {
        ProductId=1,
        BrandName=2,
        Display=3,
        Exit=0
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            ProductManagement management = new ProductManagement();
            List<Product> products = null;
            do
            {
                Console.WriteLine("1.Sort By Product Id");
                Console.WriteLine("2.Sort By Brandname");
                Console.WriteLine("3.Display Products");
                Console.WriteLine("0.Exit");
                Console.Write("Enter choice:");
                choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case (int)SortChoice.ProductId:
                        //sort by product id
                        products=management.GetProductsSortById();
                        DisplayProducts(products);
                        break;
                    case (int)SortChoice.BrandName:
                        products = management.GetProductsSortByBrandname();
                        DisplayProducts(products);
                        //sort by brandname
                        break;
                    case (int)SortChoice.Exit:
                        Console.WriteLine("Exited");
                        break;
                    case (int)SortChoice.Display:
                        //display the products
                        products = management.GetProducts();
                        DisplayProducts(products);
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            } while(choice != 0);
        }

        static void DisplayProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
