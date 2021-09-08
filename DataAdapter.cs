using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Mobile_A2_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobile_A2_Practice
{
    class DataAdapter : BaseAdapter<Rent_Houses>
    {
        private readonly Activity context;
        private readonly List<Rent_Houses> items;
        public DataAdapter(Activity context, List<Rent_Houses> items)
        {
            this.context = context;
            this.items = items;
        }
        public override Rent_Houses this[int position]
        {
            get { return items[position]; }
        }

        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            var view = convertView;
            if (view == null) // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.DisplayHouseData, null);
            view.FindViewById<TextView>(Resource.Id.lblName).Text = item.House_Title;
            view.FindViewById<TextView>(Resource.Id.lblviewhadd).Text = item.House_Address;
            view.FindViewById<TextView>(Resource.Id.lblviewhrent).Text = Convert.ToString(item.House_WeeklyRent);
            return view;
        }
    }
}