﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net;
using System.Xml;
using BigCommerce.RestApi.Core;

namespace BigCommerce.RestApi.ConsoleApp
{
    class Program
    {
        static string api_key = "";
        static string username = "";
        static string baseUrl = "";

        static void Main(string[] args)
        {
            BigCommerceRestApi bigCommerceRestApi = new BigCommerceRestApi(api_key, username, baseUrl);
            List<orderstatus> statuses = bigCommerceRestApi.GetOrderStatuses();
            foreach (orderstatus os in statuses)
            {
                Console.WriteLine(os.name + Environment.NewLine);
            }

            Console.ReadLine();
        }

    }
}
