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

namespace Mobile_A2_Practice
{

    [Activity(Label = "EditProfile")]
    public class EditProfile : Activity
    {
        TextView txt_FirstName;
        TextView txt_LastName;
        TextView txt_Mobile;
        TextView txt_Address;
        TextView txt_Country;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        /*public void OnEdit_Click(object sender, EventArgs e)
        {
            if (txt_FirstName.Text != "" || txt_LastName.Text != "" || txt_Mobile.Text != "" || txt_Address.Text != ""|| txt_Country.Text != "")
            {

                DatabaseManager.EditStudent(txt_Student_Name.Text, txt_Student_Email.Text, txt_Student_Mobile.Text, Student_Id);
                Toast.MakeText(this, "Student data Updated", ToastLength.Long).Show();
                this.Finish();
                StartActivity(typeof(MainActivity));
            }
            else
            {
                Toast.MakeText(this, "Please fill data in all fields", ToastLength.Long).Show();
            }
        }*/
    }

 
}