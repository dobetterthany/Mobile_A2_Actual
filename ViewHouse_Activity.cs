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
using Xamarin.Essentials;

namespace Mobile_A2_Practice
{
    [Activity(Label = "ViewHouse_Activity")]
    public class ViewHouse_Activity : Activity
    {
        int House_Id;


        TextView txt_htitle;
        TextView txt_haddress;
        TextView txt_hweeklyrent;
        TextView txt_hbeds;
        TextView txt_hbaths;
        ImageView HouseImage;
        ImageButton maptravel;
        string housename;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            

            // Create your application here
            SetContentView(Resource.Layout.ViewHouse);
            HouseImage = FindViewById<ImageView>(Resource.Id.imageView1);
            txt_htitle = FindViewById<TextView>(Resource.Id.lblhousetitle);
            txt_haddress = FindViewById<TextView>(Resource.Id.lblhouseaddress);
            txt_hweeklyrent = FindViewById<TextView>(Resource.Id.lblweeklyrent);
            txt_hbeds = FindViewById<TextView>(Resource.Id.housebed);
            txt_hbaths = FindViewById<TextView>(Resource.Id.housebath);
            maptravel = FindViewById<ImageButton>(Resource.Id.imageButton1);
            maptravel.Click += Maptravel_Click;

            House_Id = Intent.GetIntExtra("House_Id", -1); //-1 is default
            txt_htitle.Text = Intent.GetStringExtra("House_Title");
            housename = Intent.GetStringExtra("House_Title");
            txt_haddress.Text = Intent.GetStringExtra("House_Address");
            txt_hweeklyrent.Text = Convert.ToString(Intent.GetDoubleExtra("House_Rent", -1));
            txt_hbeds.Text = Convert.ToString(Intent.GetIntExtra("House_Beds", -1));
            txt_hbaths.Text = Convert.ToString(Intent.GetIntExtra("House_Baths", -1));

           if (housename == "Santa Barbara")
            {
                HouseImage.SetImageResource(Resource.Drawable.SantaBarbara);   
            }
           else if (housename == "San Jose")
            {
                HouseImage.SetImageResource(Resource.Drawable.SanJose);
            }
            else if (housename == "Verdana")
            {
                HouseImage.SetImageResource(Resource.Drawable.Verdana);
            }


        }

        private async void Maptravel_Click(object sender, EventArgs e)
        {
            var address = txt_haddress.Text;
            var locations = await Geocoding.GetLocationsAsync(address);
            var location = locations?.FirstOrDefault();

        }
    }
}