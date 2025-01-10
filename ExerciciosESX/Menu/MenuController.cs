using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosESX.Exercicios;

namespace ExerciciosESX.Menu
{
    internal class MenuController
    {
        private ExercisesP exercisesP;

        public MenuController()
        {
            exercisesP = new ExercisesP();
        }
        public void Show()
        {
            bool isRunning = true;

            while (isRunning)
            {
                DisplayMenu();

                string input = Console.ReadLine();

                if (!int.TryParse(input, out int optionInput))
                {
                    Console.WriteLine("Invalid entry, please try again");
                    continue;
                }
                if (!Enum.IsDefined(typeof(MenuOption), optionInput))
                {
                    Console.WriteLine("Invalid option.Choose a number between 1 and 9");
                    continue;
                }
                MenuOption selectOption = (MenuOption)optionInput;

                switch (selectOption)
                {
                    case MenuOption.OddOrEven:
                        HandleOddOrEven();
                        break;
                    case MenuOption.PrimeCheck:
                        HandlePrimeCheck();
                        break;
                    case MenuOption.StringInversion:
                        HandleStringInversion();
                        break;
                    case MenuOption.ArraySorting:
                        HandleArraySorting();
                        break;
                    case MenuOption.CharacterCount:
                        HandleCharacterCount();
                        break;
                    case MenuOption.LargestElement:
                        HandleLargestElement();
                        break;
                    case MenuOption.ArraySum:
                        HandleArraySum();
                        break;
                    case MenuOption.NameOrdering:
                        HandleNameOrdering();
                        break;
                    case MenuOption.Exit:
                        isRunning = false;
                        Console.WriteLine("Closed program");
                        break;
                }
                if (isRunning)
                {
                    Console.WriteLine("Press any button to go back...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("*** Enter a number to use our tools ***");
            Console.WriteLine("1. Check if the number is Odd or Even");
            Console.WriteLine("2. Check if the number is Prime");
            Console.WriteLine("3. Reverse a String");
            Console.WriteLine("4. Sort an Array");
            Console.WriteLine("5. Count Characters in a String");
            Console.WriteLine("6. Find the Largest Element in an Array");
            Console.WriteLine("7. Sum all Elements in an Array");
            Console.WriteLine("8. Sort a List of Names");
            Console.WriteLine("9. Exit");
            Console.Write("Select an option (1-9): ");
        }

        private void HandleOddOrEven()
        {
            Console.WriteLine("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out int userNumber))
            {
                string result = exercisesP.checkEvenAndOddNumbers(userNumber);
                Console.WriteLine($"The number is {result}");
            }
            else
            {
                Console.WriteLine("Invalid entry, please try again");
            }
        }
        private void HandlePrimeCheck()
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out int userNumber))
            {
                String resultIsPrime = exercisesP.checkPrimeNumber(userNumber) ? "prime" : "not prime";
                Console.WriteLine($"The number is {resultIsPrime}");
            }
            else
            {
                Console.WriteLine("Invalid entry, please try again");
            }
        }
        private void HandleStringInversion()
        {
            Console.Write("Enter String: ");
            string word = Console.ReadLine();
            string inverted = exercisesP.invertWord(word);
            Console.WriteLine($"Inverted word: {inverted}");
        }

        private void HandleArraySorting()
        {
            Console.WriteLine("Array size: ");
            if(!int.TryParse(Console.ReadLine(),out int size) || size <= 0)
            {
                Console.WriteLine("Invalid size. Please enter a value greater than zero");
                return;
            }
            int[] arr = ReadNumbersIntoArray(size);
            if (arr == null) return;

            Console.WriteLine("Origin Array: ");
            exercisesP.showVector(arr);
            Console.WriteLine();
            Console.WriteLine("Sorted array: ");
            exercisesP.insertionSort(arr);
            exercisesP.showVector(arr);
        }
        private void HandleCharacterCount()
        {
            Console.WriteLine("Enter String: ");
            string word = Console.ReadLine();
            Console.WriteLine("The word has: ");
            Dictionary<char, int> wordsCounted = exercisesP.countChar(word);
            exercisesP.showLetters(wordsCounted);
        }
        private void HandleLargestElement()
        {
            Console.WriteLine("Array size: ");
            if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                Console.WriteLine("Invalid size. Please enter a value greater than zero");
                return;
            }
            int[] arr = ReadNumbersIntoArray(size);
            if (arr == null) return;

            List<int> listNumbers = new List<int>();
            listNumbers.AddRange(arr);
            try
            {
                int largest = exercisesP.biggerNumber(listNumbers);
                Console.WriteLine($"The largest number is: {largest}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void HandleArraySum()
        {
            Console.WriteLine("Array size: ");
            if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                Console.WriteLine("Invalid size. Please enter a value greater than zero");
                return;
            }
            int[] arr = ReadNumbersIntoArray(size);
            if (arr == null) return;

            int sum = arr.Sum();
            Console.WriteLine($"Sum of all array elements is {sum}");
        }

        private void HandleNameOrdering()
        {
            Console.WriteLine("Enter how many names you will sort: ");
            if(!int.TryParse(Console.ReadLine(), out int nameCount) || nameCount <= 0)
            {
                Console.WriteLine("Invalid input for number of names");
                return;
            }
  
            List<String> names = new();

            for (int i = 0; i < nameCount; i++)
            {
                Console.Write($"Name {i + 1}: ");
                names.Add(Console.ReadLine());
            }

            List<String> orderedList = exercisesP.orderingList(names);
            Console.WriteLine("Names ordered: ");
            exercisesP.showVector(orderedList);
            Console.WriteLine();
        }
        private int[] ReadNumbersIntoArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput,out int number))
                {
                    arr[i] = number;
                }
                else
                {
                    Console.WriteLine("Invalid entry, please try again");
                    i--;
                }
            }
            return arr;
        }
    }
}
