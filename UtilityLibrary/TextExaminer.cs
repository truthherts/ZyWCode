namespace UtilityLibrary
{
    public static class TextExaminer
    {
        /// <summary>
        /// Used to examine and obfuscate classified text, such as emails.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="noNoWords"></param>
        /// <returns>
        /// A flag is returned to state classified text was found. 
        /// If found, then the obfuscated text is returned, else the original email
        /// </returns>
        public static KeyValuePair<bool, string> ExamineClassifiedString(string? text, string? noNoWords)
        {
            KeyValuePair<bool, string> result = new KeyValuePair<bool, string>(false, text);
            List<string> noNoWordsList = new List<string>();

            if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(noNoWords))
            {
                noNoWordsList = noNoWords.Split(",").Select(x => x.Trim()).ToList();

                foreach (string word in noNoWordsList)
                {
                    if (text.Contains(word))
                    {
                        text = text.Replace(word, "***");
                    }
                }

                if (noNoWordsList.Count > 0)
                    result = new KeyValuePair<bool, string>(true, text);
            }

            return result;
        }
    }
}