namespace StringMethods_05_11_2019
{
    class StringMethod
    {
        public string str;
        

        public int GetLength(string phrase)
        {
            int length = 0;
            foreach (char i in str)
            {
                length++;
            }
            return length;
        }

        public string Substring(int fromIndex, int count)
        {
            string result = string.Empty;
            for (int i = fromIndex; i < fromIndex + count; i++)
            {
                result += str[i]; 
            }
            return result;
        }

        public int IndexOf(string phrase)
          {
            int indx = -1;
            int phraseLength = phrase.Length;

            for (int i = 0; i < str.Length; i++)
            {
                if (Substring(i, GetLength(phrase)) == phrase)
                {
                    indx = i;
                    
                }
            }
            return indx;
        }
        public bool Contains(string phrase)
        {
            bool indx = false;
            int phraseLength = phrase.Length;

            for (int i = 0; i < str.Length; i++)
            {
                if (Substring(i, GetLength(phrase)) == phrase)
                {
                    indx = true;

                }
            }
            return indx;
        }
        public string Replace(string oldValue,string newValue)
        {
            int oldval = IndexOf(oldValue);
            int from = oldval + oldValue.Length;
            string old = Substring(0, oldval);
            string rightSide = Substring( from, str.Length - from);

            return old + newValue + rightSide;
        }

    }
}
