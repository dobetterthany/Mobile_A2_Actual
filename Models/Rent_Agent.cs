using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobile_A2_Practice.Models
{
    public class Rent_Agent
    {
        public int Id { get; set; }
        public string Agent_Name { get; set; }
        public string Agent_Email { get; set; }

        public string Agent_Phone { get; set; }
        public string Agent_Office { get; set; }
    }
}