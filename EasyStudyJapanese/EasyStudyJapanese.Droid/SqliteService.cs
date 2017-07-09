using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using SQLite.Net;

[assembly: Xamarin.Forms.Dependency(typeof(EasyStudyJapanese.Droid.SqliteService))]
namespace EasyStudyJapanese.Droid
{
    class SqliteService : ISQLite
    {
        public SqliteService() { }

        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "EasyStudyJapaneseDatabase";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            if (!File.Exists(path))
            {
                var asset = Android.App.Application.Context.Assets.Open("easyJapaneseDatabase.db");
                var dest = File.Create(path);
                asset.CopyTo(dest);
            }
            
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLite.Net.SQLiteConnection(plat, path);
            return conn;
        }
    }
}