using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System;

namespace XamarinAndroidListView
{
    [Activity(Label = "XamarinAndroidListView", MainLauncher = true)]
    public class MainActivity : Activity
    {
        public List<string> datos;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var Lista = FindViewById<ListView>(Resource.Id.ListSistemaOperativos);

            datos = new List<string>();
            datos.Add("Linux");
            datos.Add("Windows");
            datos.Add("MacOS");
            datos.Add("Beos");
            datos.Add("Android");
            datos.Add("Windows Phone");
            datos.Add("Symbian");
            datos.Add("BlackBerry");
            datos.Add("IOS");

            Lista.Adapter = new ArrayAdapter(this  , Android.Resource.Layout.SimpleListItem1,datos);
            Lista.ItemClick += ListClick;

        }

        private void ListClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var sistemasoperativos = datos[e.Position];
            Toast.MakeText(this, sistemasoperativos , ToastLength.Short).Show();
          //  throw new NotImplementedException();
        }
    }
}

