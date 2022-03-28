using EF_Library.Repositories;
using Microsoft.Extensions.DependencyInjection;
using PetShopLib.Impl;
using System.Transactions;
using Transaction = PetShopLib.Impl.Transaction;

namespace Session_11
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddSingleton<IEntityRepo<Customer>, CustomerRepo>();
            services.AddSingleton<IEntityRepo<Transaction>, TransactionRepo>();
            services.AddSingleton<IEntityRepo<Pet>, PetRepo>();
            services.AddSingleton<IEntityRepo<PetFood>, PetFoodRepo>();

            services.AddSingleton<MainForm>();

            ServiceProvider = services.BuildServiceProvider();
            var mainForm = ServiceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }
    }
}