using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Mobile_A2_Practice.Models;
using System.Collections.Generic;

namespace Mobile_A2_Practice
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView LV;
        List<Rent_Houses> myList = new List<Rent_Houses>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            LV = FindViewById<ListView>(Resource.Id.listView1);
            myList = DatabaseManager.GetHouseData();
            LV.Adapter = new DataAdapter(this, myList);
            LV.ItemClick += LV_ItemClick;
        }

        private void LV_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var House_Item = myList[e.Position];

            var View_House_item = new Intent(this, typeof(ViewHouse_Activity));
            View_House_item.PutExtra("House_Id", House_Item.Id);
            View_House_item.PutExtra("House_Title", House_Item.House_Title);
            View_House_item.PutExtra("House_Address", House_Item.House_Address);
            View_House_item.PutExtra("House_Rent", House_Item.House_WeeklyRent);
            View_House_item.PutExtra("House_Beds", House_Item.House_Bedroom);
            View_House_item.PutExtra("House_Baths", House_Item.House_Bathroom);

            //Toast.MakeText(this, Tutor_Item.Id.ToString(), ToastLength.Long).Show();

            StartActivity(View_House_item);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}