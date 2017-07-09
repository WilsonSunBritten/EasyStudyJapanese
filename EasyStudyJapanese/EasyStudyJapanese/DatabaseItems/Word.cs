using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudyJapanese.DatabaseItems
{
    class Word
    {
        public int Id { get; set; }
        public String kanaWord { get; set; }
        public String englishPronounce { get; set; }
        public String kanjiWord { get; set; }
        public String englishMeaning { get; set; }
        public int ExampleId { get; set; }
        public int kanjiListId { get; set; }
    }
}
