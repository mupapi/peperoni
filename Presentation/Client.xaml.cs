﻿using Infrastructure.Encryption;
using Infrastructure.Repository;
using Domain.Service;
using Newtonsoft.Json;
using Presentation.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Infrastructure.Data;
using Domain.Builder;
using Domain.Model.PizzaShop;
using Domain.Repository;
using Presentation.Pages;
using Domain.Rule.Validator;
using System.Security.Cryptography;
using Infrastructure.Builder;

namespace Presentation {
    /// <summary>
    /// Interaction logic for Client.xaml
    /// </summary>
    public partial class Client : Window {
        public Client() {
            InitializeComponent();

            /* Account controller example */
            var accountController = new AccountController();
            var account = accountController.Retrieve("1a4095c1-d9f2-4546-873e-3993d86371c6");
            Console.WriteLine($"Fetched account: {JsonConvert.SerializeObject(account, Formatting.Indented)}");

            //account.Name = "Mr. Winter";
            //account = accountController.Update(account);

            ICollection<Filter> filters = new List<Filter> {
                new FilterBuilder().WithKey("Name").WithValue("Mr. Winter").Build(),
                new FilterBuilder().WithKey("Phone").WithValue("119909190").Build(),
            };

            var accountTest = new AccountRepository().Filter(filters);

            ///* Order controller example */
            //var orderController = new OrderExplorerController();

            //var newOrder = new OrderBuilder()
            //    .WithAccount(account.Id)
            //    .WithStatus("Enqueued")
            //    .WithPaymentStatus("Unpaid")
            //    .PlacedOn(DateTime.Today)
            //    .DeliveredOn(null)
            //    .Build();

            //orderController.Create(newOrder);

            //var accountOrders = orderController.SearchByAccount(account);
            //Console.WriteLine($"Fetched orders: {JsonConvert.SerializeObject(accountOrders, Formatting.Indented)}");

            //var anOrder = accountOrders.First();
            //anOrder.Status = "Enqueued";

            //orderController.Update(anOrder);
            //Console.WriteLine($"Saved order: {JsonConvert.SerializeObject(anOrder, Formatting.Indented)}");

            /* Account Explorer controller example */
            //var accountExplorer = new AccountExplorerController();
            //var foundAccounts = accountExplorer.SearchByName("Mr");
            //Console.WriteLine($"Found accounts: {JsonConvert.SerializeObject(foundAccounts, Formatting.Indented)}");

            this.Content = new Home();
        }
    }
}

