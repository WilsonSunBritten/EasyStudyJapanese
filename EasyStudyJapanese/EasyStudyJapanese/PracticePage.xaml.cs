using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EasyStudyJapanese
{
    public partial class PracticePage : ContentPage
    {
        DataAccessor db = DataAccessor.getDataAccessor();
        public PracticePage()
        {
            InitializeComponent();
            initializeWordList();
            var item = db.getWordById(1);
            db.getWordById(2);
        }

        private void initializeWordList()
        {
            foreach(var list in db.getWordLists())
            {
                wordList.Items.Add(list.wordListName);
            }
        }
    }
}
