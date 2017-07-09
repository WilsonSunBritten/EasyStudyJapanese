using EasyStudyJapanese.DatabaseItems;
using SQLite;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EasyStudyJapanese
{
    class DataAccessor
    {
        private static DataAccessor accessor;
        SQLiteConnection dbConn;

        private DataAccessor()
        {
            dbConn = DependencyService.Get<ISQLite>().GetConnection();
        }

        public static DataAccessor getDataAccessor()
        {
            if(accessor == null)
            {
                accessor = new DataAccessor();
            }
            return accessor;
        }

        public Word getWordById(int id)
        {
            return dbConn.Query<Word>(String.Format("Select * from Words where Id = {0}", id)).FirstOrDefault<Word>();
        }

        public List<WordList> getWordLists()
        {
            return dbConn.Query<WordList>("Select Id as wordListID, Name as wordListName From WordLists");
        }
    }
}
