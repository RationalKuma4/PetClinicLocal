using System;
using System.IO;
using PetClinicLocal.Contracts;
using SQLite.Net;
using Xamarin.Forms;

[assembly: Dependency(typeof(PetClinicLocal.Droid.Dependencies.SqLiteService))]

namespace PetClinicLocal.Droid.Dependencies
{
    public class SqLiteService : IData
    {
        public SQLiteConnection GetConnection()
        {
            var fileName = "PetClinic.db3";
            var dataBasePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(dataBasePath, fileName);

            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLiteConnection(platform, path);

            return connection;
        }
    }
}