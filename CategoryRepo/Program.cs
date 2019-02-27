using System;
using System.Collections.Generic;
using CategoryRepo.DatabaseConnections;
using CategoryRepo.Repositories;
using Ninject;

namespace CategoryRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            //PostgreDatabaseConnection postgreDataConnection = new PostgreDatabaseConnection();
            //SqlServerDataConnection sqlServerDataConnection = new SqlServerDataConnection();
            //postgreDataConnection.ConnectDatabase();

            //CategoryRepository categoryRepository = new CategoryRepository(postgreDataConnection);
            //ProductRepository productRepository = new ProductRepository(sqlServerDataConnection);
            //List<Category> categories = categoryRepository.GetCategories();
            //List<Product> products = productRepository.GetProducts();
            //postgreDataConnection.DisConnectDatabase();

            IKernel kernel = new StandardKernel(new Bindings());
            ProductRepository productRepository = kernel.Get<ProductRepository>();
            List<Product> products = productRepository.GetProducts();

            Console.ReadLine();

        }
    }
}
