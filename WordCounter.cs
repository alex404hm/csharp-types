class WordCounter
{
    public int CountWords(string searchWord, string textSearch)
    {
        // Gøre alle ord til lowercase
        searchWord = searchWord.ToLower();
        
        // Splitter teksten op hver ord.
        string[] words = textSearch.ToLower().Split(' ');

        
        int count = 0;

        // loop tjekker om ordet starter med det
        foreach (string word in words)
        {
            if (word.StartsWith(searchWord))
            {
                count++;
            }
        }

        return count;
    }

    public bool? StatementCount(int count)
    {
        if (count == 0) return null;
        if (count < 10) return false;
        return true;
    }
}