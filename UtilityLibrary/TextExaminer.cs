namespace UtilityLibrary
{
    public static class TextExaminer
    {
        /// <summary>
        /// Used to examine and obfuscate classified text, such as emails.
        /// </summary>
        /// <param name="emailText"></param>
        /// <param name="noNoWords"></param>
        /// <returns>
        /// A flag is returned to state classified text was found. 
        /// If found, then the obfuscated text is returned, else the original email
        /// </returns>
        public static KeyValuePair<bool, string> ExamineClassifiedString(string? emailText, string? noNoWords)
        {
            //Test
            KeyValuePair<bool, string> result = new KeyValuePair<bool, string>(false, emailText);
            List<string> noNoWordsList = new List<string>();

            if (!string.IsNullOrEmpty(emailText) && !string.IsNullOrEmpty(noNoWords))
            {
                noNoWordsList = noNoWords.Split(",").Select(x => x.Trim()).ToList();

                foreach (string word in noNoWordsList)
                {
                    if (emailText.Contains(word))
                    {
                        emailText = emailText.Replace(word, "***");
                    }
                }

                if (noNoWordsList.Count > 0)
                    result = new KeyValuePair<bool, string>(true, emailText);
            }

            return result;
        }
    }
}