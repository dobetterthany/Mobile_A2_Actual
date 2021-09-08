using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Mobile_A2_Practice.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace Mobile_A2_Practice
{
   public class DatabaseManager
    {
        public static List<Rent_Houses> GetHouseData()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetStringAsync("http://10.0.2.2:48367/api/Rent_Houses");
            var House_Obj = JsonConvert.DeserializeObject<List<Rent_Houses>>(response.Result);
            return House_Obj.ToList();
        }
    }
}