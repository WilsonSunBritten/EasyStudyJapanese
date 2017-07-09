using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudyJapanese.DatabaseItems
{
    class WordList
    {
        public int wordListId { get; set; }
        public String wordListName { get; set; }
        List<WordListItem> wordListItems = new List<WordListItem>();
        int currentIndex = 0;
        DataAccessor db = DataAccessor.getDataAccessor();

        public void shuffle()
        {
            Random rand = new Random();
            for(var i = 0; i < wordListItems.Count; i++)
            {
                int randomIndex = rand.Next(i, wordListItems.Count);
                var temp = wordListItems[i];
                wordListItems[i] = wordListItems[randomIndex];
                wordListItems[randomIndex] = temp;
            }
            currentIndex = 0;
        }

        public Word getCurrentWord()
        {
            return db.getWordById(wordListItems[currentIndex].wordId);
        }

        public Word getNextWord()
        {
            if (currentIndex + 1 == wordListItems.Count)
                currentIndex = 0;
            else
                currentIndex++;
            return getCurrentWord();
        }

        public Word getPrevWord()
        {
            if (currentIndex != 0)
                currentIndex--;
            return getCurrentWord();
        }

    }

    class WordListItem
    {
        public int wordId { get; set; }

    }
}
