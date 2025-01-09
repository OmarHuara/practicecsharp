using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosESX.Exercicios
{
    public class ExercisesP
    {
        public String checkEvenAndOddNumbers(int nro)
        {
            return nro % 2 == 0 ? "Even" : "Odd";
        }

        public Boolean checkPrimeNumber(int number)
        {
            if (number <= 1)
            {
                return false;
            } 
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) 
                { 
                    return false;
                }
            }
            return true;
        }
        public String invertWord(String request)
        {
            String result = "";
            char[] arr = request.ToCharArray();
            foreach (var item in arr)
            {
                result = item + result; 
            }
            return result;
        }
        public void insertionSort(int[] vector)
        {
            int i, j, x;
            for (i = 1; i < vector.Length; i++)
            {
                x = vector[i];
                j = i - 1;
                while (j >= 0 && x < vector[j])
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                vector[j + 1] = x;
            }
        }

        public void showVector(int[] vector)
        {
            for(int i = 0; i < vector.Length; i++) 
            {
                Console.Write($"[ {vector[i]} ]");
            }
        }
        public void countChar(String word)
        {
            String wordLower = word.ToLower();
            char[] vectorLettersWord = wordLower.ToCharArray();

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach(char letter in vectorLettersWord)
            {
                if (charCounts.ContainsKey(letter))
                {
                    charCounts[letter]++;
                } else
                {
                    charCounts[letter] = 1;
                }
            } 

            showLetters(charCounts);
        }
        private void showLetters(Dictionary<char, int> charCounts)
        {
            foreach(var entry in charCounts)
            {
                Console.WriteLine("["+ entry.Key +"]["+ entry.Value +"]");
            }
        }

        public int biggerNumber(List<int> numbers)
        {
            return numbers.Max();
        }
        internal List<string> orderingList(List<string> names)
        { 
            return names.OrderBy(x => x).ToList();
        }
        internal void showVector(List<string> orderedList)
        {
            foreach (var pair in orderedList)
            {
                Console.Write("[" + pair + "]");
            }
        }
    }
}
