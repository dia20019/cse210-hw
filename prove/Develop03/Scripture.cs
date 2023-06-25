using System;
namespace classes
{
    class Scripture
    {
        public string Reference { get; private set; }
        public string Text { get; private set; }
        public string[] Words { get; private set; }
        public int WordCount { get; private set; }
        public HashSet<int> HiddenWordIndex { get; private set; }

        public Scripture(string reference, string text)
        {
            Reference = reference;
            Text = text;
            Words = text.Split(' ');
            WordCount = Words.Length;
            HiddenWordIndex = new HashSet<int>();
        }
    }
    // Tried extracting text from the Scriptures using the .txt version of the standard Works but never found the way to do it.
    // The texts are there however in case users want to check the actual words in a reference and copy paste them
}
