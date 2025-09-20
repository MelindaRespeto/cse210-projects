using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    class Scripture
    {
        private string _reference;
        private List<Word> _words;

        public Scripture(string reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(w => new Word(w)).ToList();
        }

        public void HideRandomWords(int count)
        {
            var rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int index = rnd.Next(_words.Count);
                _words[index].Hide();
            }
        }

        public bool AllWordsHidden()
        {
            return _words.All(w => w.IsHidden);
        }

        public string GetDisplayText()
        {
            return _reference + "\n" + string.Join(" ", _words.Select(w => w.GetDisplayText()));
        }
    }
}

