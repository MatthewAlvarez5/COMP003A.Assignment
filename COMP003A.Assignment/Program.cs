/*
 * Author: Matthew Alvarez
 * Course: COMP-003A
 * Purpose: Array and List Assignment
 */

namespace COMP003A.Assignment7
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
            
            if (letterCount > 1)    //if statements for grammar purposes
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

            /* isPalindrome section */
            printSeparator("Array - IsPalindrome"); //Section Title

            Console.Write("Enter a word: ");
            string palindromeInput = Convert.ToString(Console.ReadLine());
            bool palindrome = isPalindrome(palindromeInput);
            if (palindrome == true) //grammar if-statements
            {
                Console.WriteLine($"The word \"{palindromeInput}\" is a palindrome");
            }
            else
            {
                Console.WriteLine($"The word \"{palindromeInput}\" is NOT a palindrome");
            }

            /* list add section */
            printSeparator("List - Add"); //Section Title

            List<string> names = new List<string>();
            char userInput = default;
            string nameInput;
            bool end;

            do
            {
                Console.Write("Please enter a name: ");
                nameInput = Convert.ToString(Console.ReadLine());
                names.Add(nameInput);
                Console.Write("Press any key to continue adding names or press (e) to exit: ");
                userInput = Convert.ToChar(Console.ReadLine());
                userInput = char.ToLower(userInput);
                if (userInput=='e')
                {
                    break;
                }
            } while(true); /* while (userInput != 'e'); ---> wouldn't exit loop for some reason */

            /* list traversal section */
            printSeparator("List - Traversal"); //Section Title
            traverseList(names);

            /* list reverse traversal section */
            printSeparator("List - Reverse Traversal"); //Section Title
            traverseListReverse(names);

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
        static bool isPalindrome(string wordInput)
        {
            wordInput = wordInput.ToLower();
            char[] characterArray = wordInput.ToCharArray();
            Array.Reverse(characterArray);
            string reverseWord = new string(characterArray);
            
            return reverseWord==wordInput;
        }

        /// <summary>
        /// Method to Traverse Given list
        /// </summary>
        /// <param name="list">String list input</param>
        static void traverseList(List<string>list)
        {
            foreach (var item in list) 
            { 
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Method Traverses Given list in reverse
        /// </summary>
        /// <param name="list"></param>
        static void traverseListReverse(List<string>list)
        {
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}