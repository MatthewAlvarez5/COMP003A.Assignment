namespace COMP003A.Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printSeparator("Array - CharacterCounter"); //Section Title

            Console.Write("Please Enter a Letter: ");
            char characterInput = Convert.ToChar(Console.ReadLine());
    
            
            Console.Write("Please Enter a Word: ");
            string wordInput = Convert.ToString(Console.ReadLine());
          
            
            int letterCount = characterCounter(characterInput, wordInput);
            
            /* if statements for grammar purposes */
            if (letterCount > 1)
            {
                Console.WriteLine($"There are {letterCount} {characterInput}'s in \"{wordInput}\"");
            }
            else if (letterCount == 1)
            {
                Console.WriteLine($"There is {letterCount} {characterInput} in \"{wordInput}\"");
            }
            else
            {
                Console.WriteLine($"There are no {characterInput}'s in \"{wordInput}\"");
            }

            printSeparator("Array - IsPalindrome"); //Section Title

            Console.Write("Enter a word: ");
            string palindromeInput = Convert.ToString(Console.ReadLine());
            bool palindrome = IsPalindrome(palindromeInput);
            Console.WriteLine($"(T/F) The word {palindromeInput} is a palindrome: {palindrome}");
        }


        /// <summary>
        /// Prints Section Title
        /// </summary>
        /// <param name="sectionTitle">String input</param>
        static void printSeparator(string sectionTitle)
        {
            Console.WriteLine("".PadRight(50, '-'));
            Console.WriteLine($"\t{sectionTitle} Section");
            Console.WriteLine("".PadRight(50, '-'));
        }

        /// <summary>
        /// Counts the amount of instances a letter has in a word
        /// </summary>
        /// <param name="characterInput">Character input</param>
        /// <param name="word">string input</param>
        /// <returns></returns>
        static int characterCounter(char characterInput, string word)
        {
            word = word.ToLower();
            characterInput = char.ToLower(characterInput);

            int counter = 0;

            foreach (char c in word) 
            {
                if (c == characterInput)
                {
                    counter++;
                }
            }
            return counter;
        }

        /// <summary>
        /// Tests for Palindrome word
        /// </summary>
        /// <param name="wordInput">String Input</param>
        /// <returns></returns>
        static bool IsPalindrome(string wordInput)
        {
            wordInput = wordInput.ToLower();
            char[] characterArray = wordInput.ToCharArray();
            Array.Reverse(characterArray);
            string reverseWord = new string(characterArray);
            
            return reverseWord==wordInput;
        }

        static void TraverseList(List<string>list)
        {

        }

    }
}